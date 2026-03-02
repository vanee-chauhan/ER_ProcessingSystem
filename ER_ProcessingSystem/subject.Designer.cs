namespace ER_ProcessingSystem
{
    partial class subject
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
            gb_subEntry = new GroupBox();
            lbl_sub_nm = new Label();
            lbl_Course = new Label();
            lbl_sem = new Label();
            lbl_asgnTeacher = new Label();
            tb_subNm = new TextBox();
            cb_course = new ComboBox();
            cb_sem = new ComboBox();
            cb_asgTeacher = new ComboBox();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            dgv_sub = new DataGridView();
            gb_subEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sub).BeginInit();
            SuspendLayout();
            // 
            // gb_subEntry
            // 
            gb_subEntry.Controls.Add(cb_asgTeacher);
            gb_subEntry.Controls.Add(cb_sem);
            gb_subEntry.Controls.Add(cb_course);
            gb_subEntry.Controls.Add(tb_subNm);
            gb_subEntry.Controls.Add(lbl_asgnTeacher);
            gb_subEntry.Controls.Add(lbl_sem);
            gb_subEntry.Controls.Add(lbl_Course);
            gb_subEntry.Controls.Add(lbl_sub_nm);
            gb_subEntry.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_subEntry.Location = new Point(49, 49);
            gb_subEntry.Name = "gb_subEntry";
            gb_subEntry.Size = new Size(352, 255);
            gb_subEntry.TabIndex = 0;
            gb_subEntry.TabStop = false;
            gb_subEntry.Text = "Subject Entry";
            // 
            // lbl_sub_nm
            // 
            lbl_sub_nm.AutoSize = true;
            lbl_sub_nm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sub_nm.Location = new Point(19, 45);
            lbl_sub_nm.Name = "lbl_sub_nm";
            lbl_sub_nm.Size = new Size(109, 20);
            lbl_sub_nm.TabIndex = 0;
            lbl_sub_nm.Text = "Subject Name :";
            lbl_sub_nm.Click += this.lbl_sub_nm_Click;
            // 
            // lbl_Course
            // 
            lbl_Course.AutoSize = true;
            lbl_Course.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Course.Location = new Point(67, 83);
            lbl_Course.Name = "lbl_Course";
            lbl_Course.Size = new Size(61, 20);
            lbl_Course.TabIndex = 1;
            lbl_Course.Text = "Course :";
            // 
            // lbl_sem
            // 
            lbl_sem.AutoSize = true;
            lbl_sem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sem.Location = new Point(58, 135);
            lbl_sem.Name = "lbl_sem";
            lbl_sem.Size = new Size(77, 20);
            lbl_sem.TabIndex = 2;
            lbl_sem.Text = "Semester :";
            lbl_sem.Click += this.lbl_sem_Click;
            // 
            // lbl_asgnTeacher
            // 
            lbl_asgnTeacher.AutoSize = true;
            lbl_asgnTeacher.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_asgnTeacher.Location = new Point(10, 175);
            lbl_asgnTeacher.Name = "lbl_asgnTeacher";
            lbl_asgnTeacher.Size = new Size(131, 20);
            lbl_asgnTeacher.TabIndex = 3;
            lbl_asgnTeacher.Text = "Assigned Teacher :";
            // 
            // tb_subNm
            // 
            tb_subNm.Location = new Point(155, 38);
            tb_subNm.Name = "tb_subNm";
            tb_subNm.Size = new Size(178, 34);
            tb_subNm.TabIndex = 4;
            tb_subNm.TextChanged += this.textBox1_TextChanged;
            // 
            // cb_course
            // 
            cb_course.FormattingEnabled = true;
            cb_course.Location = new Point(155, 83);
            cb_course.Name = "cb_course";
            cb_course.Size = new Size(178, 33);
            cb_course.TabIndex = 5;
            // 
            // cb_sem
            // 
            cb_sem.FormattingEnabled = true;
            cb_sem.Location = new Point(155, 128);
            cb_sem.Name = "cb_sem";
            cb_sem.Size = new Size(178, 33);
            cb_sem.TabIndex = 6;
            // 
            // cb_asgTeacher
            // 
            cb_asgTeacher.FormattingEnabled = true;
            cb_asgTeacher.Location = new Point(155, 175);
            cb_asgTeacher.Name = "cb_asgTeacher";
            cb_asgTeacher.Size = new Size(178, 33);
            cb_asgTeacher.TabIndex = 7;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(473, 63);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(473, 107);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(473, 156);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // dgv_sub
            // 
            dgv_sub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sub.Location = new Point(116, 330);
            dgv_sub.Name = "dgv_sub";
            dgv_sub.RowHeadersWidth = 51;
            dgv_sub.Size = new Size(579, 160);
            dgv_sub.TabIndex = 4;
            // 
            // subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 567);
            Controls.Add(dgv_sub);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(gb_subEntry);
            Name = "subject";
            Text = "Manage Subjects";
            gb_subEntry.ResumeLayout(false);
            gb_subEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_subEntry;
        private ComboBox cb_asgTeacher;
        private ComboBox cb_sem;
        private ComboBox cb_course;
        private TextBox tb_subNm;
        private Label lbl_asgnTeacher;
        private Label lbl_sem;
        private Label lbl_Course;
        private Label lbl_sub_nm;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private DataGridView dgv_sub;
    }
}