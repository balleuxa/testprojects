namespace BirthdaySelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dtpBirthday = new DateTimePicker();
            lblInstructions = new Label();
            lblTitle = new Label();
            lblAge = new Label();
            lblNextBday = new Label();
            btnCalcAge = new Button();
            btnCalcNextBday = new Button();
            lblHBirthdayMsg = new Label();
            pcBirthdayCake = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcBirthdayCake).BeginInit();
            SuspendLayout();
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(89, 91);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(223, 23);
            dtpBirthday.TabIndex = 0;
            dtpBirthday.ValueChanged += dtpBirthday_ValueChanged;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructions.Location = new Point(143, 59);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(529, 15);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Please enter your date of birth to know your age and how many days is left until your next birthday.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(220, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 50);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Birthday calculator";
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(89, 184);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(583, 38);
            lblAge.TabIndex = 3;
            lblAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNextBday
            // 
            lblNextBday.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNextBday.Location = new Point(89, 236);
            lblNextBday.Name = "lblNextBday";
            lblNextBday.Size = new Size(583, 45);
            lblNextBday.TabIndex = 4;
            lblNextBday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalcAge
            // 
            btnCalcAge.Location = new Point(344, 91);
            btnCalcAge.Name = "btnCalcAge";
            btnCalcAge.Size = new Size(153, 23);
            btnCalcAge.TabIndex = 5;
            btnCalcAge.Text = "Calculate my age";
            btnCalcAge.UseVisualStyleBackColor = true;
            btnCalcAge.Click += btnCalcAge_Click;
            // 
            // btnCalcNextBday
            // 
            btnCalcNextBday.Location = new Point(519, 91);
            btnCalcNextBday.Name = "btnCalcNextBday";
            btnCalcNextBday.Size = new Size(153, 23);
            btnCalcNextBday.TabIndex = 5;
            btnCalcNextBday.Text = "Caculate next birthday";
            btnCalcNextBday.UseVisualStyleBackColor = true;
            btnCalcNextBday.Click += btnCalcNextBday_Click;
            // 
            // lblHBirthdayMsg
            // 
            lblHBirthdayMsg.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblHBirthdayMsg.ForeColor = Color.Tomato;
            lblHBirthdayMsg.Location = new Point(12, 126);
            lblHBirthdayMsg.Name = "lblHBirthdayMsg";
            lblHBirthdayMsg.Size = new Size(776, 43);
            lblHBirthdayMsg.TabIndex = 6;
            lblHBirthdayMsg.TextAlign = ContentAlignment.TopCenter;
            // 
            // pcBirthdayCake
            // 
            pcBirthdayCake.Image = (Image)resources.GetObject("pcBirthdayCake.Image");
            pcBirthdayCake.Location = new Point(12, 172);
            pcBirthdayCake.Name = "pcBirthdayCake";
            pcBirthdayCake.Size = new Size(776, 266);
            pcBirthdayCake.TabIndex = 7;
            pcBirthdayCake.TabStop = false;
            pcBirthdayCake.Visible = false;
            pcBirthdayCake.WaitOnLoad = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pcBirthdayCake);
            Controls.Add(lblHBirthdayMsg);
            Controls.Add(btnCalcNextBday);
            Controls.Add(btnCalcAge);
            Controls.Add(lblNextBday);
            Controls.Add(lblAge);
            Controls.Add(lblTitle);
            Controls.Add(lblInstructions);
            Controls.Add(dtpBirthday);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pcBirthdayCake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBirthday;
        private Label lblInstructions;
        private Label lblTitle;
        private Label lblAge;
        private Label lblNextBday;
        private Button btnCalcAge;
        private Button btnCalcNextBday;
        private Label lblHBirthdayMsg;
        private PictureBox pcBirthdayCake;
    }
}