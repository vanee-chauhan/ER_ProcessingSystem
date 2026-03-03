using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER_ProcessingSystem
{
    public partial class marksEntry : Form
    {
        string connectionString = "User Id=system;Password=it4;Data Source=localhost:1521;";

        public marksEntry()
        {
            InitializeComponent();
        }

        private void lbl_sem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gb_selectclass_Enter(object sender, EventArgs e)
        {

        }

        private void btn_loadStudent_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT STUDENT_ID, FULL_NAME FROM STUDENT";

                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader dr = cmd.ExecuteReader();

                    dgvMarksEntry.Rows.Clear();

                    while (dr.Read())
                    {
                        int rowIndex = dgvMarksEntry.Rows.Add();

                        dgvMarksEntry.Rows[rowIndex].Cells["colStudentId"].Value =
                            dr["STUDENT_ID"].ToString();

                        dgvMarksEntry.Rows[rowIndex].Cells["colStudentName"].Value =
                            dr["FULL_NAME"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadSubjects()
        {
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();

                string query = "SELECT SUBJECT_ID, SUBJECT_NAME FROM SUBJECT";
                OracleDataAdapter da = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb_sub.DataSource = dt;
                cmb_sub.DisplayMember = "SUBJECT_NAME";
                cmb_sub.ValueMember = "SUBJECT_ID";
            }
        }
        private void marksEntry_Load(object sender, EventArgs e)
        {
            dgvMarksEntry.AutoGenerateColumns = false;
            LoadSubjects();
        }

       

        private void btnSaveMarks_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    int subjectId = Convert.ToInt32(cmb_sub.SelectedValue);

                    foreach (DataGridViewRow row in dgvMarksEntry.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int studentId = Convert.ToInt32(row.Cells["colStudentId"].Value);
                        int internalMarks = Convert.ToInt32(row.Cells["colInternal"].Value);
                        int externalMarks = Convert.ToInt32(row.Cells["colExternal"].Value);

                        int total = internalMarks + externalMarks;

                        string grade;

                        if (total >= 80)
                            grade = "A";
                        else if (total >= 60)
                            grade = "B";
                        else if (total >= 50)
                            grade = "C";
                        else if (total >= 35)
                            grade = "D";
                        else
                            grade = "F";

                        string idQuery = "SELECT NVL(MAX(MARKS_ID),0)+1 FROM MARKS";
                        OracleCommand cmdId = new OracleCommand(idQuery, con);
                        int marksId = Convert.ToInt32(cmdId.ExecuteScalar());

                        string insertQuery = @"INSERT INTO MARKS
                           (MARKS_ID, STUDENT_ID, SUBJECT_ID,
                            INTERNAL_MARKS, EXTERNAL_MARKS,
                            TOTAL_MARKS, GRADE)
                           VALUES
                           (:id, :sid, :subid,
                            :internal, :external,
                            :total, :grade)";

                        OracleCommand cmd = new OracleCommand(insertQuery, con);

                        cmd.Parameters.Add(":id", marksId);
                        cmd.Parameters.Add(":sid", studentId);
                        cmd.Parameters.Add(":subid", subjectId);
                        cmd.Parameters.Add(":internal", internalMarks);
                        cmd.Parameters.Add(":external", externalMarks);
                        cmd.Parameters.Add(":total", total);
                        cmd.Parameters.Add(":grade", grade);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("All Marks Saved Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
