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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void myAcademicsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewResultForm frm = new ViewResultForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
