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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuEnterStudentMarks_Click(object sender, EventArgs e)
        {

        }

        private void enterStudentMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marksEntry mE = new marksEntry();
            mE.MdiParent = this;

            mE.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            General.studentId = -1;
            General.teacherId = -1;
            General.role = "";
            MainForm frm = new MainForm();
            frm.Show();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.MdiParent = this;

            s.Show();
        }

        private void manageSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subject sub = new subject();
            sub.MdiParent = this;
            sub.Show();
        }
    }
}
