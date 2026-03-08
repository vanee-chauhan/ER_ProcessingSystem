namespace ER_ProcessingSystem
{
    partial class ViewResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewResultForm));
            lbl_sem = new Label();
            cmb_sem = new ComboBox();
            btnViewResult = new Button();
            pnlReportCard = new Panel();
            tb_sgpa = new TextBox();
            lbl_sgpa = new Label();
            tb_fgrd = new TextBox();
            tb_total = new TextBox();
            lbl_grade = new Label();
            lblGrandTotal = new Label();
            tb_sem = new TextBox();
            lblSem = new Label();
            tb_cs = new TextBox();
            lbl_course = new Label();
            txt_sNm = new TextBox();
            lbl_sNm = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvResultGrid = new DataGridView();
            sub_nm = new DataGridViewTextBoxColumn();
            int_mrks = new DataGridViewTextBoxColumn();
            ext_mrks = new DataGridViewTextBoxColumn();
            ttl_marks = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            lblCs = new Label();
            cmb_cs = new ComboBox();
            pnlReportCard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultGrid).BeginInit();
            SuspendLayout();
            // 
            // lbl_sem
            // 
            lbl_sem.AutoSize = true;
            lbl_sem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sem.Location = new Point(12, 23);
            lbl_sem.Name = "lbl_sem";
            lbl_sem.Size = new Size(87, 19);
            lbl_sem.TabIndex = 0;
            lbl_sem.Text = "Semester :";
            // 
            // cmb_sem
            // 
            cmb_sem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_sem.FormattingEnabled = true;
            cmb_sem.Items.AddRange(new object[] { "4" });
            cmb_sem.Location = new Point(105, 19);
            cmb_sem.Name = "cmb_sem";
            cmb_sem.Size = new Size(151, 28);
            cmb_sem.TabIndex = 1;
            // 
            // btnViewResult
            // 
            btnViewResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewResult.ForeColor = Color.Black;
            btnViewResult.Location = new Point(745, 18);
            btnViewResult.Name = "btnViewResult";
            btnViewResult.Size = new Size(159, 29);
            btnViewResult.TabIndex = 2;
            btnViewResult.Text = "Show Report Card";
            btnViewResult.UseVisualStyleBackColor = true;
            btnViewResult.Click += btnViewResult_Click;
            // 
            // pnlReportCard
            // 
            pnlReportCard.BackColor = Color.White;
            pnlReportCard.BorderStyle = BorderStyle.FixedSingle;
            pnlReportCard.Controls.Add(tb_sgpa);
            pnlReportCard.Controls.Add(lbl_sgpa);
            pnlReportCard.Controls.Add(tb_fgrd);
            pnlReportCard.Controls.Add(tb_total);
            pnlReportCard.Controls.Add(lbl_grade);
            pnlReportCard.Controls.Add(lblGrandTotal);
            pnlReportCard.Controls.Add(tb_sem);
            pnlReportCard.Controls.Add(lblSem);
            pnlReportCard.Controls.Add(tb_cs);
            pnlReportCard.Controls.Add(lbl_course);
            pnlReportCard.Controls.Add(txt_sNm);
            pnlReportCard.Controls.Add(lbl_sNm);
            pnlReportCard.Controls.Add(panel1);
            pnlReportCard.Controls.Add(dgvResultGrid);
            pnlReportCard.Location = new Point(41, 73);
            pnlReportCard.Name = "pnlReportCard";
            pnlReportCard.Size = new Size(885, 577);
            pnlReportCard.TabIndex = 3;
            pnlReportCard.Paint += pnlReportCard_Paint;
            // 
            // tb_sgpa
            // 
            tb_sgpa.Location = new Point(368, 521);
            tb_sgpa.Name = "tb_sgpa";
            tb_sgpa.Size = new Size(145, 27);
            tb_sgpa.TabIndex = 13;
            // 
            // lbl_sgpa
            // 
            lbl_sgpa.AutoSize = true;
            lbl_sgpa.Location = new Point(302, 521);
            lbl_sgpa.Name = "lbl_sgpa";
            lbl_sgpa.Size = new Size(51, 20);
            lbl_sgpa.TabIndex = 12;
            lbl_sgpa.Text = "SGPA :";
            // 
            // tb_fgrd
            // 
            tb_fgrd.Location = new Point(368, 478);
            tb_fgrd.Name = "tb_fgrd";
            tb_fgrd.Size = new Size(145, 27);
            tb_fgrd.TabIndex = 11;
            // 
            // tb_total
            // 
            tb_total.Location = new Point(368, 435);
            tb_total.Name = "tb_total";
            tb_total.Size = new Size(145, 27);
            tb_total.TabIndex = 10;
            // 
            // lbl_grade
            // 
            lbl_grade.AutoSize = true;
            lbl_grade.Location = new Point(300, 485);
            lbl_grade.Name = "lbl_grade";
            lbl_grade.Size = new Size(56, 20);
            lbl_grade.TabIndex = 9;
            lbl_grade.Text = "Grade :";
            lbl_grade.Click += lbl_grade_Click;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(307, 442);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(49, 20);
            lblGrandTotal.TabIndex = 8;
            lblGrandTotal.Text = "Total :";
            // 
            // tb_sem
            // 
            tb_sem.Location = new Point(717, 128);
            tb_sem.Name = "tb_sem";
            tb_sem.Size = new Size(145, 27);
            tb_sem.TabIndex = 7;
            // 
            // lblSem
            // 
            lblSem.AutoSize = true;
            lblSem.Location = new Point(620, 131);
            lblSem.Name = "lblSem";
            lblSem.Size = new Size(77, 20);
            lblSem.TabIndex = 6;
            lblSem.Text = "Semester :";
            // 
            // tb_cs
            // 
            tb_cs.Location = new Point(717, 92);
            tb_cs.Name = "tb_cs";
            tb_cs.Size = new Size(145, 27);
            tb_cs.TabIndex = 5;
            // 
            // lbl_course
            // 
            lbl_course.AutoSize = true;
            lbl_course.Location = new Point(636, 95);
            lbl_course.Name = "lbl_course";
            lbl_course.Size = new Size(61, 20);
            lbl_course.TabIndex = 4;
            lbl_course.Text = "Course :";
            // 
            // txt_sNm
            // 
            txt_sNm.Location = new Point(123, 92);
            txt_sNm.Name = "txt_sNm";
            txt_sNm.Size = new Size(354, 27);
            txt_sNm.TabIndex = 3;
            // 
            // lbl_sNm
            // 
            lbl_sNm.AutoSize = true;
            lbl_sNm.Location = new Point(6, 95);
            lbl_sNm.Name = "lbl_sNm";
            lbl_sNm.Size = new Size(111, 20);
            lbl_sNm.TabIndex = 2;
            lbl_sNm.Text = "Student Name :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 79);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 23);
            label1.Name = "label1";
            label1.Size = new Size(414, 32);
            label1.TabIndex = 2;
            label1.Text = "VNSGU DEPARTMENT OF ICT";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(753, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvResultGrid
            // 
            dgvResultGrid.AllowUserToAddRows = false;
            dgvResultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultGrid.BackgroundColor = Color.White;
            dgvResultGrid.BorderStyle = BorderStyle.None;
            dgvResultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultGrid.Columns.AddRange(new DataGridViewColumn[] { sub_nm, int_mrks, ext_mrks, ttl_marks, grade });
            dgvResultGrid.Location = new Point(17, 173);
            dgvResultGrid.Name = "dgvResultGrid";
            dgvResultGrid.ReadOnly = true;
            dgvResultGrid.RowHeadersWidth = 51;
            dgvResultGrid.Size = new Size(845, 245);
            dgvResultGrid.TabIndex = 0;
            dgvResultGrid.CellContentClick += dgvResultGrid_CellContentClick;
            // 
            // sub_nm
            // 
            sub_nm.HeaderText = "Subject Name";
            sub_nm.MinimumWidth = 6;
            sub_nm.Name = "sub_nm";
            sub_nm.ReadOnly = true;
            // 
            // int_mrks
            // 
            int_mrks.HeaderText = "Internal Marks";
            int_mrks.MinimumWidth = 6;
            int_mrks.Name = "int_mrks";
            int_mrks.ReadOnly = true;
            // 
            // ext_mrks
            // 
            ext_mrks.HeaderText = "External Marks";
            ext_mrks.MinimumWidth = 6;
            ext_mrks.Name = "ext_mrks";
            ext_mrks.ReadOnly = true;
            // 
            // ttl_marks
            // 
            ttl_marks.HeaderText = "Total Marks";
            ttl_marks.MinimumWidth = 6;
            ttl_marks.Name = "ttl_marks";
            ttl_marks.ReadOnly = true;
            // 
            // grade
            // 
            grade.HeaderText = "Grade";
            grade.MinimumWidth = 6;
            grade.Name = "grade";
            grade.ReadOnly = true;
            // 
            // lblCs
            // 
            lblCs.AutoSize = true;
            lblCs.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCs.Location = new Point(302, 23);
            lblCs.Name = "lblCs";
            lblCs.Size = new Size(72, 19);
            lblCs.TabIndex = 4;
            lblCs.Text = "Course :";
            // 
            // cmb_cs
            // 
            cmb_cs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_cs.FormattingEnabled = true;
            cmb_cs.Items.AddRange(new object[] { "Bsc.IT" });
            cmb_cs.Location = new Point(404, 19);
            cmb_cs.Name = "cmb_cs";
            cmb_cs.Size = new Size(151, 28);
            cmb_cs.TabIndex = 5;
            // 
            // ViewResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(970, 679);
            Controls.Add(cmb_cs);
            Controls.Add(lblCs);
            Controls.Add(pnlReportCard);
            Controls.Add(btnViewResult);
            Controls.Add(cmb_sem);
            Controls.Add(lbl_sem);
            Name = "ViewResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result Sheet";
            WindowState = FormWindowState.Maximized;
            Load += ViewResultForm_Load;
            pnlReportCard.ResumeLayout(false);
            pnlReportCard.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sem;
        private ComboBox cmb_sem;
        private Button btnViewResult;
        private Panel pnlReportCard;
        private DataGridView dgvResultGrid;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txt_sNm;
        private Label lbl_sNm;
        private DataGridViewTextBoxColumn sub_nm;
        private DataGridViewTextBoxColumn int_mrks;
        private DataGridViewTextBoxColumn ext_mrks;
        private DataGridViewTextBoxColumn ttl_marks;
        private DataGridViewTextBoxColumn grade;
        private TextBox tb_cs;
        private Label lbl_course;
        private Label lblCs;
        private TextBox tb_sem;
        private Label lblSem;
        private ComboBox cmb_cs;
        private TextBox tb_fgrd;
        private TextBox tb_total;
        private Label lbl_grade;
        private Label lblGrandTotal;
        private TextBox tb_sgpa;
        private Label lbl_sgpa;
        private Label label1;
    }
}