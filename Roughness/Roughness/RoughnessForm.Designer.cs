namespace Roughness
{
    partial class RoughnessForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoughnessForm));
            this.FilePathButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FileContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.NoDataValueTextBox = new System.Windows.Forms.TextBox();
            this.RoughnessLabel = new System.Windows.Forms.Label();
            this.RoughnessTextBox = new System.Windows.Forms.TextBox();
            this.ConvertProgressBar = new System.Windows.Forms.ProgressBar();
            this.NoDataLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathButton
            // 
            this.FilePathButton.Location = new System.Drawing.Point(443, 31);
            this.FilePathButton.Name = "FilePathButton";
            this.FilePathButton.Size = new System.Drawing.Size(75, 23);
            this.FilePathButton.TabIndex = 0;
            this.FilePathButton.Text = "浏览...";
            this.FilePathButton.UseVisualStyleBackColor = true;
            this.FilePathButton.Click += new System.EventHandler(this.GetFilePath);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(30, 36);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(55, 13);
            this.FilePathLabel.TabIndex = 2;
            this.FilePathLabel.Text = "文件路径";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(91, 33);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(342, 20);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // FileContentRichTextBox
            // 
            this.FileContentRichTextBox.Location = new System.Drawing.Point(250, 78);
            this.FileContentRichTextBox.Name = "FileContentRichTextBox";
            this.FileContentRichTextBox.ReadOnly = true;
            this.FileContentRichTextBox.Size = new System.Drawing.Size(268, 133);
            this.FileContentRichTextBox.TabIndex = 3;
            this.FileContentRichTextBox.TabStop = false;
            this.FileContentRichTextBox.Text = "";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(44, 206);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(145, 37);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "开始转换！";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.GetR);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(322, 230);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(127, 13);
            this.ProgressLabel.TabIndex = 4;
            this.ProgressLabel.Text = "小老弟，你怎么回事？";
            this.ProgressLabel.Click += new System.EventHandler(this.ShowAuthor);
            // 
            // NoDataValueTextBox
            // 
            this.NoDataValueTextBox.Location = new System.Drawing.Point(139, 95);
            this.NoDataValueTextBox.Name = "NoDataValueTextBox";
            this.NoDataValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoDataValueTextBox.TabIndex = 2;
            // 
            // RoughnessLabel
            // 
            this.RoughnessLabel.AutoSize = true;
            this.RoughnessLabel.Location = new System.Drawing.Point(29, 140);
            this.RoughnessLabel.Name = "RoughnessLabel";
            this.RoughnessLabel.Size = new System.Drawing.Size(104, 13);
            this.RoughnessLabel.TabIndex = 4;
            this.RoughnessLabel.Text = "将非NoData值设为";
            // 
            // RoughnessTextBox
            // 
            this.RoughnessTextBox.Location = new System.Drawing.Point(139, 137);
            this.RoughnessTextBox.Name = "RoughnessTextBox";
            this.RoughnessTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoughnessTextBox.TabIndex = 3;
            // 
            // ConvertProgressBar
            // 
            this.ConvertProgressBar.Location = new System.Drawing.Point(250, 263);
            this.ConvertProgressBar.Name = "ConvertProgressBar";
            this.ConvertProgressBar.Size = new System.Drawing.Size(268, 23);
            this.ConvertProgressBar.Step = 1;
            this.ConvertProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ConvertProgressBar.TabIndex = 5;
            // 
            // NoDataLabel
            // 
            this.NoDataLabel.AutoSize = true;
            this.NoDataLabel.Location = new System.Drawing.Point(53, 98);
            this.NoDataLabel.Name = "NoDataLabel";
            this.NoDataLabel.Size = new System.Drawing.Size(56, 13);
            this.NoDataLabel.TabIndex = 4;
            this.NoDataLabel.Text = "NoData值";
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(44, 249);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(145, 37);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消操作";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.GetR);
            // 
            // RoughnessForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 306);
            this.Controls.Add(this.ConvertProgressBar);
            this.Controls.Add(this.RoughnessTextBox);
            this.Controls.Add(this.RoughnessLabel);
            this.Controls.Add(this.NoDataValueTextBox);
            this.Controls.Add(this.NoDataLabel);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FileContentRichTextBox);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FilePathButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "RoughnessForm";
            this.Text = "DEM转糙率工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitApp);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragToLocateFile);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PreDragDrop);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FilePathButton;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.RichTextBox FileContentRichTextBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.TextBox NoDataValueTextBox;
        private System.Windows.Forms.Label RoughnessLabel;
        private System.Windows.Forms.TextBox RoughnessTextBox;
        private System.Windows.Forms.ProgressBar ConvertProgressBar;
        private System.Windows.Forms.Label NoDataLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}

