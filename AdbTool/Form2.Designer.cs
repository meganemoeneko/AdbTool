namespace AdbTool
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RichTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxFilter = new System.Windows.Forms.RichTextBox();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.LabelLevel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RichTextBoxFilter, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RichTextBoxResult
            // 
            this.RichTextBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxResult.BackColor = System.Drawing.SystemColors.Info;
            this.RichTextBoxResult.Location = new System.Drawing.Point(12, 141);
            this.RichTextBoxResult.Name = "RichTextBoxResult";
            this.RichTextBoxResult.ReadOnly = true;
            this.RichTextBoxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RichTextBoxResult.Size = new System.Drawing.Size(560, 174);
            this.RichTextBoxResult.TabIndex = 4;
            this.RichTextBoxResult.Text = "";
            // 
            // RichTextBoxFilter
            // 
            this.RichTextBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxFilter.Location = new System.Drawing.Point(41, 3);
            this.RichTextBoxFilter.Multiline = false;
            this.RichTextBoxFilter.Name = "RichTextBoxFilter";
            this.RichTextBoxFilter.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.RichTextBoxFilter.Size = new System.Drawing.Size(516, 23);
            this.RichTextBoxFilter.TabIndex = 2;
            this.RichTextBoxFilter.Text = "";
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelFilter.Location = new System.Drawing.Point(3, 0);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(32, 29);
            this.LabelFilter.TabIndex = 15;
            this.LabelFilter.Text = "Filter";
            this.LabelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelLevel.Location = new System.Drawing.Point(3, 29);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(32, 94);
            this.LabelLevel.TabIndex = 16;
            this.LabelLevel.Text = "Level";
            this.LabelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 327);
            this.Controls.Add(this.RichTextBoxResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox RichTextBoxResult;
        private System.Windows.Forms.RichTextBox RichTextBoxFilter;
        private System.Windows.Forms.Label LabelFilter;
        private System.Windows.Forms.Label LabelLevel;
    }
}