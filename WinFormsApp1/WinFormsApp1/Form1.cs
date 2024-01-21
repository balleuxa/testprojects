using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            InitializeTypingTimer();
            InitializeInstructionTimer();
            InitializeEndTimer();
            originalGenerateBtnSize = btnGenerateRnd.Size;
            originalGenerateBtnPtn = btnGenerateRnd.Location;
            originalLogoutBtnSize = btnExit.Size;
            originalLogoutBtnPtn = btnExit.Location;
        }

        Random rnd = new Random();
        private Timer typingTimer;
        private Timer instructionTimer;
        private Timer endTimer;

        private Size originalGenerateBtnSize;
        private Point originalGenerateBtnPtn;
        private Size originalLogoutBtnSize;
        private Point originalLogoutBtnPtn;

        private int maxNumber = 1;
        private int randomNumber;
        private int userGuess;

        private void InitializeTypingTimer()
        {
            typingTimer = new Timer();
            typingTimer.Interval = 3000;
            typingTimer.Tick += typingTimer_Tick;
        }
        private void InitializeInstructionTimer()
        {
            instructionTimer = new Timer();
            instructionTimer.Interval = 1500;
            instructionTimer.Tick += instuctionsTimer_Tick;
        }
        private void InitializeEndTimer()
        {
            endTimer = new Timer();
            endTimer.Interval = 2000;
            endTimer.Tick += endTimer_Tick;
        }

        private void endTimer_Tick(object? sender, EventArgs e)
        {
            endTimer.Stop();
            if (txtInstructions.Text.Contains("You got it!"))
            {
                txtUserInterface.Text = "Click on \"Generate a number\" to play again.";
            }
        }

        private void typingTimer_Tick(object sender, EventArgs e)
        {
            typingTimer.Stop();
            if (int.TryParse(txtUserInput.Text, out _) && !txtUserInterface.Text.Contains("Click on \"Generate a number\" to play again."))
            {
                txtUserInterface.Text = "Press enter to validate your answer!";
            }
        }

        private void instuctionsTimer_Tick(object sender, EventArgs e)
        {
            instructionTimer.Stop();
            if (txtUserInterface.Text.Contains("You've chosen a number between"))
            {
                txtInstructions.Text = "Please click on \"Generate a number\"";
            }

        }
        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            typingTimer.Stop();
            typingTimer.Start();
        }

        private void txtUserInterface_TextChanged(object sender, EventArgs e)
        {
            instructionTimer.Stop();
            instructionTimer.Start();
        }

        private void txtInstructions_TextChanged(object sender, EventArgs e)
        {
            endTimer.Stop();
            endTimer.Start();
        }


        private string giveUserHint(int number)
        {
            if (number > randomNumber)
            {
                return "Wrong the number is lower";
            }
            else if (number < randomNumber)
            {
                return "Wrong the number is higher";
            }
            txtUserInput.Enabled = false;
            txtUserInput.BackColor = Color.Gray;
            return $"You got it! The number was {randomNumber}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnGenerateRnd_Click(object sender, EventArgs e)
        {
            if (maxNumber > 1)
            {
                randomNumber = rnd.Next(1, maxNumber + 1);
                txtUserInterface.Text = "Number is generated, goodluck!";
                txtUserInput.Enabled = true;
                txtUserInput.BackColor = Color.White;
                txtInstructions.Text = "Try to guess it";
            }
            else
            {
                txtInstructions.Text = "Choose a max value first!";
            }
        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserInput.Text != null && int.TryParse(txtUserInput.Text, out int value) && maxNumber == 1)
                {
                    maxNumber = value;
                    txtUserInput.Text = "";
                    txtUserInterface.Text = $"You've chosen a number between 1 and {maxNumber}.";
                    txtUserInput.Enabled = false;
                    txtUserInput.BackColor = Color.Gray;
                }
                else if (randomNumber != 0 && txtUserInterface.Text.Contains("Number is generated, goodluck!") || txtUserInterface.Text.Contains("Press enter to validate"))
                {
                    if (int.TryParse(txtUserInput.Text, out int number))
                    {
                        userGuess = number;
                        txtUserInput.Text = "";
                        txtInstructions.Text = giveUserHint(userGuess);
                    }
                }
                else if (txtUserInterface.Text.Contains("max value"))
                {
                    txtInstructions.Text = "Enter a valid number!";
                    txtUserInput.Text = "";
                }
            }
        }

        private void btnGenerateRnd_MouseEnter(object sender, EventArgs e)
        {
            btnGenerateRnd.Size = new Size(originalGenerateBtnSize.Width - 3, originalGenerateBtnSize.Height - 1);
            btnGenerateRnd.Location = new Point(originalGenerateBtnPtn.X + 3, originalGenerateBtnPtn.Y - 1);
            btnGenerateRnd.FlatAppearance.BorderColor = Color.PaleGreen;
        }

        private void btnGenerateRnd_MouseLeave(object sender, EventArgs e)
        {
            btnGenerateRnd.Size = originalGenerateBtnSize;
            btnGenerateRnd.Location = originalGenerateBtnPtn;
            btnGenerateRnd.FlatAppearance.BorderColor = Color.WhiteSmoke;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Size = new Size(originalLogoutBtnSize.Width - 3, originalLogoutBtnSize.Height - 1);
            btnExit.Location = new Point(originalLogoutBtnPtn.X + 3, originalLogoutBtnPtn.Y - 1);
            btnExit.FlatAppearance.BorderColor = Color.DarkSalmon;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Size = originalLogoutBtnSize;
            btnExit.Location = originalLogoutBtnPtn;
            btnExit.FlatAppearance.BorderColor = Color.WhiteSmoke;

        }


    }
}