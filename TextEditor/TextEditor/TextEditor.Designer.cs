namespace TextEditor
{
    partial class TextEditor
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
            lblTitle = new Label();
            rtxtInput = new RichTextBox();
            btnSaveText = new Button();
            btnChatGPT = new Button();
            btnOpen = new Button();
            btnNewText = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(214, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Text editor basic af";
            // 
            // rtxtInput
            // 
            rtxtInput.BackColor = Color.White;
            rtxtInput.ForeColor = SystemColors.ActiveCaptionText;
            rtxtInput.Location = new Point(12, 50);
            rtxtInput.Name = "rtxtInput";
            rtxtInput.Size = new Size(756, 353);
            rtxtInput.TabIndex = 1;
            rtxtInput.Text = "";
            // 
            // btnSaveText
            // 
            btnSaveText.Location = new Point(649, 415);
            btnSaveText.Name = "btnSaveText";
            btnSaveText.Size = new Size(119, 23);
            btnSaveText.TabIndex = 2;
            btnSaveText.Text = "Save";
            btnSaveText.UseVisualStyleBackColor = true;
            btnSaveText.Click += btnSaveText_Click;
            // 
            // btnChatGPT
            // 
            btnChatGPT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnChatGPT.Location = new Point(326, 415);
            btnChatGPT.Name = "btnChatGPT";
            btnChatGPT.Size = new Size(273, 23);
            btnChatGPT.TabIndex = 2;
            btnChatGPT.Text = "Generate HTML code";
            btnChatGPT.UseVisualStyleBackColor = true;
            btnChatGPT.Click += btnChatGPT_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(137, 415);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(119, 23);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnNewText
            // 
            btnNewText.Location = new Point(12, 415);
            btnNewText.Name = "btnNewText";
            btnNewText.Size = new Size(119, 23);
            btnNewText.TabIndex = 2;
            btnNewText.Text = "New";
            btnNewText.UseVisualStyleBackColor = true;
            btnNewText.Click += btnNewText_Click;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewText);
            Controls.Add(btnOpen);
            Controls.Add(btnChatGPT);
            Controls.Add(btnSaveText);
            Controls.Add(rtxtInput);
            Controls.Add(lblTitle);
            Name = "TextEditor";
            Text = "Text editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RichTextBox rtxtInput;
        private Button btnSaveText;
        private Button btnChatGPT;
        private Button btnOpen;
        private Button btnNewText;
    }
}