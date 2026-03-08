
using Microsoft.VisualBasic.Devices;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ER_ProcessingSystem
{
    public partial class Student : Form
    {
        string connectionString = "User Id=system;Password=it4;Data Source=localhost:1521;";
        OracleConnection oc;
        public Student()
        {
            InitializeComponent();
        }

        void LoadStudentData()
        {

            oc = new OracleConnection(connectionString);
            string query = @"SELECT STUDENT_ID, USER_ID, FULL_NAME, GENDER, EMAIL, 
                            COURSE, SEMESTER FROM STUDENT ORDER BY STUDENT_ID";

            dgv_stud.Rows.Clear();
            try
            {
                oc.Open();
                OracleCommand command = oc.CreateCommand();
                command.CommandText = query;
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgv_stud.Rows.Add(
                         reader["USER_ID"].ToString(),
                        reader["STUDENT_ID"].ToString(),
                    reader["FULL_NAME"].ToString(),
                    reader["GENDER"].ToString(),
                    reader["EMAIL"].ToString(),
                    reader["COURSE"].ToString(),
                    reader["SEMESTER"].ToString()
                );
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }
        private void Student_Load(object sender, EventArgs e)
        {
            LoadStudentData();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_sid.Text == "")
                return;
            try
            {
                using (OracleConnection oc = new OracleConnection(connectionString))
                {
                    oc.Open();

                    string query = @"UPDATE STUDENT 
                             SET  
                                 FULL_NAME = :fullName,
                                 GENDER = :gender,
                                 EMAIL = :email,
                                 COURSE = :course,
                                 SEMESTER = :semester
                             WHERE STUDENT_ID = :studentId";

                    OracleCommand cmd = new OracleCommand(query, oc);

                    cmd.Parameters.Add(":fullName", tb_snm.Text);
                    cmd.Parameters.Add(":gender", cmb_gender.Text);
                    cmd.Parameters.Add(":email", tb_email.Text);
                    cmd.Parameters.Add(":course", cmb_course.Text);
                    cmd.Parameters.Add(":semester", Convert.ToInt16(cmb_sem.Text));
                    cmd.Parameters.Add(":studentId", Convert.ToInt32(tb_sid.Text));

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Student updated successfully.");
                        LoadStudentData();   // Refresh grid
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void ClearFields()
        {
            tb_email.Text = "";
            tb_mail.Text = "";
            tb_sid.Text = "";
            tb_snm.Text = "";
            cmb_gender.Text = "";
            cmb_course.Text = "";
            cmb_sem.Text = "";
        }

        private void dgv_stud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex == -1)
            { return; }

            DataGridViewRow row = dgv_stud.Rows[e.RowIndex];

            tb_email.Text = "" + row.Cells[4].Value;
            tb_mail.Text = "" + row.Cells[4].Value;
            tb_sid.Text = "" + row.Cells[1].Value;
            tb_snm.Text = "" + row.Cells[2].Value;
            cmb_gender.Text = "" + row.Cells[3].Value;
            cmb_course.Text = "" + row.Cells[5].Value;
            cmb_sem.Text = "" + row.Cells[6].Value;

            tb_uid.Text = "" + row.Cells[0].Value;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tb_sid.Text == "")
                return;

            DialogResult result = MessageBox.Show(
           "Are you sure you want to delete this student?",
           "Confirm Delete",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OracleConnection oc = new OracleConnection(connectionString))
                    {
                        oc.Open();

                        string query = "DELETE FROM STUDENT WHERE STUDENT_ID = :studentId";
                        string query1 = "DELETE FROM lOGIN WHERE USER_ID = :userid";

                        OracleCommand cmd = new OracleCommand(query, oc);
                        cmd.Parameters.Add(":studentId", Convert.ToInt32(tb_sid.Text));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Student deleted successfully.");

                            OracleCommand cmd1 = new OracleCommand(query1, oc);
                            cmd1.Parameters.Add(":userid", Convert.ToInt32(tb_uid.Text));

                            int rows1 = cmd1.ExecuteNonQuery();

                            if (rows1 > 0)
                            {
                                MessageBox.Show("Student Login deleted successfully.");
                            }
                            LoadStudentData();   // Refresh grid
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
