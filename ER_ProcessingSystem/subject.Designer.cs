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
            cb_asgTeacher = new ComboBox();
            cb_sem = new ComboBox();
            cb_course = new ComboBox();
            tb_subNm = new TextBox();
            lbl_asgnTeacher = new Label();
            lbl_sem = new Label();
            lbl_Course = new Label();
            lbl_sub_nm = new Label();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            dgv_sub = new DataGridView();
            sub_id = new DataGridViewTextBoxColumn();
            sun_nm = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            sem = new DataGridViewTextBoxColumn();
            teacher_nm = new DataGridViewTextBoxColumn();
            btn_clr = new Button();
            pnl_btn = new Panel();
            gb_subEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sub).BeginInit();
            pnl_btn.SuspendLayout();
            SuspendLayout();
            // 
            // gb_subEntry
            // 
            gb_subEntry.BackColor = Color.SteelBlue;
            gb_subEntry.Controls.Add(cb_asgTeacher);
            gb_subEntry.Controls.Add(cb_sem);
            gb_subEntry.Controls.Add(cb_course);
            gb_subEntry.Controls.Add(tb_subNm);
            gb_subEntry.Controls.Add(lbl_asgnTeacher);
            gb_subEntry.Controls.Add(lbl_sem);
            gb_subEntry.Controls.Add(lbl_Course);
            gb_subEntry.Controls.Add(lbl_sub_nm);
            gb_subEntry.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_subEntry.ForeColor = Color.White;
            gb_subEntry.Location = new Point(258, 54);
            gb_subEntry.Name = "gb_subEntry";
            gb_subEntry.Size = new Size(409, 286);
            gb_subEntry.TabIndex = 0;
            gb_subEntry.TabStop = false;
            gb_subEntry.Text = "Subject Entry";
            // 
            // cb_asgTeacher
            // 
            cb_asgTeacher.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_asgTeacher.FormattingEnabled = true;
            cb_asgTeacher.Location = new Point(155, 175);
            cb_asgTeacher.Name = "cb_asgTeacher";
            cb_asgTeacher.Size = new Size(178, 25);
            cb_asgTeacher.TabIndex = 7;
            // 
            // cb_sem
            // 
            cb_sem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_sem.FormattingEnabled = true;
            cb_sem.Items.AddRange(new object[] { "4" });
            cb_sem.Location = new Point(155, 128);
            cb_sem.Name = "cb_sem";
            cb_sem.Size = new Size(178, 25);
            cb_sem.TabIndex = 6;
            // 
            // cb_course
            // 
            cb_course.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_course.FormattingEnabled = true;
            cb_course.Items.AddRange(new object[] { "Bsc.IT" });
            cb_course.Location = new Point(155, 83);
            cb_course.Name = "cb_course";
            cb_course.Size = new Size(178, 25);
            cb_course.TabIndex = 5;
            // 
            // tb_subNm
            // 
            tb_subNm.Location = new Point(155, 38);
            tb_subNm.Name = "tb_subNm";
            tb_subNm.Size = new Size(178, 34);
            tb_subNm.TabIndex = 4;
            // 
            // lbl_asgnTeacher
            // 
            lbl_asgnTeacher.AutoSize = true;
            lbl_asgnTeacher.BackColor = Color.SteelBlue;
            lbl_asgnTeacher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_asgnTeacher.ForeColor = Color.White;
            lbl_asgnTeacher.Location = new Point(10, 175);
            lbl_asgnTeacher.Name = "lbl_asgnTeacher";
            lbl_asgnTeacher.Size = new Size(135, 20);
            lbl_asgnTeacher.TabIndex = 3;
            lbl_asgnTeacher.Text = "Assigned Teacher :";
            // 
            // lbl_sem
            // 
            lbl_sem.AutoSize = true;
            lbl_sem.BackColor = Color.SteelBlue;
            lbl_sem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sem.ForeColor = Color.White;
            lbl_sem.Location = new Point(58, 135);
            lbl_sem.Name = "lbl_sem";
            lbl_sem.Size = new Size(79, 20);
            lbl_sem.TabIndex = 2;
            lbl_sem.Text = "Semester :";
            // 
            // lbl_Course
            // 
            lbl_Course.AutoSize = true;
            lbl_Course.BackColor = Color.SteelBlue;
            lbl_Course.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Course.ForeColor = Color.White;
            lbl_Course.Location = new Point(67, 83);
            lbl_Course.Name = "lbl_Course";
            lbl_Course.Size = new Size(64, 20);
            lbl_Course.TabIndex = 1;
            lbl_Course.Text = "Course :";
            // 
            // lbl_sub_nm
            // 
            lbl_sub_nm.AutoSize = true;
            lbl_sub_nm.BackColor = Color.SteelBlue;
            lbl_sub_nm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sub_nm.ForeColor = Color.White;
            lbl_sub_nm.Location = new Point(19, 45);
            lbl_sub_nm.Name = "lbl_sub_nm";
            lbl_sub_nm.Size = new Size(112, 20);
            lbl_sub_nm.TabIndex = 0;
            lbl_sub_nm.Text = "Subject Name :";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.SteelBlue;
            btn_add.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(24, 18);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.SteelBlue;
            btn_delete.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(24, 117);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SteelBlue;
            btn_update.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(24, 65);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 31);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // dgv_sub
            // 
            dgv_sub.AllowUserToAddRows = false;
            dgv_sub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sub.BackgroundColor = Color.AliceBlue;
            dgv_sub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sub.Columns.AddRange(new DataGridViewColumn[] { sub_id, sun_nm, course, sem, teacher_nm });
            dgv_sub.Location = new Point(32, 398);
            dgv_sub.MultiSelect = false;
            dgv_sub.Name = "dgv_sub";
            dgv_sub.RowHeadersWidth = 51;
            dgv_sub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_sub.Size = new Size(1128, 304);
            dgv_sub.TabIndex = 4;
            dgv_sub.CellClick += dgv_sub_CellClick;
            dgv_sub.CellContentClick += dgv_sub_CellContentClick;
            // 
            // sub_id
            // 
            sub_id.HeaderText = "Subject_ID";
            sub_id.MinimumWidth = 6;
            sub_id.Name = "sub_id";
            sub_id.ReadOnly = true;
            sub_id.Visible = false;
            // 
            // sun_nm
            // 
            sun_nm.HeaderText = "Subject_Name";
            sun_nm.MinimumWidth = 6;
            sun_nm.Name = "sun_nm";
            sun_nm.ReadOnly = true;
            // 
            // course
            // 
            course.HeaderText = "Course";
            course.MinimumWidth = 6;
            course.Name = "course";
            course.ReadOnly = true;
            // 
            // sem
            // 
            sem.HeaderText = "Semester";
            sem.MinimumWidth = 6;
            sem.Name = "sem";
            sem.ReadOnly = true;
            // 
            // teacher_nm
            // 
            teacher_nm.HeaderText = "Teacher_Name";
            teacher_nm.MinimumWidth = 6;
            teacher_nm.Name = "teacher_nm";
            teacher_nm.ReadOnly = true;
            // 
            // btn_clr
            // 
            btn_clr.BackColor = Color.SteelBlue;
            btn_clr.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_clr.ForeColor = Color.White;
            btn_clr.Location = new Point(24, 168);
            btn_clr.Name = "btn_clr";
            btn_clr.Size = new Size(94, 29);
            btn_clr.TabIndex = 5;
            btn_clr.Text = "Clear";
            btn_clr.UseVisualStyleBackColor = false;
            btn_clr.Click += btn_clr_Click;
            // 
            // pnl_btn
            // 
            pnl_btn.Controls.Add(btn_add);
            pnl_btn.Controls.Add(btn_clr);
            pnl_btn.Controls.Add(btn_update);
            pnl_btn.Controls.Add(btn_delete);
            pnl_btn.Location = new Point(750, 66);
            pnl_btn.Name = "pnl_btn";
            pnl_btn.Size = new Size(155, 241);
            pnl_btn.TabIndex = 6;
            // 
            // subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1188, 718);
            Controls.Add(pnl_btn);
            Controls.Add(dgv_sub);
            Controls.Add(gb_subEntry);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "subject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Subjects";
            Load += subject_Load;
            gb_subEntry.ResumeLayout(false);
            gb_subEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sub).EndInit();
            pnl_btn.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn sub_id;
        private DataGridViewTextBoxColumn sun_nm;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn sem;
        private DataGridViewTextBoxColumn teacher_nm;
        private Button btn_clr;
        private Panel pnl_btn;
    }
}