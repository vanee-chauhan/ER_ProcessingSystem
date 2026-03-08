namespace ER_ProcessingSystem
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            examinationToolStripMenuItem = new ToolStripMenuItem();
            enterStudentMarksToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            manageStudentsToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            subjectsToolStripMenuItem = new ToolStripMenuItem();
            manageSubjectToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { examinationToolStripMenuItem, studentsToolStripMenuItem, subjectsToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(943, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // examinationToolStripMenuItem
            // 
            examinationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enterStudentMarksToolStripMenuItem });
            examinationToolStripMenuItem.Name = "examinationToolStripMenuItem";
            examinationToolStripMenuItem.Size = new Size(105, 24);
            examinationToolStripMenuItem.Text = "Examination";
            // 
            // enterStudentMarksToolStripMenuItem
            // 
            enterStudentMarksToolStripMenuItem.Name = "enterStudentMarksToolStripMenuItem";
            enterStudentMarksToolStripMenuItem.Size = new Size(224, 26);
            enterStudentMarksToolStripMenuItem.Text = "Enter Student Marks";
            enterStudentMarksToolStripMenuItem.Click += enterStudentMarksToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageStudentsToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // manageStudentsToolStripMenuItem
            // 
            manageStudentsToolStripMenuItem.Name = "manageStudentsToolStripMenuItem";
            manageStudentsToolStripMenuItem.Size = new Size(224, 26);
            manageStudentsToolStripMenuItem.Text = "Manage Students";
            manageStudentsToolStripMenuItem.Click += manageStudentsToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // subjectsToolStripMenuItem
            // 
            subjectsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageSubjectToolStripMenuItem });
            subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            subjectsToolStripMenuItem.Size = new Size(78, 24);
            subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // manageSubjectToolStripMenuItem
            // 
            manageSubjectToolStripMenuItem.Name = "manageSubjectToolStripMenuItem";
            manageSubjectToolStripMenuItem.Size = new Size(224, 26);
            manageSubjectToolStripMenuItem.Text = "Manage Subject";
            manageSubjectToolStripMenuItem.Click += manageSubjectToolStripMenuItem_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 541);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem examinationToolStripMenuItem;
        private ToolStripMenuItem enterStudentMarksToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem manageStudentsToolStripMenuItem;
        private ToolStripMenuItem subjectsToolStripMenuItem;
        private ToolStripMenuItem manageSubjectToolStripMenuItem;
    }
}