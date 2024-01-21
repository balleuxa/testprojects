using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form
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
            btnGenerateRnd = new Button();
            btnExit = new Button();
            lbMessage = new Label();
            txtInstructions = new Label();
            txtUserInterface = new Label();
            txtUserInput = new TextBox();
            SuspendLayout();
            // 
            // btnGenerateRnd
            // 
            btnGenerateRnd.BackColor = Color.ForestGreen;
            btnGenerateRnd.FlatStyle = FlatStyle.Flat;
            btnGenerateRnd.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateRnd.ForeColor = Color.PapayaWhip;
            btnGenerateRnd.Location = new Point(43, 336);
            btnGenerateRnd.Name = "btnGenerateRnd";
            btnGenerateRnd.Size = new Size(428, 66);
            btnGenerateRnd.TabIndex = 0;
            btnGenerateRnd.Text = "Generate a number";
            btnGenerateRnd.UseVisualStyleBackColor = false;
            btnGenerateRnd.Click += btnGenerateRnd_Click;
            btnGenerateRnd.MouseEnter += btnGenerateRnd_MouseEnter;
            btnGenerateRnd.MouseLeave += btnGenerateRnd_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.PapayaWhip;
            btnExit.Location = new Point(542, 336);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 66);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnLogout_Click;
            btnExit.MouseEnter += btnLogout_MouseEnter;
            btnExit.MouseLeave += btnLogout_MouseLeave;
            // 
            // lbMessage
            // 
            lbMessage.Font = new Font("Algerian", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbMessage.ForeColor = Color.Chartreuse;
            lbMessage.Location = new Point(2, 9);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(737, 71);
            lbMessage.TabIndex = 3;
            lbMessage.Text = "Number Guesser";
            lbMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInstructions
            // 
            txtInstructions.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtInstructions.ForeColor = Color.Brown;
            txtInstructions.Location = new Point(2, 264);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(737, 35);
            txtInstructions.TabIndex = 5;
            txtInstructions.TextAlign = ContentAlignment.MiddleCenter;
            txtInstructions.TextChanged += txtInstructions_TextChanged;
            // 
            // txtUserInterface
            // 
            txtUserInterface.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserInterface.ForeColor = SystemColors.Control;
            txtUserInterface.Location = new Point(2, 173);
            txtUserInterface.Name = "txtUserInterface";
            txtUserInterface.Size = new Size(747, 30);
            txtUserInterface.TabIndex = 6;
            txtUserInterface.Text = "Please enter the max value of the number you want to guess.";
            txtUserInterface.TextAlign = ContentAlignment.MiddleCenter;
            txtUserInterface.TextChanged += txtUserInterface_TextChanged;
            // 
            // txtUserInput
            // 
            txtUserInput.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserInput.Location = new Point(296, 216);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(144, 33);
            txtUserInput.TabIndex = 7;
            txtUserInput.TextAlign = HorizontalAlignment.Center;
            txtUserInput.TextChanged += txtUserInput_TextChanged;
            txtUserInput.KeyDown += txtUserInput_KeyDown;
            // 
            // Form
            // 
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(741, 435);
            Controls.Add(txtUserInput);
            Controls.Add(txtUserInterface);
            Controls.Add(txtInstructions);
            Controls.Add(lbMessage);
            Controls.Add(btnExit);
            Controls.Add(btnGenerateRnd);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateRnd;
        private Button btnExit;
        private Label lbMessage;
        private Label txtInstructions;
        private Label txtUserInterface;
        private TextBox txtUserInput;
    }
}