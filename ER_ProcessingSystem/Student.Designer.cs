namespace ER_ProcessingSystem
{
    partial class Student
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
            gb_stud = new GroupBox();
            cmb_sem = new ComboBox();
            lbl_sem = new Label();
            cmb_course = new ComboBox();
            lbl_course = new Label();
            tb_email = new TextBox();
            tb_mail = new Label();
            cmb_gender = new ComboBox();
            lbl_gender = new Label();
            tb_snm = new TextBox();
            lbl_snm = new Label();
            tb_sid = new TextBox();
            lbl_sid = new Label();
            dgv_stud = new DataGridView();
            uid = new DataGridViewTextBoxColumn();
            sid = new DataGridViewTextBoxColumn();
            snm = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            sem = new DataGridViewTextBoxColumn();
            btn_update = new Button();
            btn_delete = new Button();
            tb_uid = new TextBox();
            btnCancel = new Button();
            gb_stud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_stud).BeginInit();
            SuspendLayout();
            // 
            // gb_stud
            // 
            gb_stud.BackColor = Color.SteelBlue;
            gb_stud.Controls.Add(cmb_sem);
            gb_stud.Controls.Add(lbl_sem);
            gb_stud.Controls.Add(cmb_course);
            gb_stud.Controls.Add(lbl_course);
            gb_stud.Controls.Add(tb_email);
            gb_stud.Controls.Add(tb_mail);
            gb_stud.Controls.Add(cmb_gender);
            gb_stud.Controls.Add(lbl_gender);
            gb_stud.Controls.Add(tb_snm);
            gb_stud.Controls.Add(lbl_snm);
            gb_stud.Controls.Add(tb_sid);
            gb_stud.Controls.Add(lbl_sid);
            gb_stud.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_stud.ForeColor = Color.White;
            gb_stud.Location = new Point(12, 12);
            gb_stud.Name = "gb_stud";
            gb_stud.Size = new Size(296, 489);
            gb_stud.TabIndex = 0;
            gb_stud.TabStop = false;
            gb_stud.Text = "Student Entry";
            // 
            // cmb_sem
            // 
            cmb_sem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_sem.FormattingEnabled = true;
            cmb_sem.Items.AddRange(new object[] { "4" });
            cmb_sem.Location = new Point(12, 441);
            cmb_sem.Name = "cmb_sem";
            cmb_sem.Size = new Size(225, 31);
            cmb_sem.TabIndex = 11;
            // 
            // lbl_sem
            // 
            lbl_sem.AutoSize = true;
            lbl_sem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sem.Location = new Point(11, 418);
            lbl_sem.Name = "lbl_sem";
            lbl_sem.Size = new Size(73, 20);
            lbl_sem.TabIndex = 10;
            lbl_sem.Text = "Semester:";
            // 
            // cmb_course
            // 
            cmb_course.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_course.FormattingEnabled = true;
            cmb_course.Items.AddRange(new object[] { "Bsc.IT" });
            cmb_course.Location = new Point(15, 366);
            cmb_course.Name = "cmb_course";
            cmb_course.Size = new Size(225, 31);
            cmb_course.TabIndex = 9;
            // 
            // lbl_course
            // 
            lbl_course.AutoSize = true;
            lbl_course.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_course.Location = new Point(11, 343);
            lbl_course.Name = "lbl_course";
            lbl_course.Size = new Size(61, 20);
            lbl_course.TabIndex = 8;
            lbl_course.Text = "Course :";
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_email.Location = new Point(11, 299);
            tb_email.Multiline = true;
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(230, 27);
            tb_email.TabIndex = 7;
            // 
            // tb_mail
            // 
            tb_mail.AutoSize = true;
            tb_mail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_mail.Location = new Point(12, 276);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(53, 20);
            tb_mail.TabIndex = 6;
            tb_mail.Text = "Email :";
            // 
            // cmb_gender
            // 
            cmb_gender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Items.AddRange(new object[] { "Male", "Female" });
            cmb_gender.Location = new Point(11, 224);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(225, 31);
            cmb_gender.TabIndex = 5;
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_gender.Location = new Point(15, 201);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(64, 20);
            lbl_gender.TabIndex = 4;
            lbl_gender.Text = "Gender :";
            // 
            // tb_snm
            // 
            tb_snm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_snm.Location = new Point(12, 149);
            tb_snm.Name = "tb_snm";
            tb_snm.Size = new Size(230, 30);
            tb_snm.TabIndex = 3;
            // 
            // lbl_snm
            // 
            lbl_snm.AutoSize = true;
            lbl_snm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_snm.Location = new Point(12, 126);
            lbl_snm.Name = "lbl_snm";
            lbl_snm.Size = new Size(111, 20);
            lbl_snm.TabIndex = 2;
            lbl_snm.Text = "Student Name :";
            // 
            // tb_sid
            // 
            tb_sid.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_sid.Location = new Point(6, 68);
            tb_sid.Name = "tb_sid";
            tb_sid.Size = new Size(236, 30);
            tb_sid.TabIndex = 1;
            // 
            // lbl_sid
            // 
            lbl_sid.AutoSize = true;
            lbl_sid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sid.Location = new Point(12, 45);
            lbl_sid.Name = "lbl_sid";
            lbl_sid.Size = new Size(86, 20);
            lbl_sid.TabIndex = 0;
            lbl_sid.Text = "Student ID :";
            // 
            // dgv_stud
            // 
            dgv_stud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_stud.BackgroundColor = Color.AliceBlue;
            dgv_stud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_stud.Columns.AddRange(new DataGridViewColumn[] { uid, sid, snm, gender, email, course, sem });
            dgv_stud.Location = new Point(327, 57);
            dgv_stud.MultiSelect = false;
            dgv_stud.Name = "dgv_stud";
            dgv_stud.ReadOnly = true;
            dgv_stud.RowHeadersWidth = 51;
            dgv_stud.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_stud.Size = new Size(812, 523);
            dgv_stud.TabIndex = 1;
            dgv_stud.CellContentClick += dgv_stud_CellContentClick;
            // 
            // uid
            // 
            uid.HeaderText = "User_ID";
            uid.MinimumWidth = 6;
            uid.Name = "uid";
            uid.ReadOnly = true;
            uid.Visible = false;
            // 
            // sid
            // 
            sid.HeaderText = "Student_ID";
            sid.MinimumWidth = 6;
            sid.Name = "sid";
            sid.ReadOnly = true;
            // 
            // snm
            // 
            snm.HeaderText = "Student Name";
            snm.MinimumWidth = 6;
            snm.Name = "snm";
            snm.ReadOnly = true;
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
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
            // btn_update
            // 
            btn_update.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(12, 524);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(12, 568);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // tb_uid
            // 
            tb_uid.Location = new Point(337, 12);
            tb_uid.Name = "tb_uid";
            tb_uid.Size = new Size(124, 27);
            tb_uid.TabIndex = 4;
            tb_uid.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(12, 612);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1151, 672);
            Controls.Add(btnCancel);
            Controls.Add(tb_uid);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(dgv_stud);
            Controls.Add(gb_stud);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Student";
            WindowState = FormWindowState.Maximized;
            Load += Student_Load;
            gb_stud.ResumeLayout(false);
            gb_stud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_stud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_stud;
        private DataGridView dgv_stud;
        private Label lbl_sid;
        private Label lbl_gender;
        private TextBox tb_snm;
        private Label lbl_snm;
        private TextBox tb_sid;
        private ComboBox cmb_sem;
        private Label lbl_sem;
        private ComboBox cmb_course;
        private Label lbl_course;
        private TextBox tb_email;
        private Label tb_mail;
        private ComboBox cmb_gender;
        private Button btn_update;
        private Button btn_delete;
        private DataGridViewTextBoxColumn uid;
        private DataGridViewTextBoxColumn sid;
        private DataGridViewTextBoxColumn snm;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn sem;
        private TextBox tb_uid;
        private Button btnCancel;
    }
}