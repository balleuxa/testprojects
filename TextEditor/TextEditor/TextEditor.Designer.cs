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
            btnGenerateHtml = new Button();
            btnOpen = new Button();
            btnNewText = new Button();
            tabsControl = new TabControl();
            tabInput = new TabPage();
            tabPreview = new TabPage();
            webBrowser1 = new WebBrowser();
            btnSaveText = new Button();
            bthPreview = new Button();
            btnPrint = new Button();
            tabsControl.SuspendLayout();
            tabInput.SuspendLayout();
            tabPreview.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(27, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Text editor basic af";
            // 
            // rtxtInput
            // 
            rtxtInput.BackColor = Color.White;
            rtxtInput.ForeColor = SystemColors.ActiveCaptionText;
            rtxtInput.Location = new Point(-4, -3);
            rtxtInput.Name = "rtxtInput";
            rtxtInput.Size = new Size(791, 620);
            rtxtInput.TabIndex = 1;
            rtxtInput.Text = "";
            rtxtInput.TextChanged += rtxtInput_TextChanged;
            // 
            // btnGenerateHtml
            // 
            btnGenerateHtml.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateHtml.Location = new Point(420, 22);
            btnGenerateHtml.Name = "btnGenerateHtml";
            btnGenerateHtml.Size = new Size(192, 23);
            btnGenerateHtml.TabIndex = 2;
            btnGenerateHtml.Text = "Generate HTML code";
            btnGenerateHtml.UseVisualStyleBackColor = true;
            btnGenerateHtml.Click += btnGenerateHtml_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(218, 697);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(189, 23);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnNewText
            // 
            btnNewText.Location = new Point(23, 697);
            btnNewText.Name = "btnNewText";
            btnNewText.Size = new Size(189, 23);
            btnNewText.TabIndex = 2;
            btnNewText.Text = "New";
            btnNewText.UseVisualStyleBackColor = true;
            btnNewText.Click += btnNewText_Click;
            // 
            // tabsControl
            // 
            tabsControl.Controls.Add(tabInput);
            tabsControl.Controls.Add(tabPreview);
            tabsControl.Location = new Point(23, 50);
            tabsControl.Name = "tabsControl";
            tabsControl.SelectedIndex = 0;
            tabsControl.Size = new Size(787, 641);
            tabsControl.TabIndex = 3;
            // 
            // tabInput
            // 
            tabInput.Controls.Add(rtxtInput);
            tabInput.Location = new Point(4, 24);
            tabInput.Name = "tabInput";
            tabInput.Padding = new Padding(3);
            tabInput.Size = new Size(779, 613);
            tabInput.TabIndex = 0;
            tabInput.Text = "Text input";
            tabInput.UseVisualStyleBackColor = true;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(webBrowser1);
            tabPreview.Location = new Point(4, 24);
            tabPreview.Name = "tabPreview";
            tabPreview.Padding = new Padding(3);
            tabPreview.Size = new Size(779, 613);
            tabPreview.TabIndex = 1;
            tabPreview.Text = "HTML preview";
            tabPreview.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            webBrowser1.Location = new Point(-4, 0);
            webBrowser1.Margin = new Padding(5, 3, 5, 3);
            webBrowser1.MinimumSize = new Size(27, 27);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new Size(787, 617);
            webBrowser1.TabIndex = 27;
            // 
            // btnSaveText
            // 
            btnSaveText.Location = new Point(420, 697);
            btnSaveText.Name = "btnSaveText";
            btnSaveText.Size = new Size(189, 23);
            btnSaveText.TabIndex = 2;
            btnSaveText.Text = "Save file";
            btnSaveText.UseVisualStyleBackColor = true;
            btnSaveText.Click += btnSaveText_Click;
            // 
            // bthPreview
            // 
            bthPreview.Location = new Point(629, 24);
            bthPreview.Name = "bthPreview";
            bthPreview.Size = new Size(181, 23);
            bthPreview.TabIndex = 2;
            bthPreview.Text = "Create preview";
            bthPreview.UseVisualStyleBackColor = true;
            bthPreview.Click += bthPreview_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(629, 697);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(181, 23);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print HTML view";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 732);
            Controls.Add(tabsControl);
            Controls.Add(btnSaveText);
            Controls.Add(btnGenerateHtml);
            Controls.Add(btnNewText);
            Controls.Add(btnOpen);
            Controls.Add(bthPreview);
            Controls.Add(btnPrint);
            Controls.Add(lblTitle);
            Name = "TextEditor";
            Text = "Text editor";
            tabsControl.ResumeLayout(false);
            tabInput.ResumeLayout(false);
            tabPreview.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RichTextBox rtxtInput;
        private Button btnGenerateHtml;
        private Button btnOpen;
        private Button btnNewText;
        private TabControl tabsControl;
        private TabPage tabInput;
        private TabPage tabPreview;
        private WebBrowser webBrowser1;
        private Button btnSaveText;
        private Button bthPreview;
        private Button btnPrint;
    }
}