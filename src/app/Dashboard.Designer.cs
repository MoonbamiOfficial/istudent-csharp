namespace app
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayStudentName = new System.Windows.Forms.Label();
            this.displayStudentEmail = new System.Windows.Forms.Label();
            this.sideNavHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.sexLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ageNumericBox = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.displayStudentName);
            this.panel1.Controls.Add(this.displayStudentEmail);
            this.panel1.Controls.Add(this.sideNavHeader);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 682);
            this.panel1.TabIndex = 0;
            // 
            // displayStudentName
            // 
            this.displayStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.displayStudentName.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStudentName.ForeColor = System.Drawing.Color.White;
            this.displayStudentName.Location = new System.Drawing.Point(24, 130);
            this.displayStudentName.Name = "displayStudentName";
            this.displayStudentName.Size = new System.Drawing.Size(200, 88);
            this.displayStudentName.TabIndex = 3;
            // 
            // displayStudentEmail
            // 
            this.displayStudentEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.displayStudentEmail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStudentEmail.ForeColor = System.Drawing.Color.White;
            this.displayStudentEmail.Location = new System.Drawing.Point(24, 242);
            this.displayStudentEmail.Name = "displayStudentEmail";
            this.displayStudentEmail.Size = new System.Drawing.Size(200, 59);
            this.displayStudentEmail.TabIndex = 4;
            // 
            // sideNavHeader
            // 
            this.sideNavHeader.Font = new System.Drawing.Font("Poppins ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideNavHeader.ForeColor = System.Drawing.Color.White;
            this.sideNavHeader.Location = new System.Drawing.Point(3, 39);
            this.sideNavHeader.Name = "sideNavHeader";
            this.sideNavHeader.Size = new System.Drawing.Size(244, 48);
            this.sideNavHeader.TabIndex = 2;
            this.sideNavHeader.Text = "iStudent";
            this.sideNavHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(24, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.panel4.Controls.Add(this.firstNameTextBox);
            this.panel4.Controls.Add(this.lastNameTextBox);
            this.panel4.Controls.Add(this.emailTextBox);
            this.panel4.Controls.Add(this.datePick);
            this.panel4.Controls.Add(this.ageNumericBox);
            this.panel4.Controls.Add(this.sexComboBox);
            this.panel4.Controls.Add(this.addStudentBtn);
            this.panel4.Controls.Add(this.sexLabel);
            this.panel4.Controls.Add(this.ageLabel);
            this.panel4.Controls.Add(this.birthLabel);
            this.panel4.Controls.Add(this.emailLabel);
            this.panel4.Controls.Add(this.lastNameLabel);
            this.panel4.Controls.Add(this.firstNameLabel);
            this.panel4.Location = new System.Drawing.Point(300, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 539);
            this.panel4.TabIndex = 14;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.firstNameTextBox.Location = new System.Drawing.Point(50, 81);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 27);
            this.firstNameTextBox.TabIndex = 32;
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.Enter += new System.EventHandler(this.firstNameTextBox_Enter);
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastNameTextBox.Location = new System.Drawing.Point(50, 164);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 27);
            this.lastNameTextBox.TabIndex = 26;
            this.lastNameTextBox.Text = "Last Name";
            this.lastNameTextBox.Enter += new System.EventHandler(this.lastNameTextBox_Enter);
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.Location = new System.Drawing.Point(50, 239);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 27);
            this.emailTextBox.TabIndex = 28;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // datePick
            // 
            this.datePick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePick.Location = new System.Drawing.Point(274, 80);
            this.datePick.Margin = new System.Windows.Forms.Padding(4);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(254, 27);
            this.datePick.TabIndex = 29;
            this.datePick.Value = new System.DateTime(2023, 10, 24, 0, 0, 0, 0);
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // sexComboBox
            // 
            this.sexComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.sexComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(274, 235);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(100, 31);
            this.sexComboBox.TabIndex = 31;
            this.sexComboBox.Text = "Sex";
            this.sexComboBox.Enter += new System.EventHandler(this.sexComboBox_Enter);
            this.sexComboBox.Leave += new System.EventHandler(this.sexComboBox_Leave);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.addStudentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStudentBtn.FlatAppearance.BorderSize = 0;
            this.addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addStudentBtn.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBtn.ForeColor = System.Drawing.Color.White;
            this.addStudentBtn.Location = new System.Drawing.Point(528, 440);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(150, 60);
            this.addStudentBtn.TabIndex = 24;
            this.addStudentBtn.Text = "+ ADD STUDENT";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            this.addStudentBtn.MouseLeave += new System.EventHandler(this.addStudentBtn_MouseLeave);
            this.addStudentBtn.MouseHover += new System.EventHandler(this.addStudentBtn_MouseHover);
            // 
            // sexLabel
            // 
            this.sexLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexLabel.BackColor = System.Drawing.Color.Transparent;
            this.sexLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sexLabel.ForeColor = System.Drawing.Color.White;
            this.sexLabel.Location = new System.Drawing.Point(274, 211);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(100, 25);
            this.sexLabel.TabIndex = 19;
            this.sexLabel.Text = "Sex";
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(274, 136);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(50, 25);
            this.ageLabel.TabIndex = 16;
            this.ageLabel.Text = "Age";
            // 
            // birthLabel
            // 
            this.birthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthLabel.ForeColor = System.Drawing.Color.White;
            this.birthLabel.Location = new System.Drawing.Point(274, 52);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(254, 25);
            this.birthLabel.TabIndex = 14;
            this.birthLabel.Text = "Birth";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(50, 211);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(200, 25);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(50, 136);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(200, 25);
            this.lastNameLabel.TabIndex = 33;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(50, 53);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(200, 25);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(294, 71);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(242, 36);
            this.header.TabIndex = 15;
            this.header.Text = "ENTER STUDENT DETAILS";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(24, 639);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 10);
            this.panel3.TabIndex = 2;
            // 
            // ageNumericBox
            // 
            this.ageNumericBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageNumericBox.Location = new System.Drawing.Point(274, 165);
            this.ageNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNumericBox.Name = "ageNumericBox";
            this.ageNumericBox.Size = new System.Drawing.Size(50, 27);
            this.ageNumericBox.TabIndex = 34;
            this.ageNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "dashboard";
            this.Text = "iStudent";
            this.Load += new System.EventHandler(this.iStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sideNavHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label displayStudentName;
        private System.Windows.Forms.Label displayStudentEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown ageNumericBox;
    }
}

