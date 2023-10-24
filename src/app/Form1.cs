using System;
using System.Drawing;
using System.Windows.Forms;

namespace app
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void iStudent_Load(object sender, EventArgs e)
        {

        }
        // add student btn start //
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string middleName = middleNameTextBox.Text;

            displayStudentOne.Text = firstName + " " + middleName + " " + lastName;
        }
        // add student btn end //

        // placeholder start //
        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text == "First Name")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.ForeColor = Color.Black;
            }
        }
        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text == "")
            {
                firstNameTextBox.Text = "First Name";
                firstNameTextBox.ForeColor = Color.LightGray;
            }
        }
        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Last Name")
            {
                lastNameTextBox.Text = "";
                lastNameTextBox.ForeColor = Color.Black;
            }
        }
        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "Last Name";
                lastNameTextBox.ForeColor = Color.LightGray;
            }
        }
        private void middleNameTextBox_Enter(object sender, EventArgs e)
        {
            if (middleNameTextBox.Text == "Middle Name (Optional)")
            {
                middleNameTextBox.Text = "";
                middleNameTextBox.ForeColor = Color.Black;
            }
        }
        private void middleNameTextBox_Leave(object sender, EventArgs e)
        {
            if (middleNameTextBox.Text == "")
            {
                middleNameTextBox.Text = "Middle Name (Optional)";
                middleNameTextBox.ForeColor = Color.LightGray;
            }
        }
        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = Color.LightGray;
            }
        }
        private void ageTextBox_Enter(object sender, EventArgs e)
        {
            if (ageTextBox.Text == "00")
            {
                ageTextBox.Text = "";
                ageTextBox.ForeColor = Color.Black;
            }
        }
        private void ageTextBox_Leave(object sender, EventArgs e)
        {
            if (ageTextBox.Text == "")
            {
                ageTextBox.Text = "00";
                ageTextBox.ForeColor = Color.LightGray;
            }
        }
        private void sexComboBox_Enter(object sender, EventArgs e)
        {
            if (sexComboBox.Text == "Sex")
            {
                sexComboBox.Text = "";
                sexComboBox.ForeColor = Color.Black;
            }
        }
        private void sexComboBox_Leave(object sender, EventArgs e)
        {
            if (sexComboBox.Text == "")
            {
                sexComboBox.Text = "Sex";
                sexComboBox.ForeColor = Color.LightGray;
            }
        }
        // placeholder end //
    }
}
