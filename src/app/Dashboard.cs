using HICLabActivityOne;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace app
{
    public partial class dashboard : Form
    {
        public static dashboard instance;
        public Label sideNavNameDisplayHolder;
        public TextBox fn;
        public TextBox ln;
        public Label sideNavDisplayEmail;
        public TextBox email;

        public dashboard()
        {
            InitializeComponent();
            instance = this;
            sideNavNameDisplayHolder = displayStudentName;
            fn = firstNameTextBox;
            ln = lastNameTextBox;
            email = emailTextBox;
        }

        private void iStudent_Load(object sender, EventArgs e)
        {

        }
        // add student btn start //
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string birth = datePick.Value.ToString();
            string age = ageNumericBox.Value.ToString();
            string sex = sexComboBox.Text;

            AddStudentMessage message = new AddStudentMessage();
            message.Show();

            AddStudentMessage.instance.studentFirstNameHolder.Text = firstName;
            AddStudentMessage.instance.studentLastNameHolder.Text = lastName;
            AddStudentMessage.instance.studentEmailHolder.Text = email;
            AddStudentMessage.instance.studentBirthHolder.Text = birth;
            AddStudentMessage.instance.studentAgeHolder.Text = age;
            AddStudentMessage.instance.studentSexHolder.Text = sex;

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
        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "student@gmail.com")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "student@gmail.com";
                emailTextBox.ForeColor = Color.LightGray;
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
        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            datePick.CustomFormat = "MMMMMMMMMM dd dddddddddd yyyy";
        }
    }
}
