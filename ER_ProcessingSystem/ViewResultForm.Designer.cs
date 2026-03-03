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
            lbl_sem = new Label();
            cmb_sem = new ComboBox();
            btnViewResult = new Button();
            pnlReportCard = new Panel();
            txt_sNm = new TextBox();
            lbl_sNm = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvResultGrid = new DataGridView();
            sub_nm = new DataGridViewTextBoxColumn();
            int_mrks = new DataGridViewTextBoxColumn();
            ext_mrks = new DataGridViewTextBoxColumn();
            ttl_marks = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
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
            lbl_sem.Location = new Point(27, 23);
            lbl_sem.Name = "lbl_sem";
            lbl_sem.Size = new Size(87, 19);
            lbl_sem.TabIndex = 0;
            lbl_sem.Text = "Semester :";
            // 
            // cmb_sem
            // 
            cmb_sem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_sem.FormattingEnabled = true;
            cmb_sem.Location = new Point(129, 19);
            cmb_sem.Name = "cmb_sem";
            cmb_sem.Size = new Size(151, 28);
            cmb_sem.TabIndex = 1;
            // 
            // btnViewResult
            // 
            btnViewResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewResult.Location = new Point(579, 18);
            btnViewResult.Name = "btnViewResult";
            btnViewResult.Size = new Size(159, 29);
            btnViewResult.TabIndex = 2;
            btnViewResult.Text = "Show Report Card";
            btnViewResult.UseVisualStyleBackColor = true;
            // 
            // pnlReportCard
            // 
            pnlReportCard.BorderStyle = BorderStyle.FixedSingle;
            pnlReportCard.Controls.Add(txt_sNm);
            pnlReportCard.Controls.Add(lbl_sNm);
            pnlReportCard.Controls.Add(panel1);
            pnlReportCard.Controls.Add(dgvResultGrid);
            pnlReportCard.Location = new Point(41, 73);
            pnlReportCard.Name = "pnlReportCard";
            pnlReportCard.Size = new Size(885, 468);
            pnlReportCard.TabIndex = 3;
            pnlReportCard.Paint += pnlReportCard_Paint;
            // 
            // txt_sNm
            // 
            txt_sNm.Location = new Point(134, 88);
            txt_sNm.Name = "txt_sNm";
            txt_sNm.Size = new Size(145, 27);
            txt_sNm.TabIndex = 3;
            // 
            // lbl_sNm
            // 
            lbl_sNm.AutoSize = true;
            lbl_sNm.Location = new Point(17, 91);
            lbl_sNm.Name = "lbl_sNm";
            lbl_sNm.Size = new Size(111, 20);
            lbl_sNm.TabIndex = 2;
            lbl_sNm.Text = "Student Name :";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 70);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(749, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvResultGrid
            // 
            dgvResultGrid.AllowUserToAddRows = false;
            dgvResultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultGrid.BorderStyle = BorderStyle.None;
            dgvResultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultGrid.Columns.AddRange(new DataGridViewColumn[] { sub_nm, int_mrks, ext_mrks, ttl_marks, grade });
            dgvResultGrid.Location = new Point(17, 261);
            dgvResultGrid.Name = "dgvResultGrid";
            dgvResultGrid.ReadOnly = true;
            dgvResultGrid.RowHeadersWidth = 51;
            dgvResultGrid.Size = new Size(845, 188);
            dgvResultGrid.TabIndex = 0;
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
            // ViewResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 590);
            Controls.Add(pnlReportCard);
            Controls.Add(btnViewResult);
            Controls.Add(cmb_sem);
            Controls.Add(lbl_sem);
            Name = "ViewResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result Sheet";
            pnlReportCard.ResumeLayout(false);
            pnlReportCard.PerformLayout();
            panel1.ResumeLayout(false);
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
    }
}