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
            pnlReportCard.Location = new Point(94, 94);
            pnlReportCard.Name = "pnlReportCard";
            pnlReportCard.Size = new Size(501, 273);
            pnlReportCard.TabIndex = 3;
            // 
            // ViewResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReportCard);
            Controls.Add(btnViewResult);
            Controls.Add(cmb_sem);
            Controls.Add(lbl_sem);
            Name = "ViewResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result Sheet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sem;
        private ComboBox cmb_sem;
        private Button btnViewResult;
        private Panel pnlReportCard;
    }
}