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
            label1 = new Label();
            lnklblsignup = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.BackColor = Color.Transparent;
            lbl_login.FlatStyle = FlatStyle.Flat;
            lbl_login.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.Black;
            lbl_login.Location = new Point(293, 78);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(89, 35);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login";
            // 
            // lbl_nm
            // 
            lbl_nm.AutoSize = true;
            lbl_nm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nm.Location = new Point(146, 141);
            lbl_nm.Name = "lbl_nm";
            lbl_nm.Size = new Size(88, 20);
            lbl_nm.TabIndex = 1;
            lbl_nm.Text = "Username :";
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pwd.Location = new Point(146, 199);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(84, 20);
            lbl_pwd.TabIndex = 2;
            lbl_pwd.Text = "Password :";
            // 
            // tb_nm
            // 
            tb_nm.Location = new Point(233, 141);
            tb_nm.Name = "tb_nm";
            tb_nm.Size = new Size(262, 27);
            tb_nm.TabIndex = 3;
            // 
            // tb_pwd
            // 
            tb_pwd.Location = new Point(233, 194);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PasswordChar = '*';
            tb_pwd.Size = new Size(262, 27);
            tb_pwd.TabIndex = 4;
            tb_pwd.TextChanged += tb_pwd_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(309, 248);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 301);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 6;
            label1.Text = "Don't have an account? ";
            // 
            // lnklblsignup
            // 
            lnklblsignup.AutoSize = true;
            lnklblsignup.Location = new Point(401, 301);
            lnklblsignup.Margin = new Padding(2, 0, 2, 0);
            lnklblsignup.Name = "lnklblsignup";
            lnklblsignup.Size = new Size(59, 20);
            lnklblsignup.TabIndex = 7;
            lnklblsignup.TabStop = true;
            lnklblsignup.Text = "Sign up";
            lnklblsignup.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(695, 399);
            Controls.Add(lnklblsignup);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(tb_pwd);
            Controls.Add(tb_nm);
            Controls.Add(lbl_pwd);
            Controls.Add(lbl_nm);
            Controls.Add(lbl_login);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Student / Teacher";
            Load += LoginForm_Load;
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
        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel lnklblsignup;
    }
}