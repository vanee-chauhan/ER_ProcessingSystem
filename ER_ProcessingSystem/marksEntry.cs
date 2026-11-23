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
            if (cmb_course.SelectedIndex == -1 || cmb_sem.SelectedIndex == -1 || cmb_sub.SelectedIndex == -1)
            {
                if (cmb_course.SelectedIndex == -1)
                    cmb_course.Focus();
                else if (cmb_sem.SelectedIndex == -1)
                    cmb_sem.Focus();
                else if (cmb_sub.SelectedIndex == -1)
                    cmb_sub.Focus();

                MessageBox.Show("Please select course, semester and subject");
                return;
            }
            // int subjectId = Convert.ToInt32(cmb_sub.SelectedValue);
            try
            {
                using (OracleConnection con = new OracleConnection(General.connectionString))
                {
                    con.Open();

                    int subjectId = Convert.ToInt32(cmb_sub.SelectedValue);

                    string query = @"
            SELECT s.STUDENT_ID,
                   s.FULL_NAME,
                   m.INTERNAL_MARKS,
                   m.EXTERNAL_MARKS
            FROM STUDENT s
            LEFT JOIN MARKS m
            ON s.STUDENT_ID = m.STUDENT_ID
            AND m.SUBJECT_ID = :subid
            ORDER BY s.FULL_NAME";

                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.Parameters.Add(":subid", subjectId);

                    OracleDataReader dr = cmd.ExecuteReader();

                    dgvMarksEntry.Rows.Clear();

                    while (dr.Read())
                    {
                        int rowIndex = dgvMarksEntry.Rows.Add();

                        dgvMarksEntry.Rows[rowIndex].Cells["colStudentId"].Value =
                            dr["STUDENT_ID"].ToString();

                        dgvMarksEntry.Rows[rowIndex].Cells["colStudentName"].Value =
                            dr["FULL_NAME"].ToString();

                        // If marks exist → show them
                        if (dr["INTERNAL_MARKS"] != DBNull.Value)
                            dgvMarksEntry.Rows[rowIndex].Cells["colInternal"].Value =
                                dr["INTERNAL_MARKS"].ToString();

                        if (dr["EXTERNAL_MARKS"] != DBNull.Value)
                            dgvMarksEntry.Rows[rowIndex].Cells["colExternal"].Value =
                                dr["EXTERNAL_MARKS"].ToString();

                        // Make marks readonly initially
                        dgvMarksEntry.Rows[rowIndex].Cells["colInternal"].ReadOnly = true;
                        dgvMarksEntry.Rows[rowIndex].Cells["colExternal"].ReadOnly = true;
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }



        private void LoadSubjects()
        {
            using (OracleConnection con =
                new OracleConnection(General.connectionString))
            {
                con.Open();

                string query = @"
            SELECT SUBJECT_ID, SUBJECT_NAME
            FROM SUBJECT
            WHERE (:role = 'ADMIN'
                   OR TEACHER_ID = :teacherId)
            ORDER BY SUBJECT_NAME";

                using (OracleCommand cmd =
                    new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":role", General.role.ToUpper());
                    cmd.Parameters.Add(":teacherId", General.teacherId);

                    OracleDataAdapter da = new OracleDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmb_sub.DataSource = dt;
                    cmb_sub.DisplayMember = "SUBJECT_NAME";
                    cmb_sub.ValueMember = "SUBJECT_ID";
                }
            }

            //using (OracleConnection con = new OracleConnection(General.connectionString))
            //{
            //    con.Open();

            //    string query = "SELECT SUBJECT_ID, SUBJECT_NAME FROM SUBJECT";
            //    OracleDataAdapter da = new OracleDataAdapter(query, con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    cmb_sub.DataSource = dt;
            //    cmb_sub.DisplayMember = "SUBJECT_NAME";
            //    cmb_sub.ValueMember = "SUBJECT_ID";
            //}
        }

        
        
        private void marksEntry_Load(object sender, EventArgs e)
        {
            dgvMarksEntry.AutoGenerateColumns = false;
            LoadSubjects();
        }



        private void btnSaveMarks_Click(object sender, EventArgs e)
        {
        }
        private void InsertRow(int rowIndex)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(General.connectionString))
                {
                    con.Open();

                    DataGridViewRow row = dgvMarksEntry.Rows[rowIndex];

                    int studentId = Convert.ToInt32(row.Cells["colStudentId"].Value);
                    int subjectId = Convert.ToInt32(cmb_sub.SelectedValue);

                    int internalMarks = Convert.ToInt32(row.Cells["colInternal"].Value);
                    int externalMarks = Convert.ToInt32(row.Cells["colExternal"].Value);

                    int total = internalMarks + externalMarks;

                    string grade = "";
                    if (total >= 75) grade = "A";
                    else if (total >= 60) grade = "B";
                    else if (total >= 50) grade = "C";
                    else grade = "F";

                    string insertQuery = @"INSERT INTO MARKS
                    (STUDENT_ID, SUBJECT_ID, INTERNAL_MARKS, EXTERNAL_MARKS, TOTAL_MARKS, GRADE)
                    VALUES (:sid, :subid, :internal, :external, :total, :grade)";

                    OracleCommand cmd = new OracleCommand(insertQuery, con);

                    cmd.Parameters.Add(":sid", studentId);
                    cmd.Parameters.Add(":subid", subjectId);
                    cmd.Parameters.Add(":internal", internalMarks);
                    cmd.Parameters.Add(":external", externalMarks);
                    cmd.Parameters.Add(":total", total);
                    cmd.Parameters.Add(":grade", grade);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Marks Inserted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateRow(int rowIndex)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(General.connectionString))
                {
                    con.Open();

                    DataGridViewRow row = dgvMarksEntry.Rows[rowIndex];

                    int studentId = Convert.ToInt32(row.Cells["colStudentId"].Value);
                    int subjectId = Convert.ToInt32(cmb_sub.SelectedValue);

                    int internalMarks = Convert.ToInt32(row.Cells["colInternal"].Value);
                    int externalMarks = Convert.ToInt32(row.Cells["colExternal"].Value);

                    int total = internalMarks + externalMarks;

                    string grade = "";
                    if (total >= 75) grade = "A";
                    else if (total >= 60) grade = "B";
                    else if (total >= 50) grade = "C";
                    else grade = "F";

                    string updateQuery = @"UPDATE MARKS
                                   SET INTERNAL_MARKS=:internal,
                                       EXTERNAL_MARKS=:external,
                                       TOTAL_MARKS=:total,
                                       GRADE=:grade
                                   WHERE STUDENT_ID=:sid
                                   AND SUBJECT_ID=:subid";

                    OracleCommand cmd = new OracleCommand(updateQuery, con);

                    cmd.Parameters.Add(":internal", internalMarks);
                    cmd.Parameters.Add(":external", externalMarks);
                    cmd.Parameters.Add(":total", total);
                    cmd.Parameters.Add(":grade", grade);
                    cmd.Parameters.Add(":sid", studentId);
                    cmd.Parameters.Add(":subid", subjectId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Marks Updated Successfully");
                    else
                        MessageBox.Show("Record Not Found. Use Insert.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMarksEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // INSERT BUTTON
            if (dgvMarksEntry.Columns[e.ColumnIndex].Name == "Save")
            {
                if (IsAlreadyExists(e.RowIndex) == false)
                {
                    InsertRow(e.RowIndex);
                    ReadOnlyRows(e.RowIndex, true);
                }
                else
                {
                    UpdateRow(e.RowIndex);
                    ReadOnlyRows(e.RowIndex, true);
                }

            }
            else if (dgvMarksEntry.Columns[e.ColumnIndex].Name == "Edit")
            {
                ReadOnlyRows(e.RowIndex, false); // edit mode open
            }


            // UPDATE BUTTON
            //if (dgvMarksEntry.Columns[e.ColumnIndex].Name == "Delete")
            //{
            //    UpdateRow(e.RowIndex);
            //}

        }

        public bool IsAlreadyExists(int rowIndex)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(General.connectionString))
                {

                    connection.Open();

                    DataGridViewRow row = dgvMarksEntry.Rows[rowIndex];

                    int studentId = Convert.ToInt32(row.Cells["colStudentId"].Value);
                    int subjectId = Convert.ToInt32(cmb_sub.SelectedValue);

                    string query = @"SELECT COUNT(*) 
                             FROM MARKS 
                             WHERE STUDENT_ID = :studentId 
                               AND SUBJECT_ID = :subjectId";

                    using (var command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("studentId", studentId));
                        command.Parameters.Add(new OracleParameter("subjectId", subjectId));

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void ReadOnlyRows(int rowIndex, bool status)
        {
            DataGridViewRow row = dgvMarksEntry.Rows[rowIndex];

            foreach (DataGridViewCell cell in row.Cells)
            {
                // Make only InternalMarks and ExternalMarks editable
                if (cell.OwningColumn.Name == "colInternal" ||
                    cell.OwningColumn.Name == "colExternal")
                {
                    cell.ReadOnly = status;
                }
            }
        }

    }
}

