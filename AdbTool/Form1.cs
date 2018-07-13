using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AdbTool
{
    public partial class Form1 : Form
    {
        enum Command
        {
            DEVICES,
            CONNECT,
            DISCONNECT,
            INSTALL,
            REINSTALL,
            UNINSTALL,
            PREDEVICES,
            SHOW,
            LOGCAT,
            DATACLEAR,
        }
        Command currentCommand;
        List<Process> processs = new List<Process>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 値を保存する
            Properties.Settings.Default.RichTextBoxIp = this.RichTextBoxIp.Text;
            Properties.Settings.Default.RichTextBoxApk = this.RichTextBoxApk.Text;
            Properties.Settings.Default.RichTextBoxPackageName = this.RichTextBoxPackageName.Text;
            Properties.Settings.Default.CheckBoxAllDevices = this.CheckBoxAllDevices.Checked;
            Properties.Settings.Default.Save();

            // プロセスを開放する
            processs.ForEach(_ => _.Close());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 起動時に接続されているデバイスを探す
            currentCommand = Command.PREDEVICES;
            ComboBoxDevices.Items.Clear();
            sendCommandNoWindow("adb devices ");

            // 前回の値を取得し、表示する
            this.RichTextBoxIp.Text = Properties.Settings.Default.RichTextBoxIp;
            this.RichTextBoxApk.Text = Properties.Settings.Default.RichTextBoxApk;
            this.RichTextBoxPackageName.Text = Properties.Settings.Default.RichTextBoxPackageName;
            this.CheckBoxAllDevices.Checked = Properties.Settings.Default.CheckBoxAllDevices;
        }

        private void sendCommand(string command)
        {
            //Processオブジェクトを作成
            Process process = new Process();

            //出力とエラーをストリームに書き込むようにする
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            process.StartInfo.RedirectStandardInput = false;
            process.StartInfo.Arguments = @"/c " + command;

            //起動
            process.Start();
            processs.Add(process);

            // 標準入力を取得
            //StreamWriter streamWriter = process.StandardInput;

            // 出力
            showCommand(command);

            //streamWriter.WriteLine(comand);

            //非同期で出力とエラーの読み取りを開始
            //process.BeginOutputReadLine();
            //process.BeginErrorReadLine();

            //process.WaitForExit();
            //process.Close();

            //Console.ReadLine();
        }

        private void sendCommandNoWindow(string command)
        {
            //Processオブジェクトを作成
            Process process = new Process();

            //出力とエラーをストリームに書き込むようにする
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            //OutputDataReceivedとErrorDataReceivedイベントハンドラを追加
            process.OutputDataReceived += OutputDataReceived;
            process.ErrorDataReceived += ErrorDataReceived;

            process.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            process.StartInfo.RedirectStandardInput = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = @"/c " + command;

            //起動
            process.Start();

            // 標準入力を取得
            //StreamWriter streamWriter = process.StandardInput;

            // 出力
            showCommand(command);

            //streamWriter.WriteLine(comand);

            //非同期で出力とエラーの読み取りを開始
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.WaitForExit();
            process.Close();

            Console.ReadLine();
        }

        private void sendCommand(params string[] commands)
        {
            //Processオブジェクトを作成
            Process process = new Process();

            //出力とエラーをストリームに書き込むようにする
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            //OutputDataReceivedとErrorDataReceivedイベントハンドラを追加
            process.OutputDataReceived += OutputDataReceived;
            process.ErrorDataReceived += ErrorDataReceived;

            process.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.Arguments = @"/c ";

            //起動
            process.Start();

            // 標準入力を取得
            StreamWriter streamWriter = process.StandardInput;
            foreach (string command in commands)
            {
                // 出力
                showCommand(command);

                streamWriter.WriteLine(command);
            }

            //非同期で出力とエラーの読み取りを開始
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.WaitForExit();
            process.Close();

            Console.ReadLine();
        }

        private void showCommand(string command)
        {
            // 起動時の接続確認は表示しない
            if (currentCommand != Command.PREDEVICES)
            {
                if (RichTextBoxResult.Text.Length == 0)
                {
                    // 最初のコマンドは先頭で改行しない
                    RichTextBoxResult.AppendText(command + Environment.NewLine);
                }
                else
                {
                    // 2回目以降のコマンドは先頭で改行して前のコマンドとの間を1行開けて見やすくする
                    RichTextBoxResult.AppendText(Environment.NewLine + command + Environment.NewLine);
                }
            }
        }

        //OutputDataReceivedイベントハンドラ
        //行が出力されるたびに呼び出される
        void OutputDataReceived(object sender,
            DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                // インストール・再インストール時の進捗は表示しない
                if (e.Data.IndexOf("%") < 0)
                {
                    Action action = () =>
                    {
                        // デバイスをコンボボックスに追加する
                        if (currentCommand == Command.DEVICES || currentCommand == Command.PREDEVICES)
                        {
                            int index = e.Data.IndexOf("\tdevice");
                            if (index > 0)
                            {
                                ComboBoxDevices.Items.Add(e.Data.Substring(0, index));
                                ComboBoxDevices.SelectedIndex = 0;
                            }
                        }

                        // 起動時の接続確認は表示しない
                        if (currentCommand != Command.PREDEVICES)
                        {
                            //リッチテキストボックスにフォーカスを移動
                            RichTextBoxResult.Focus();
                            //出力された文字列を表示する
                            RichTextBoxResult.AppendText(e.Data + Environment.NewLine);
                        }
                    };
                    BeginInvoke(action);
                }
            }
        }

        //ErrorDataReceivedイベントハンドラ
        void ErrorDataReceived(object sender,
            DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                Action action = () =>
                {
                    //リッチテキストボックスにフォーカスを移動
                    RichTextBoxResult.Focus();
                    //エラー出力された文字列を表示する
                    RichTextBoxResult.AppendText(e.Data + Environment.NewLine);
                };
                BeginInvoke(action);
            }
        }

        private void RichTextBoxApk_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグドロップしたファイルのパスを表示する
            RichTextBoxApk.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void RichTextBoxApk_DragEnter(object sender, DragEventArgs e)
        {
            //ファイルがドラッグされている場合、カーソルを変更する
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void showResult(string result)
        {
            // コマンドの実行結果を表示する
            RichTextBoxResult.Text = result;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            string ip = RichTextBoxIp.Text;
            if (ip != "")
            {
                currentCommand = Command.CONNECT;
                sendCommandNoWindow("adb connect " + ip);
            }
            else
            {
                MessageBox.Show("IPアドレスを入力して下さい", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            string ip = RichTextBoxIp.Text;
            if (CheckBoxAllDevices.Checked)
            {
                currentCommand = Command.DISCONNECT;
                sendCommandNoWindow("adb disconnect");
            }
            else if (ip != "")
            {
                currentCommand = Command.DISCONNECT;
                sendCommandNoWindow("adb disconnect " + ip);
            }
            else
            {
                MessageBox.Show("IPアドレスを入力して下さい", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            string apkFilePath = RichTextBoxApk.Text;
            if (apkFilePath != "")
            {
                currentCommand = Command.INSTALL;
                if (CheckBoxAllDevices.Checked)
                {
                    foreach (string device in ComboBoxDevices.Items)
                    {
                        sendCommandNoWindow("adb -s " + device + " install " + apkFilePath);
                    }
                }
                else if (ComboBoxDevices.SelectedIndex != -1)
                {
                    sendCommandNoWindow("adb -s " + ComboBoxDevices.SelectedItem + " install " + apkFilePath);
                }
                else
                {
                    sendCommandNoWindow("adb install " + apkFilePath);
                }
            }
            else
            {
                MessageBox.Show("APKのファイルパスを入力して下さい\nドラッグアンドドロップもできます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonReInstall_Click(object sender, EventArgs e)
        {
            string apkFilePath = RichTextBoxApk.Text;
            if (apkFilePath != "")
            {
                currentCommand = Command.REINSTALL;
                if (CheckBoxAllDevices.Checked)
                {
                    foreach (string device in ComboBoxDevices.Items)
                    {
                        sendCommandNoWindow("adb -s " + device + " install -r " + apkFilePath);
                    }
                }
                else if (ComboBoxDevices.SelectedIndex != -1)
                {
                    sendCommandNoWindow("adb -s " + ComboBoxDevices.SelectedItem + " install -r " + apkFilePath);
                }
                else
                {
                    sendCommandNoWindow("adb install -r " + apkFilePath);
                }
            }
            else
            {
                MessageBox.Show("APKのファイルパスを入力して下さい\nドラッグアンドドロップも可能です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUninstall_Click(object sender, EventArgs e)
        {
            string packageName = RichTextBoxPackageName.Text;
            if (packageName != "")
            {
                currentCommand = Command.UNINSTALL;
                if (ComboBoxDevices.SelectedIndex != -1)
                {
                    sendCommandNoWindow("adb -s " + ComboBoxDevices.SelectedItem + " uninstall " + packageName);
                }
                else
                {
                    sendCommandNoWindow("adb uninstall " + packageName);
                }
            }
            else
            {
                MessageBox.Show("パッケージネームを指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDevices_Click(object sender, EventArgs e)
        {
            currentCommand = Command.DEVICES;
            ComboBoxDevices.Items.Clear();
            sendCommandNoWindow("adb devices ");
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            currentCommand = Command.SHOW;
            sendCommand("adb Shell","run-as " + RichTextBoxPackageName.Text, "\nls -l");
        }

        private void ButtonLogcat_Click(object sender, EventArgs e)
        {
            currentCommand = Command.LOGCAT;
            if (CheckBoxAllDevices.Checked)
            {
                foreach (string device in ComboBoxDevices.Items)
                {
                    sendCommand("adb -s " + device + " logcat -v time");
                }
            }
            else if (ComboBoxDevices.SelectedIndex != -1)
            {
                sendCommand("adb -s " + ComboBoxDevices.SelectedItem + " logcat -v time");
            }
            else
            {
                sendCommand("adb logcat -v time");
            }
        }

        private void ButtonDataClear_Click(object sender, EventArgs e)
        {
            string packageName = RichTextBoxPackageName.Text;
            if (packageName != "")
            {
                currentCommand = Command.DATACLEAR;
                if (CheckBoxAllDevices.Checked)
                {
                    foreach (string device in ComboBoxDevices.Items)
                    {
                        sendCommandNoWindow("adb -s " + device + " shell pm clear " + packageName);
                    }
                }
                else if (ComboBoxDevices.SelectedIndex != -1)
                {
                    sendCommandNoWindow("adb -s " + ComboBoxDevices.SelectedItem + " shell pm clear " + packageName);
                }
                else
                {
                    sendCommandNoWindow("adb shell pm clear " + packageName);
                }
            }
            else
            {
                MessageBox.Show("パッケージネームを指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
