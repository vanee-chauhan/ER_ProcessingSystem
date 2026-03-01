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
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(386, 99);
            lbl_login.Margin = new Padding(4, 0, 4, 0);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(101, 41);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login";
            // 
            // lbl_nm
            // 
            lbl_nm.AutoSize = true;
            lbl_nm.Location = new Point(183, 176);
            lbl_nm.Margin = new Padding(4, 0, 4, 0);
            lbl_nm.Name = "lbl_nm";
            lbl_nm.Size = new Size(100, 25);
            lbl_nm.TabIndex = 1;
            lbl_nm.Text = "Username :";
            // 
            // lbl_pwd
            // 
            lbl_pwd.AutoSize = true;
            lbl_pwd.Location = new Point(183, 249);
            lbl_pwd.Margin = new Padding(4, 0, 4, 0);
            lbl_pwd.Name = "lbl_pwd";
            lbl_pwd.Size = new Size(96, 25);
            lbl_pwd.TabIndex = 2;
            lbl_pwd.Text = "Password :";
            // 
            // tb_nm
            // 
            tb_nm.Location = new Point(291, 176);
            tb_nm.Margin = new Padding(4);
            tb_nm.Name = "tb_nm";
            tb_nm.Size = new Size(326, 31);
            tb_nm.TabIndex = 3;
            // 
            // tb_pwd
            // 
            tb_pwd.Location = new Point(291, 243);
            tb_pwd.Margin = new Padding(4);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PasswordChar = '*';
            tb_pwd.Size = new Size(326, 31);
            tb_pwd.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(386, 310);
            btn_login.Margin = new Padding(4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(118, 36);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 376);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 6;
            label1.Text = "Don't have an account? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(501, 376);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 499);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(tb_pwd);
            Controls.Add(tb_nm);
            Controls.Add(lbl_pwd);
            Controls.Add(lbl_nm);
            Controls.Add(lbl_login);
            Margin = new Padding(4);
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
        private Label label1;
        private LinkLabel linkLabel1;
    }
}