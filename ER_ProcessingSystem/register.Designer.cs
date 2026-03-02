namespace ER_ProcessingSystem
{
    partial class register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            cmbCourse = new ComboBox();
            cmbSemester = new ComboBox();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 33);
            label1.Name = "label1";
            label1.Size = new Size(374, 51);
            label1.TabIndex = 0;
            label1.Text = "Student Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 120);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 120);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(78, 148);
            txtName.Name = "txtName";
            txtName.Size = new Size(340, 31);
            txtName.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(536, 148);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 31);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 334);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 31);
            txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 306);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 7;
            label5.Text = "EmailID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 403);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 8;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 403);
            label7.Name = "label7";
            label7.Size = new Size(160, 25);
            label7.TabIndex = 9;
            label7.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 431);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(340, 31);
            txtPassword.TabIndex = 10;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(536, 431);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(340, 31);
            txtConfirmPassword.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 100);
            panel1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(446, 507);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 18;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(355, 544);
            label8.Name = "label8";
            label8.Size = new Size(213, 25);
            label8.TabIndex = 15;
            label8.Text = "Already have an account?";
            label8.Click += label8_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(563, 544);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 25);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign-in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(195, 211);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(75, 29);
            radioMale.TabIndex = 19;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(195, 246);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(93, 29);
            radioFemale.TabIndex = 20;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Bsc.IT" });
            cmbCourse.Location = new Point(631, 227);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(182, 33);
            cmbCourse.TabIndex = 21;
            // 
            // cmbSemester
            // 
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "4" });
            cmbSemester.Location = new Point(631, 306);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(182, 33);
            cmbSemester.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 211);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 23;
            label4.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(536, 227);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 24;
            label9.Text = "Course:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(536, 309);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 25;
            label10.Text = "Semester:";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 595);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(cmbSemester);
            Controls.Add(cmbCourse);
            Controls.Add(radioFemale);
            Controls.Add(radioMale);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "register";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Panel panel1;
        private Button button1;
        private Label label8;
        private LinkLabel linkLabel1;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private ComboBox cmbCourse;
        private ComboBox cmbSemester;
        private Label label4;
        private Label label9;
        private Label label10;
    }
}