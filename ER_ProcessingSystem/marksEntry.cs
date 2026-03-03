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

        private void marksEntry_Load(object sender, EventArgs e)
        {
            dgvMarksEntry.AutoGenerateColumns = false;
        }
    }
}
