﻿using app;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HICLabActivityOne
{
    public partial class AddStudentMessage : Form
    {
        public static AddStudentMessage instance;
        public Label studentFirstNameHolder;
        public Label studentLastNameHolder;
        public Label studentMiddleNameHolder;
        public Label studentEmailHolder;
        public Label studentBirthHolder;
        public Label studentAgeHolder;
        public Label studentSexHolder;
        public AddStudentMessage()
        {
            InitializeComponent();
            instance = this;
            studentFirstNameHolder = studentFirstName;
            studentLastNameHolder = studentLastName;
            studentMiddleNameHolder = studentMiddleName;
            studentEmailHolder = studentEmail;
            studentBirthHolder = studentBirth;
            studentAgeHolder = studentAge;
            studentSexHolder = studentSex;

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
