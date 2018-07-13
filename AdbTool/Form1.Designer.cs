namespace AdbTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RichTextBoxIp = new System.Windows.Forms.RichTextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RichTextBoxSharedPreferenceKey = new System.Windows.Forms.RichTextBox();
            this.CheckBoxAllDevices = new System.Windows.Forms.CheckBox();
            this.LabelDevices = new System.Windows.Forms.Label();
            this.RichTextBoxPackageName = new System.Windows.Forms.RichTextBox();
            this.LabelPackageName = new System.Windows.Forms.Label();
            this.LabelApk = new System.Windows.Forms.Label();
            this.RichTextBoxApk = new System.Windows.Forms.RichTextBox();
            this.LabelIp = new System.Windows.Forms.Label();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.ButtonReInstall = new System.Windows.Forms.Button();
            this.ButtonUninstall = new System.Windows.Forms.Button();
            this.ButtonDevices = new System.Windows.Forms.Button();
            this.ComboBoxDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonShow = new System.Windows.Forms.Button();
            this.ButtonLogcat = new System.Windows.Forms.Button();
            this.RichTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.ButtonDataClear = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBoxIp
            // 
            this.RichTextBoxIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxIp.Location = new System.Drawing.Point(123, 32);
            this.RichTextBoxIp.Multiline = false;
            this.RichTextBoxIp.Name = "RichTextBoxIp";
            this.RichTextBoxIp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RichTextBoxIp.Size = new System.Drawing.Size(121, 23);
            this.RichTextBoxIp.TabIndex = 1;
            this.RichTextBoxIp.Text = "";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(250, 32);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 2;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(331, 32);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonDisconnect.TabIndex = 4;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 6;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Controls.Add(this.ButtonDataClear, 4, 3);
            this.TableLayoutPanel1.Controls.Add(this.RichTextBoxSharedPreferenceKey, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.CheckBoxAllDevices, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.LabelDevices, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.RichTextBoxPackageName, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.LabelPackageName, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.RichTextBoxIp, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.ButtonDisconnect, 3, 1);
            this.TableLayoutPanel1.Controls.Add(this.ButtonConnect, 2, 1);
            this.TableLayoutPanel1.Controls.Add(this.LabelApk, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.RichTextBoxApk, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.LabelIp, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.ButtonInstall, 3, 2);
            this.TableLayoutPanel1.Controls.Add(this.ButtonReInstall, 4, 2);
            this.TableLayoutPanel1.Controls.Add(this.ButtonUninstall, 3, 3);
            this.TableLayoutPanel1.Controls.Add(this.ButtonDevices, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this.ComboBoxDevices, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.ButtonShow, 3, 4);
            this.TableLayoutPanel1.Controls.Add(this.ButtonLogcat, 4, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(14, 12);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 5;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(558, 145);
            this.TableLayoutPanel1.TabIndex = 6;
            // 
            // RichTextBoxSharedPreferenceKey
            // 
            this.TableLayoutPanel1.SetColumnSpan(this.RichTextBoxSharedPreferenceKey, 2);
            this.RichTextBoxSharedPreferenceKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxSharedPreferenceKey.Location = new System.Drawing.Point(123, 119);
            this.RichTextBoxSharedPreferenceKey.Multiline = false;
            this.RichTextBoxSharedPreferenceKey.Name = "RichTextBoxSharedPreferenceKey";
            this.RichTextBoxSharedPreferenceKey.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RichTextBoxSharedPreferenceKey.Size = new System.Drawing.Size(202, 23);
            this.RichTextBoxSharedPreferenceKey.TabIndex = 18;
            this.RichTextBoxSharedPreferenceKey.Text = "";
            // 
            // CheckBoxAllDevices
            // 
            this.CheckBoxAllDevices.AutoSize = true;
            this.CheckBoxAllDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxAllDevices.Location = new System.Drawing.Point(331, 3);
            this.CheckBoxAllDevices.Name = "CheckBoxAllDevices";
            this.CheckBoxAllDevices.Size = new System.Drawing.Size(79, 23);
            this.CheckBoxAllDevices.TabIndex = 16;
            this.CheckBoxAllDevices.Text = "AllDevices";
            this.CheckBoxAllDevices.UseVisualStyleBackColor = true;
            // 
            // LabelDevices
            // 
            this.LabelDevices.AutoSize = true;
            this.LabelDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelDevices.Location = new System.Drawing.Point(3, 0);
            this.LabelDevices.Name = "LabelDevices";
            this.LabelDevices.Size = new System.Drawing.Size(114, 29);
            this.LabelDevices.TabIndex = 14;
            this.LabelDevices.Text = "Devices";
            this.LabelDevices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RichTextBoxPackageName
            // 
            this.TableLayoutPanel1.SetColumnSpan(this.RichTextBoxPackageName, 2);
            this.RichTextBoxPackageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxPackageName.Location = new System.Drawing.Point(123, 90);
            this.RichTextBoxPackageName.Multiline = false;
            this.RichTextBoxPackageName.Name = "RichTextBoxPackageName";
            this.RichTextBoxPackageName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RichTextBoxPackageName.Size = new System.Drawing.Size(202, 23);
            this.RichTextBoxPackageName.TabIndex = 12;
            this.RichTextBoxPackageName.Text = "";
            // 
            // LabelPackageName
            // 
            this.LabelPackageName.AutoSize = true;
            this.LabelPackageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPackageName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelPackageName.Location = new System.Drawing.Point(3, 87);
            this.LabelPackageName.Name = "LabelPackageName";
            this.LabelPackageName.Size = new System.Drawing.Size(114, 29);
            this.LabelPackageName.TabIndex = 11;
            this.LabelPackageName.Text = "PackageName";
            this.LabelPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelApk
            // 
            this.LabelApk.AutoSize = true;
            this.LabelApk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelApk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelApk.Location = new System.Drawing.Point(3, 58);
            this.LabelApk.Name = "LabelApk";
            this.LabelApk.Size = new System.Drawing.Size(114, 29);
            this.LabelApk.TabIndex = 5;
            this.LabelApk.Text = "APK";
            this.LabelApk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RichTextBoxApk
            // 
            this.RichTextBoxApk.AllowDrop = true;
            this.TableLayoutPanel1.SetColumnSpan(this.RichTextBoxApk, 2);
            this.RichTextBoxApk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxApk.Location = new System.Drawing.Point(123, 61);
            this.RichTextBoxApk.Multiline = false;
            this.RichTextBoxApk.Name = "RichTextBoxApk";
            this.RichTextBoxApk.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RichTextBoxApk.Size = new System.Drawing.Size(202, 23);
            this.RichTextBoxApk.TabIndex = 7;
            this.RichTextBoxApk.Text = "";
            this.RichTextBoxApk.DragDrop += new System.Windows.Forms.DragEventHandler(this.RichTextBoxApk_DragDrop);
            this.RichTextBoxApk.DragEnter += new System.Windows.Forms.DragEventHandler(this.RichTextBoxApk_DragEnter);
            // 
            // LabelIp
            // 
            this.LabelIp.AutoSize = true;
            this.LabelIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelIp.Location = new System.Drawing.Point(3, 29);
            this.LabelIp.Name = "LabelIp";
            this.LabelIp.Size = new System.Drawing.Size(114, 29);
            this.LabelIp.TabIndex = 0;
            this.LabelIp.Text = "IP";
            this.LabelIp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.Location = new System.Drawing.Point(331, 61);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Size = new System.Drawing.Size(75, 23);
            this.ButtonInstall.TabIndex = 6;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.UseVisualStyleBackColor = true;
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // ButtonReInstall
            // 
            this.ButtonReInstall.Location = new System.Drawing.Point(416, 61);
            this.ButtonReInstall.Name = "ButtonReInstall";
            this.ButtonReInstall.Size = new System.Drawing.Size(75, 23);
            this.ButtonReInstall.TabIndex = 10;
            this.ButtonReInstall.Text = "ReInstall";
            this.ButtonReInstall.UseVisualStyleBackColor = true;
            this.ButtonReInstall.Click += new System.EventHandler(this.ButtonReInstall_Click);
            // 
            // ButtonUninstall
            // 
            this.ButtonUninstall.Location = new System.Drawing.Point(331, 90);
            this.ButtonUninstall.Name = "ButtonUninstall";
            this.ButtonUninstall.Size = new System.Drawing.Size(75, 23);
            this.ButtonUninstall.TabIndex = 8;
            this.ButtonUninstall.Text = "Uninstall";
            this.ButtonUninstall.UseVisualStyleBackColor = true;
            this.ButtonUninstall.Click += new System.EventHandler(this.ButtonUninstall_Click);
            // 
            // ButtonDevices
            // 
            this.ButtonDevices.Location = new System.Drawing.Point(250, 3);
            this.ButtonDevices.Name = "ButtonDevices";
            this.ButtonDevices.Size = new System.Drawing.Size(75, 23);
            this.ButtonDevices.TabIndex = 9;
            this.ButtonDevices.Text = "Devices";
            this.ButtonDevices.UseVisualStyleBackColor = true;
            this.ButtonDevices.Click += new System.EventHandler(this.ButtonDevices_Click);
            // 
            // ComboBoxDevices
            // 
            this.ComboBoxDevices.FormattingEnabled = true;
            this.ComboBoxDevices.Location = new System.Drawing.Point(123, 3);
            this.ComboBoxDevices.Name = "ComboBoxDevices";
            this.ComboBoxDevices.Size = new System.Drawing.Size(121, 20);
            this.ComboBoxDevices.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "SharedPreferenceKey";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonShow
            // 
            this.ButtonShow.Location = new System.Drawing.Point(331, 119);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(75, 23);
            this.ButtonShow.TabIndex = 19;
            this.ButtonShow.Text = "Show";
            this.ButtonShow.UseVisualStyleBackColor = true;
            this.ButtonShow.Visible = false;
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // ButtonLogcat
            // 
            this.ButtonLogcat.Location = new System.Drawing.Point(416, 3);
            this.ButtonLogcat.Name = "ButtonLogcat";
            this.ButtonLogcat.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogcat.TabIndex = 20;
            this.ButtonLogcat.Text = "Logcat";
            this.ButtonLogcat.UseVisualStyleBackColor = true;
            this.ButtonLogcat.Click += new System.EventHandler(this.ButtonLogcat_Click);
            // 
            // RichTextBoxResult
            // 
            this.RichTextBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxResult.BackColor = System.Drawing.SystemColors.Info;
            this.RichTextBoxResult.Location = new System.Drawing.Point(12, 187);
            this.RichTextBoxResult.Name = "RichTextBoxResult";
            this.RichTextBoxResult.ReadOnly = true;
            this.RichTextBoxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RichTextBoxResult.Size = new System.Drawing.Size(560, 162);
            this.RichTextBoxResult.TabIndex = 3;
            this.RichTextBoxResult.Text = "";
            // 
            // ButtonDataClear
            // 
            this.ButtonDataClear.Location = new System.Drawing.Point(416, 90);
            this.ButtonDataClear.Name = "ButtonDataClear";
            this.ButtonDataClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonDataClear.TabIndex = 21;
            this.ButtonDataClear.Text = "DataClear";
            this.ButtonDataClear.UseVisualStyleBackColor = true;
            this.ButtonDataClear.Click += new System.EventHandler(this.ButtonDataClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.RichTextBoxResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AdbTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBoxIp;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.RichTextBox RichTextBoxApk;
        private System.Windows.Forms.Label LabelApk;
        private System.Windows.Forms.Label LabelIp;
        private System.Windows.Forms.Button ButtonUninstall;
        private System.Windows.Forms.Button ButtonDevices;
        private System.Windows.Forms.Button ButtonReInstall;
        private System.Windows.Forms.Label LabelPackageName;
        private System.Windows.Forms.RichTextBox RichTextBoxPackageName;
        private System.Windows.Forms.ComboBox ComboBoxDevices;
        private System.Windows.Forms.Label LabelDevices;
        private System.Windows.Forms.CheckBox CheckBoxAllDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBoxSharedPreferenceKey;
        private System.Windows.Forms.Button ButtonShow;
        private System.Windows.Forms.Button ButtonLogcat;
        private System.Windows.Forms.RichTextBox RichTextBoxResult;
        private System.Windows.Forms.Button ButtonDataClear;
    }
}

