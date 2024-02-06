namespace _8zip
{
    partial class Form8zip
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl8Zip = new Label();
            lblInstructions = new Label();
            panel1 = new Panel();
            lblPlaceHolder = new Label();
            lblProgress = new Label();
            progressBar1 = new ProgressBar();
            lblFileSize = new Label();
            lblFilePath = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl8Zip
            // 
            lbl8Zip.AutoSize = true;
            lbl8Zip.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl8Zip.Location = new Point(12, 9);
            lbl8Zip.Name = "lbl8Zip";
            lbl8Zip.Size = new Size(95, 50);
            lbl8Zip.TabIndex = 0;
            lbl8Zip.Text = "8zip";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoEllipsis = true;
            lblInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstructions.Location = new Point(101, 11);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(255, 48);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Drag and drop a folder down in the box below to see magic happens";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblPlaceHolder);
            panel1.Controls.Add(lblProgress);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(lblFileSize);
            panel1.Controls.Add(lblFilePath);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 164);
            panel1.TabIndex = 2;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += panel1_DragEnter;
            panel1.DragLeave += panel1_DragLeave;
            // 
            // lblPlaceHolder
            // 
            lblPlaceHolder.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlaceHolder.ForeColor = SystemColors.ActiveBorder;
            lblPlaceHolder.Location = new Point(-1, 56);
            lblPlaceHolder.Name = "lblPlaceHolder";
            lblPlaceHolder.Size = new Size(340, 58);
            lblPlaceHolder.TabIndex = 3;
            lblPlaceHolder.Text = "Drag here";
            lblPlaceHolder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProgress
            // 
            lblProgress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProgress.ForeColor = Color.OliveDrab;
            lblProgress.Location = new Point(30, 103);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(270, 21);
            lblProgress.TabIndex = 2;
            lblProgress.Text = "progress";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            lblProgress.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(30, 127);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(270, 23);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // lblFileSize
            // 
            lblFileSize.AutoSize = true;
            lblFileSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFileSize.ForeColor = Color.OliveDrab;
            lblFileSize.Location = new Point(30, 56);
            lblFileSize.Name = "lblFileSize";
            lblFileSize.Size = new Size(52, 21);
            lblFileSize.TabIndex = 1;
            lblFileSize.Text = "label2";
            lblFileSize.Visible = false;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilePath.ForeColor = Color.OliveDrab;
            lblFilePath.Location = new Point(30, 17);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(52, 21);
            lblFilePath.TabIndex = 0;
            lblFilePath.Text = "label1";
            lblFilePath.Visible = false;
            // 
            // Form8zip
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(368, 288);
            Controls.Add(panel1);
            Controls.Add(lblInstructions);
            Controls.Add(lbl8Zip);
            Name = "Form8zip";
            Text = "8zip";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl8Zip;
        private Label lblInstructions;
        private Panel panel1;
        private Label lblProgress;
        private Label lblFileSize;
        private Label lblFilePath;
        private ProgressBar progressBar1;
        private Label lblPlaceHolder;
    }
}