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
            try
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }
                string connectionString = "User ID=system;Password=it4;Data Source=localhost:1521;";
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    int newUserId;
                    string getIdQuery = "SELECT NVL(MAX(USER_ID),0)+1 FROM LOGIN";
                    using (OracleCommand getIdCmd = new OracleCommand(getIdQuery, con))
                    {
                        newUserId = Convert.ToInt32(getIdCmd.ExecuteScalar());
                    }

                    string query = @"INSERT INTO LOGIN(USER_ID,USERNAME,PASSWORD,ROLE) VALUES(:id,:username,:password,:role)";

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(":id", newUserId);
                        cmd.Parameters.Add(":username", txtUsername.Text.Trim());
                        cmd.Parameters.Add(":Password", txtPassword.Text.Trim());
                        cmd.Parameters.Add(":role", "STUDENT");

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registration Successful!");

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Database Error:\n"+ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }
    }
}
