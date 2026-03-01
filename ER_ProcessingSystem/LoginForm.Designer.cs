namespace ER_ProcessingSystem
{
    partial class LoginForm
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
            lbl_login = new Label();
            lbl_nm = new Label();
            lbl_pwd = new Label();
            tb_nm = new TextBox();
            tb_pwd = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(309, 46);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(95, 41);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login";
            // 
            // lbl_nm
            // 
            lbl_nm.AutoSize = true;
            lbl_nm.Location = new Point(122, 141);
            lbl_nm.Name = "lbl_nm";
            lbl_nm.Size = new Size(82, 20);
            lbl_nm.TabIndex = 1;
            lbl_nm.Text = "Username :";
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Location = new Point(122, 238);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(77, 20);
            lbl_pwd.TabIndex = 2;
            lbl_pwd.Text = "Password :";
            // 
            // tb_nm
            // 
            tb_nm.Location = new Point(233, 141);
            tb_nm.Name = "tb_nm";
            tb_nm.Size = new Size(125, 27);
            tb_nm.TabIndex = 3;
            // 
            // tb_pwd
            // 
            tb_pwd.Location = new Point(233, 235);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PasswordChar = '*';
            tb_pwd.Size = new Size(125, 27);
            tb_pwd.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(293, 333);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 484);
            Controls.Add(btn_login);
            Controls.Add(tb_pwd);
            Controls.Add(tb_nm);
            Controls.Add(lbl_pwd);
            Controls.Add(lbl_nm);
            Controls.Add(lbl_login);
            Name = "LoginForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_login;
        private Label lbl_nm;
        private Label lbl_pwd;
        private TextBox tb_nm;
        private TextBox tb_pwd;
        private Button btn_login;
    }
}