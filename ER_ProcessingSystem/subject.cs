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


namespace ER_ProcessingSystem
{
    public partial class subject : Form
    {
        string connectionString = "User Id=system;Password=it4;Data Source=localhost:1521;";
        OracleConnection oc;
        public subject()
        {
            InitializeComponent();
        }
        private void LoadTeacher()
        {
            try
            {
                string Tquery = "SELECT teacher_id,full_name FROM teacher";

                OracleCommand cmd = new OracleCommand(Tquery, oc);
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                cb_asgTeacher.DisplayMember = "full_name";
                cb_asgTeacher.ValueMember = "teacher_id";
                cb_asgTeacher.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public void load_sub()
        {
            oc = new OracleConnection(connectionString);
            string query = @"SELECT 
                 s.subject_id,
                 s.subject_name,
                 s.course,
                 s.semester,
                 t.full_name
                 FROM subject s
                 JOIN teacher t
                 ON s.teacher_id = t.teacher_id";


            try
            {
                dgv_sub.Rows.Clear();
                oc.Open();
                OracleCommand command = oc.CreateCommand();
                command.CommandText = query;
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dgv_sub.Rows.Add(
                        reader["subject_id"].ToString(),
                        reader["subject_name"].ToString(),
                        reader["course"].ToString(),
                        reader["semester"].ToString(),
                        reader["full_name"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void subject_Load(object sender, EventArgs e)
        {
            load_sub();
            LoadTeacher();
        }

        private void dgv_sub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = tb_subNm.Text;
            string course = cb_course.Text;
            string semester = cb_sem.Text;
            string teacher = cb_asgTeacher.SelectedValue.ToString();

            try
            {
                OracleConnection con = new OracleConnection(General.connectionString);

                con.Open();

                string insertQuery = @$"INSERT INTO SUBJECT (SUBJECT_ID, SUBJECT_NAME, COURSE, SEMESTER, TEACHER_ID) 
                                      VALUES((SELECT NVL(MAX(SUBJECT_ID), 0) + 1 FROM SUBJECT),
                              '{name}','{course}','{semester}','{teacher}')";

                OracleCommand cmd = new OracleCommand(insertQuery, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Subject Inserted Successfully");

                load_sub();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ClearField()
        {
            tb_subNm.Text = "";
            cb_course.Text = "";
            cb_sem.Text = "";
            cb_asgTeacher.Text = "";
        }
        private void btn_clr_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void dgv_sub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgv_sub.Rows[e.RowIndex];
            int subjectId = Convert.ToInt32(row.Cells[0].Value);
            tb_subNm.Text = row.Cells[1].Value.ToString();
            cb_course.Text = row.Cells[2].Value.ToString();
            cb_sem.Text = row.Cells[3].Value.ToString();
            cb_asgTeacher.Text = row.Cells[4].Value.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tb_subNm.Text == "")
            {
                MessageBox.Show("Please select a record to delete");
                return;
            }
            DialogResult result = MessageBox.Show(
          "Are you sure you want to delete this subject?",
          "Confirm Delete",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {

                return;
            }


            int id = Convert.ToInt32(dgv_sub.SelectedRows[0].Cells[0].Value);

            try
            {
                OracleConnection con = new OracleConnection(General.connectionString);

                con.Open();

                string deleteQuery = $"DELETE FROM SUBJECT WHERE SUBJECT_ID = {id}";

                OracleCommand cmd = new OracleCommand(deleteQuery, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Subject Deleted Successfully");

                load_sub();// Refresh DataGridView
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_subNm.Text == "")
            {
                MessageBox.Show("Please select a record to update");
                return;
            }

            try
            {
                
                int id = Convert.ToInt32(dgv_sub.SelectedRows[0].Cells[0].Value);

                string name = tb_subNm.Text;
                string course = cb_course.Text;
                string sem = cb_sem.Text;
                string teacher = cb_asgTeacher.SelectedValue.ToString();

                OracleConnection con = new OracleConnection(General.connectionString);

                con.Open();

                string updateQuery = $@"UPDATE SUBJECT 
                                SET SUBJECT_NAME='{name}',
                                    COURSE='{course}',
                                    SEMESTER='{sem}',
                                    TEACHER_ID='{teacher}'
                                WHERE SUBJECT_ID={id}";

                OracleCommand cmd = new OracleCommand(updateQuery, con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Subject Updated Successfully");

                load_sub(); // Refresh DataGridView
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


