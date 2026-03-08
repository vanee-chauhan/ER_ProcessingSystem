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

namespace ER_ProcessingSystem
{
    public partial class ViewResultForm : Form
    {
        public ViewResultForm()
        {
            InitializeComponent();
        }

        private void pnlReportCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvResultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_grade_Click(object sender, EventArgs e)
        {

        }

        private void ViewResultForm_Load(object sender, EventArgs e)
        {
            pnlReportCard.Visible = false;
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            ViewResult();
            pnlReportCard.Visible = true;
        }

        public void ViewResult()
        {
            try
            {
                if (cmb_sem.SelectedItem == null || cmb_cs.SelectedItem == null || General.studentId == -1)
                    return;

                using (OracleConnection con = new OracleConnection(General.connectionString))
                {
                    con.Open();

                    int semester = Convert.ToInt32(cmb_sem.SelectedItem.ToString());
                    string course = cmb_cs.SelectedItem.ToString();

                    string query = @"
                SELECT s.full_name,
                        s.course,
                        s.semester,
                        sub.subject_name,
                        m.internal_marks,
                        m.external_marks,
                        m.total_marks,
                        m.grade
                 FROM MARKS m
                 JOIN STUDENT s ON m.student_id = s.student_id
                 JOIN SUBJECT sub ON m.subject_id = sub.subject_id
                 WHERE s.semester = :sem
                   AND s.student_id = :sid
                   AND UPPER(s.course) = UPPER(:course)";

                    OracleCommand cmd = new OracleCommand(query, con);
                    //cmd.Parameters.Add(":sem", semester);
                    //cmd.Parameters.Add(":course", course);
                    //cmd.Parameters.Add(":sid", General.studentId);

                    cmd.Parameters.Add(new OracleParameter("sem", semester));
                    cmd.Parameters.Add(new OracleParameter("sid", General.studentId));
                    cmd.Parameters.Add(new OracleParameter("course", course));


                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                   

                    if (dt.Rows.Count > 0)
                    {
                        dgvResultGrid.Columns.Clear();

                        dgvResultGrid.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            DataPropertyName = "SUBJECT_NAME",
                            HeaderText = "Subject Name"
                        });

                        dgvResultGrid.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            DataPropertyName = "INTERNAL_MARKS",
                            HeaderText = "Internal Marks"
                        });

                        dgvResultGrid.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            DataPropertyName = "EXTERNAL_MARKS",
                            HeaderText = "External Marks"
                        });

                        dgvResultGrid.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            DataPropertyName = "TOTAL_MARKS",
                            HeaderText = "Total Marks"
                        });

                        dgvResultGrid.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            DataPropertyName = "GRADE",
                            HeaderText = "Grade"
                        });


                        // Bind to DataGridView
                        dgvResultGrid.AutoGenerateColumns = false; // use predefined columns
                        dgvResultGrid.DataSource = dt;

                      

                        
                        txt_sNm.Text = dt.Rows[0]["full_name"].ToString();
                        tb_cs.Text = dt.Rows[0]["course"].ToString();
                        tb_sem.Text = dt.Rows[0]["semester"].ToString();

                        
                        decimal grandTotal = 0;

                        foreach (DataRow row in dt.Rows)
                        {
                            grandTotal += Convert.ToDecimal(row["total_marks"]);
                        }

                        tb_total.Text = grandTotal.ToString();

                        
                        string finalGrade = "";

                        if (grandTotal >= 300)
                            finalGrade = "A";
                        else if (grandTotal >= 250)
                            finalGrade = "B";
                        else if (grandTotal >= 200)
                            finalGrade = "C";
                        else
                            finalGrade = "Fail";

                        tb_fgrd.Text = finalGrade;

                        double sgpa = CalculateSGPA(dt);
                        tb_sgpa.Text = sgpa.ToString("0.00"); 

                       
                    }
                    else
                    {
                        MessageBox.Show("No record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double CalculateSGPA(DataTable dt)
        {
            // Define grade-to-point mapping
            Dictionary<string, int> gradePoints = new Dictionary<string, int>()
    {
        { "A", 9 },
        { "B", 8 },
        { "C", 7 },
        { "D", 6 },
        { "E", 5 },
        { "F", 0 }
    };

            int totalCredits = 0;
            int totalGradePoints = 0;

            // Assume each subject has 4 credits (adjust if needed)
            int subjectCredits = 4;

            foreach (DataRow row in dt.Rows)
            {
                if (row["GRADE"] != DBNull.Value)
                {
                    string grade = row["GRADE"].ToString().Trim().ToUpper();

                    if (gradePoints.ContainsKey(grade))
                    {
                        int gp = gradePoints[grade];
                        totalGradePoints += gp * subjectCredits;
                        totalCredits += subjectCredits;
                    }
                }
            }

            if (totalCredits == 0) return 0.0;

            return (double)totalGradePoints / totalCredits;
        }

       
    }
}
