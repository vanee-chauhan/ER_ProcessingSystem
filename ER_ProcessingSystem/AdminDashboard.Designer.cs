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
            accountToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { examinationToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1179, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // examinationToolStripMenuItem
            // 
            examinationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enterStudentMarksToolStripMenuItem });
            examinationToolStripMenuItem.Name = "examinationToolStripMenuItem";
            examinationToolStripMenuItem.Size = new Size(124, 29);
            examinationToolStripMenuItem.Text = "Examination";
            // 
            // enterStudentMarksToolStripMenuItem
            // 
            enterStudentMarksToolStripMenuItem.Name = "enterStudentMarksToolStripMenuItem";
            enterStudentMarksToolStripMenuItem.Size = new Size(273, 34);
            enterStudentMarksToolStripMenuItem.Text = "Enter Student Marks";
            enterStudentMarksToolStripMenuItem.Click += enterStudentMarksToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(93, 29);
            accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(270, 34);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 676);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "AdminDashboard";
            Text = "Form2";
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
    }
}