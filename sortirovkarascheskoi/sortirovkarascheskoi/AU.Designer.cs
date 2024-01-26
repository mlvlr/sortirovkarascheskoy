namespace sortirovkarascheskoi
{
    partial class AU
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
            AuthLogin = new TextBox();
            AuthPwd = new TextBox();
            GoReg = new Button();
            MakeAuth = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // AuthLogin
            // 
            AuthLogin.Location = new Point(12, 53);
            AuthLogin.Name = "AuthLogin";
            AuthLogin.Size = new Size(408, 31);
            AuthLogin.TabIndex = 0;
            // 
            // AuthPwd
            // 
            AuthPwd.Location = new Point(12, 125);
            AuthPwd.Name = "AuthPwd";
            AuthPwd.PasswordChar = '*';
            AuthPwd.Size = new Size(408, 31);
            AuthPwd.TabIndex = 1;
            // 
            // GoReg
            // 
            GoReg.Location = new Point(224, 178);
            GoReg.Name = "GoReg";
            GoReg.Size = new Size(196, 34);
            GoReg.TabIndex = 2;
            GoReg.Text = "Зарегестрироваться";
            GoReg.UseVisualStyleBackColor = true;
            GoReg.Click += GoReg_Click;
            // 
            // MakeAuth
            // 
            MakeAuth.Location = new Point(58, 178);
            MakeAuth.Name = "MakeAuth";
            MakeAuth.Size = new Size(112, 34);
            MakeAuth.TabIndex = 3;
            MakeAuth.Text = "Войти";
            MakeAuth.UseVisualStyleBackColor = true;
            MakeAuth.Click += MakeAuth_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 4;
            label1.Text = "Введите логин:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 94);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 5;
            label2.Text = "Введите пароль:";
            // 
            // AU
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 245);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MakeAuth);
            Controls.Add(GoReg);
            Controls.Add(AuthPwd);
            Controls.Add(AuthLogin);
            Name = "AU";
            Text = "Вход в приложение";
            FormClosed += AU_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthLogin;
        private TextBox AuthPwd;
        private Button GoReg;
        private Button MakeAuth;
        private Label label1;
        private Label label2;
    }
}