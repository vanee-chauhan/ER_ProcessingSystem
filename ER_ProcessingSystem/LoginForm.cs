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

                    string query = "SELECT USER_ID, ROLE FROM LOGIN WHERE USERNAME = :username AND PASSWORD = :password";

                    using (OracleCommand cmd = new OracleCommand(query, oc))
                    {
                        cmd.Parameters.Add(new OracleParameter("username", tb_nm.Text.Trim()));
                        cmd.Parameters.Add(new OracleParameter("password", tb_pwd.Text.Trim()));

                        long userId = -1;
                        string role = "";
                        //object result = cmd.ExecuteScalar();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // move to first row
                            {
                                userId = reader.GetInt32(0);
                                role = reader.GetString(1);
                                General.role = role;
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password");
                            }

                        }

                        if (string.IsNullOrWhiteSpace( role ) == false)
                        {
                            //string role = result.ToString();
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.Hide();

                            if (role == "STUDENT")
                            {
                                StudentDashboard studentForm = new StudentDashboard();
                                 string query1 = "SELECT STUDENT_ID FROM STUDENT WHERE USER_ID = :userid";
                                try
                                {
                                    using (OracleConnection oc1 = new OracleConnection(connectionString))
                                    {
                                        oc1.Open();
                                        using (OracleCommand cmd1 = new OracleCommand(query1, oc1))
                                        {
                                            cmd1.Parameters.Add("userid", OracleDbType.Int64).Value = userId;
                                            object result1 = cmd1.ExecuteScalar();
                                            if (result1 != null)
                                            {
                                                General.studentId = Convert.ToInt64(result1.ToString());
                                                General.teacherId = -1;
                                                General.userId = userId;

                                                studentForm.Show();
                                            }
                                        }
                                    }
                                }
                                catch { Application.Exit(); }
                            }
                            else if (role == "ADMIN")
                            {
                                string query1 = "SELECT TEACHER_ID FROM TEACHER WHERE USER_ID = :userid";
                                try
                                {
                                    using (OracleConnection oc1 = new OracleConnection(connectionString))
                                    {
                                        oc1.Open();
                                        using (OracleCommand cmd1 = new OracleCommand(query1, oc1))
                                        {
                                            cmd1.Parameters.Add("userid", OracleDbType.Int64).Value = userId;
                                            object result1 = cmd1.ExecuteScalar();

                                            General.teacherId = Convert.ToInt64(result1.ToString());

                                            General.studentId = -1;
                                            General.userId = userId;
                                            AdminDashboard adminForm = new AdminDashboard();
                                            adminForm.Show();
                                        }
                                    }
                                }catch(Exception ex)
                                {

                                }
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


        

