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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dgvResultGrid = new DataGridView();
            sub_nm = new DataGridViewTextBoxColumn();
            int_mrks = new DataGridViewTextBoxColumn();
            ext_mrks = new DataGridViewTextBoxColumn();
            pnlReportCard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultGrid).BeginInit();
            SuspendLayout();
            // 
            // lbl_sem
            // 
            lbl_sem.AutoSize = true;
            lbl_sem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sem.Location = new Point(34, 29);
            lbl_sem.Margin = new Padding(4, 0, 4, 0);
            lbl_sem.Name = "lbl_sem";
            lbl_sem.Size = new Size(104, 24);
            lbl_sem.TabIndex = 0;
            lbl_sem.Text = "Semester :";
            // 
            // cmb_sem
            // 
            cmb_sem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_sem.FormattingEnabled = true;
            cmb_sem.Location = new Point(161, 24);
            cmb_sem.Margin = new Padding(4, 4, 4, 4);
            cmb_sem.Name = "cmb_sem";
            cmb_sem.Size = new Size(188, 33);
            cmb_sem.TabIndex = 1;
            // 
            // btnViewResult
            // 
            btnViewResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewResult.Location = new Point(724, 22);
            btnViewResult.Margin = new Padding(4, 4, 4, 4);
            btnViewResult.Name = "btnViewResult";
            btnViewResult.Size = new Size(199, 36);
            btnViewResult.TabIndex = 2;
            btnViewResult.Text = "Show Report Card";
            btnViewResult.UseVisualStyleBackColor = true;
            // 
            // pnlReportCard
            // 
            pnlReportCard.BorderStyle = BorderStyle.FixedSingle;
            pnlReportCard.Controls.Add(panel1);
            pnlReportCard.Controls.Add(dgvResultGrid);
            pnlReportCard.Location = new Point(51, 91);
            pnlReportCard.Margin = new Padding(4, 4, 4, 4);
            pnlReportCard.Name = "pnlReportCard";
            pnlReportCard.Size = new Size(1106, 584);
            pnlReportCard.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 88);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 78);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvResultGrid
            // 
            dgvResultGrid.AllowUserToAddRows = false;
            dgvResultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultGrid.BorderStyle = BorderStyle.None;
            dgvResultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultGrid.Columns.AddRange(new DataGridViewColumn[] { sub_nm, int_mrks, ext_mrks });
            dgvResultGrid.Location = new Point(25, 330);
            dgvResultGrid.Margin = new Padding(4, 4, 4, 4);
            dgvResultGrid.Name = "dgvResultGrid";
            dgvResultGrid.ReadOnly = true;
            dgvResultGrid.RowHeadersWidth = 51;
            dgvResultGrid.Size = new Size(1056, 235);
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
            // ViewResultForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1212, 738);
            Controls.Add(pnlReportCard);
            Controls.Add(btnViewResult);
            Controls.Add(cmb_sem);
            Controls.Add(lbl_sem);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ViewResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result Sheet";
            pnlReportCard.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn sub_nm;
        private DataGridViewTextBoxColumn int_mrks;
        private DataGridViewTextBoxColumn ext_mrks;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}