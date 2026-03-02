using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ER_ProcessingSystem
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtUsername.Text == "" ||
        txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string gender = "";
            if (radioMale.Checked)
                gender = "Male";
            else if (radioFemale.Checked)
                gender = "Female";

            string connectionString = "User ID=system;Password=it4;Data Source=localhost:1521;";

            OracleConnection con = new OracleConnection(connectionString);
            con.Open();

            try
            {
                int newUserId = 1;
                int newStudentId = 1;

                OracleCommand cmdUserId = new OracleCommand(
                    "SELECT MAX(USER_ID) FROM LOGIN", con);

                object resultUser = cmdUserId.ExecuteScalar();

                if (resultUser != DBNull.Value && resultUser != null)
                    newUserId = Convert.ToInt32(resultUser) + 1;

                OracleCommand cmdLogin = new OracleCommand(
                    "INSERT INTO LOGIN (USER_ID, USERNAME, PASSWORD, ROLE) " +
                    "VALUES (:user_id, :username, :password, 'STUDENT')", con);

                cmdLogin.Parameters.Add(":user_id", newUserId);
                cmdLogin.Parameters.Add(":username", txtUsername.Text);
                cmdLogin.Parameters.Add(":password", txtPassword.Text);

                cmdLogin.ExecuteNonQuery();

                OracleCommand cmdStudentId = new OracleCommand(
                    "SELECT MAX(STUDENT_ID) FROM STUDENT", con);

                object resultStudent = cmdStudentId.ExecuteScalar();

                if (resultStudent != DBNull.Value && resultStudent != null)
                    newStudentId = Convert.ToInt32(resultStudent) + 1;

                OracleCommand cmdStudent = new OracleCommand(
                    "INSERT INTO STUDENT (STUDENT_ID, USER_ID, FULL_NAME, GENDER, EMAIL, COURSE, SEMESTER) " +
                    "VALUES (:student_id, :user_id, :full_name, :gender, :email, :course, :semester)", con);

                cmdStudent.Parameters.Add(":student_id", newStudentId);
                cmdStudent.Parameters.Add(":user_id", newUserId);
                cmdStudent.Parameters.Add(":full_name", txtName.Text);
                cmdStudent.Parameters.Add(":gender", gender);
                cmdStudent.Parameters.Add(":email", txtEmail.Text);
                cmdStudent.Parameters.Add(":course", cmbCourse.Text);
                cmdStudent.Parameters.Add(":semester", Convert.ToInt32(cmbSemester.Text));

                cmdStudent.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!");

                con.Close();
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }
    }
}
