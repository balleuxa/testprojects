namespace BasicLeaker
{
    partial class Form1
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
            btnGetImg = new Button();
            txtWebsite = new TextBox();
            lblResult = new Label();
            btnChooseFolder = new Button();
            lblTitle = new Label();
            lblFolderPath = new Label();
            SuspendLayout();
            // 
            // btnGetImg
            // 
            btnGetImg.Enabled = false;
            btnGetImg.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetImg.Location = new Point(115, 156);
            btnGetImg.Name = "btnGetImg";
            btnGetImg.Size = new Size(244, 35);
            btnGetImg.TabIndex = 0;
            btnGetImg.Text = "Get Images";
            btnGetImg.UseVisualStyleBackColor = true;
            btnGetImg.Click += btnGetImg_ClickAsync;
            // 
            // txtWebsite
            // 
            txtWebsite.Enabled = false;
            txtWebsite.ForeColor = SystemColors.ControlDark;
            txtWebsite.Location = new Point(51, 127);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(371, 23);
            txtWebsite.TabIndex = 1;
            txtWebsite.Text = "https://www.exemple.com";
            txtWebsite.Click += txtWebsite_Click;
            txtWebsite.TextChanged += txtWebsite_TextChanged;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(115, 204);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(244, 23);
            lblResult.TabIndex = 3;
            lblResult.Text = "result";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Visible = false;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(157, 48);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(163, 34);
            btnChooseFolder.TabIndex = 4;
            btnChooseFolder.Text = "Choose export folder path";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(464, 36);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Enter a website on this format \"https://www.website.com\"";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFolderPath
            // 
            lblFolderPath.Location = new Point(51, 85);
            lblFolderPath.Name = "lblFolderPath";
            lblFolderPath.Size = new Size(371, 39);
            lblFolderPath.TabIndex = 5;
            lblFolderPath.Text = "Location:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 253);
            Controls.Add(lblFolderPath);
            Controls.Add(btnChooseFolder);
            Controls.Add(lblResult);
            Controls.Add(lblTitle);
            Controls.Add(txtWebsite);
            Controls.Add(btnGetImg);
            Name = "Form1";
            Text = "Image downloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetImg;
        private TextBox txtWebsite;
        private Label lblResult;
        private Button btnChooseFolder;
        private Label lblTitle;
        private Label lblFolderPath;
    }
}