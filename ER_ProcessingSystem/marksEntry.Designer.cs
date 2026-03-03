namespace ER_ProcessingSystem
{
    partial class marksEntry
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
            gb_selectclass = new GroupBox();
            btn_loadStudent = new Button();
            cmb_sub = new ComboBox();
            cmb_sem = new ComboBox();
            cmb_course = new ComboBox();
            lbl_sub = new Label();
            lbl_sem = new Label();
            lbl_course = new Label();
            dgvMarksEntry = new DataGridView();
            colStudentId = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colInternal = new DataGridViewTextBoxColumn();
            colExternal = new DataGridViewTextBoxColumn();
            btnSaveMarks = new Button();
            gb_selectclass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarksEntry).BeginInit();
            SuspendLayout();
            // 
            // gb_selectclass
            // 
            gb_selectclass.Controls.Add(btn_loadStudent);
            gb_selectclass.Controls.Add(cmb_sub);
            gb_selectclass.Controls.Add(cmb_sem);
            gb_selectclass.Controls.Add(cmb_course);
            gb_selectclass.Controls.Add(lbl_sub);
            gb_selectclass.Controls.Add(lbl_sem);
            gb_selectclass.Controls.Add(lbl_course);
            gb_selectclass.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_selectclass.Location = new Point(30, 26);
            gb_selectclass.Margin = new Padding(4);
            gb_selectclass.Name = "gb_selectclass";
            gb_selectclass.Padding = new Padding(4);
            gb_selectclass.Size = new Size(388, 280);
            gb_selectclass.TabIndex = 0;
            gb_selectclass.TabStop = false;
            gb_selectclass.Text = "Select Class";
            gb_selectclass.Enter += gb_selectclass_Enter;
            // 
            // btn_loadStudent
            // 
            btn_loadStudent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_loadStudent.Location = new Point(125, 225);
            btn_loadStudent.Margin = new Padding(4);
            btn_loadStudent.Name = "btn_loadStudent";
            btn_loadStudent.Size = new Size(184, 36);
            btn_loadStudent.TabIndex = 6;
            btn_loadStudent.Text = "Load Student";
            btn_loadStudent.UseVisualStyleBackColor = true;
            btn_loadStudent.Click += btn_loadStudent_Click;
            // 
            // cmb_sub
            // 
            cmb_sub.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_sub.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_sub.FormattingEnabled = true;
            cmb_sub.Location = new Point(151, 155);
            cmb_sub.Margin = new Padding(4);
            cmb_sub.Name = "cmb_sub";
            cmb_sub.Size = new Size(188, 36);
            cmb_sub.TabIndex = 5;
            // 
            // cmb_sem
            // 
            cmb_sem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_sem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_sem.FormattingEnabled = true;
            cmb_sem.Items.AddRange(new object[] { "4" });
            cmb_sem.Location = new Point(151, 104);
            cmb_sem.Margin = new Padding(4);
            cmb_sem.Name = "cmb_sem";
            cmb_sem.Size = new Size(188, 36);
            cmb_sem.TabIndex = 4;
            // 
            // cmb_course
            // 
            cmb_course.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_course.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_course.FormattingEnabled = true;
            cmb_course.Items.AddRange(new object[] { "Bsc.IT" });
            cmb_course.Location = new Point(151, 52);
            cmb_course.Margin = new Padding(4);
            cmb_course.Name = "cmb_course";
            cmb_course.Size = new Size(188, 36);
            cmb_course.TabIndex = 3;
            // 
            // lbl_sub
            // 
            lbl_sub.AutoSize = true;
            lbl_sub.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sub.Location = new Point(18, 155);
            lbl_sub.Margin = new Padding(4, 0, 4, 0);
            lbl_sub.Name = "lbl_sub";
            lbl_sub.Size = new Size(94, 30);
            lbl_sub.TabIndex = 2;
            lbl_sub.Text = "Subject :";
            // 
            // lbl_sem
            // 
            lbl_sem.AutoSize = true;
            lbl_sem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sem.Location = new Point(0, 104);
            lbl_sem.Margin = new Padding(4, 0, 4, 0);
            lbl_sem.Name = "lbl_sem";
            lbl_sem.Size = new Size(112, 30);
            lbl_sem.TabIndex = 1;
            lbl_sem.Text = "Semester :";
            lbl_sem.Click += lbl_sem_Click;
            // 
            // lbl_course
            // 
            lbl_course.AutoSize = true;
            lbl_course.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_course.Location = new Point(21, 56);
            lbl_course.Margin = new Padding(4, 0, 4, 0);
            lbl_course.Name = "lbl_course";
            lbl_course.Size = new Size(90, 30);
            lbl_course.TabIndex = 0;
            lbl_course.Text = "Course :";
            // 
            // dgvMarksEntry
            // 
            dgvMarksEntry.AllowUserToAddRows = false;
            dgvMarksEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarksEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarksEntry.Columns.AddRange(new DataGridViewColumn[] { colStudentId, colStudentName, colInternal, colExternal });
            dgvMarksEntry.Location = new Point(30, 331);
            dgvMarksEntry.Margin = new Padding(4);
            dgvMarksEntry.Name = "dgvMarksEntry";
            dgvMarksEntry.RowHeadersWidth = 51;
            dgvMarksEntry.Size = new Size(770, 235);
            dgvMarksEntry.TabIndex = 1;
            dgvMarksEntry.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colStudentId
            // 
            colStudentId.HeaderText = "Student ID";
            colStudentId.MinimumWidth = 6;
            colStudentId.Name = "colStudentId";
            colStudentId.ReadOnly = true;
            colStudentId.Visible = false;
            // 
            // colStudentName
            // 
            colStudentName.HeaderText = "Student name";
            colStudentName.MinimumWidth = 6;
            colStudentName.Name = "colStudentName";
            colStudentName.ReadOnly = true;
            // 
            // colInternal
            // 
            colInternal.HeaderText = "Internal Marks";
            colInternal.MinimumWidth = 6;
            colInternal.Name = "colInternal";
            // 
            // colExternal
            // 
            colExternal.HeaderText = "External Marks";
            colExternal.MinimumWidth = 6;
            colExternal.Name = "colExternal";
            // 
            // btnSaveMarks
            // 
            btnSaveMarks.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveMarks.Location = new Point(301, 594);
            btnSaveMarks.Margin = new Padding(4);
            btnSaveMarks.Name = "btnSaveMarks";
            btnSaveMarks.Size = new Size(264, 36);
            btnSaveMarks.TabIndex = 2;
            btnSaveMarks.Text = "Save Marks to Database";
            btnSaveMarks.UseVisualStyleBackColor = true;
            // 
            // marksEntry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 645);
            Controls.Add(btnSaveMarks);
            Controls.Add(dgvMarksEntry);
            Controls.Add(gb_selectclass);
            Margin = new Padding(4);
            Name = "marksEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MraksEntry";
            Load += marksEntry_Load;
            gb_selectclass.ResumeLayout(false);
            gb_selectclass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarksEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_selectclass;
        private Label lbl_course;
        private Label lbl_sub;
        private Label lbl_sem;
        private ComboBox cmb_course;
        private ComboBox cmb_sub;
        private ComboBox cmb_sem;
        private Button btn_loadStudent;
        private DataGridView dgvMarksEntry;
        private Button btnSaveMarks;
        private DataGridViewTextBoxColumn colStudentId;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colInternal;
        private DataGridViewTextBoxColumn colExternal;
    }
}