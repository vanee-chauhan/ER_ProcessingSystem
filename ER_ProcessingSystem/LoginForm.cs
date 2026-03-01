using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER_ProcessingSystem
{
    public partial class LoginForm : Form
    {
        string connectionString = "User Id=system;Password=it4;Data Source=localhost:1521;";
        OracleConnection oc;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(tb_nm.Text))
            {
                MessageBox.Show("Please enter Username", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nm.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_pwd.Text))
            {
                MessageBox.Show("Please enter Password", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_pwd.Focus();
                return;

            }
            try
            {
                using (oc = new OracleConnection(connectionString))
                {
                    oc.Open();

                    string query = "SELECT ROLE FROM LOGIN WHERE USERNAME = :username AND PASSWORD = :password";

                    using (OracleCommand cmd = new OracleCommand(query, oc))
                    {
                        cmd.Parameters.Add(new OracleParameter("username", tb_nm.Text.Trim()));
                        cmd.Parameters.Add(new OracleParameter("password", tb_pwd.Text.Trim()));

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();

                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();

                            if (role == "STUDENT")
                            {
                                StudentDashboard studentForm = new StudentDashboard();
                                studentForm.Show();
                            }
                            else if (role == "ADMIN")
                            {
                                AdminDashboard adminForm = new AdminDashboard();
                                adminForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register reg=new register();
            reg.Show();
            this.Hide();
        }
    }
}


        

