using System.Linq.Expressions;

namespace BirthdaySelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCurrentDate();
        }
        private DateTime dtToday;
        private DateTime dtUserBirth;
        private int userAge;
        private bool isUserBirthday;

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            lblAge.Text = "";
            lblNextBday.Text = "";
            pcBirthdayCake.Visible = false;
            lblHBirthdayMsg.Text = "";
            

            if (dtpBirthday.Value <= dtToday)
            {
                dtUserBirth = dtpBirthday.Value;
            }
            else
            {
                MessageBox.Show("If you see this message, please do not contact us cuz we have no clue how to solve this issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcAge_Click(object sender, EventArgs e)
        {
            if (dtUserBirth == dtpBirthday.Value)
            {
                TimeSpan difference = dtToday - dtUserBirth;
                userAge = (int)(difference.Days / 365.25);
                lblAge.Text = $"You are {userAge} years old";
                btnCalcAge.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter your birthday first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalcNextBday_Click(object sender, EventArgs e)
        {
            if (userAge > 0)
            {
                DateTime nextBday = dtUserBirth.AddYears(userAge + 1);
                TimeSpan daysUntilNextBday = nextBday - dtToday;
                CheckUserBirthday();
                if (isUserBirthday == true)
                {
                    DisplayBirthday();
                    ResetAllValues();
                    isUserBirthday = false;
                }
                else
                {
                    lblNextBday.Text = $"You're next birthday is in {daysUntilNextBday.Days} days.";
                    ResetAllValues();
                }
            }
            else
            {
                MessageBox.Show("Please caculate your age first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckUserBirthday()
        {
            if (dtToday.Day == dtUserBirth.Day)
            {
                isUserBirthday = true;
            }
        }
        private void DisplayBirthday()
        {
            pcBirthdayCake.Visible = true;
            lblHBirthdayMsg.Text = "Your next birthday is today, Happy birthday!";
        }

        private void InitializeCurrentDate()
        {
            dtToday = dtpBirthday.Value;
            dtpBirthday.MaxDate = dtToday;
        }

        private void ResetAllValues()
        {
            dtUserBirth = new DateTime();
            userAge = 0;
            btnCalcAge.Enabled = true;
        }
    }
}