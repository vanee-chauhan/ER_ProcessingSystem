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
    public partial class subject : Form
    {
        string connectionString = "User Id=system;Password=it4;Data Source=localhost:1521;";
        OracleConnection oc;
        public subject()
        {
            InitializeComponent();
        }

        private void subject_Load(object sender, EventArgs e)
        {
            oc = new OracleConnection(connectionString);
            string query = "select subject_id, subject_name, course, semester, teacher_id from subject";

            try
            {
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
                        reader["teacher_id"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
