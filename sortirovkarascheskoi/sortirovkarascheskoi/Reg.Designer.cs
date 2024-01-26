namespace sortirovkarascheskoi
{
    partial class Reg
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
            RegLogin = new TextBox();
            RegPwd = new TextBox();
            RegPwd2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // RegLogin
            // 
            RegLogin.Location = new Point(25, 70);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(487, 31);
            RegLogin.TabIndex = 0;
            // 
            // RegPwd
            // 
            RegPwd.Location = new Point(24, 132);
            RegPwd.Name = "RegPwd";
            RegPwd.Size = new Size(487, 31);
            RegPwd.TabIndex = 1;
            // 
            // RegPwd2
            // 
            RegPwd2.Location = new Point(24, 195);
            RegPwd2.Name = "RegPwd2";
            RegPwd2.Size = new Size(487, 31);
            RegPwd2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(168, 243);
            button1.Name = "button1";
            button1.Size = new Size(343, 34);
            button1.TabIndex = 3;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 4;
            label1.Text = "Придумайте логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 104);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 5;
            label2.Text = "Придумайте пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 166);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 6;
            label3.Text = "Повторите пароль:";
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 289);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(RegPwd2);
            Controls.Add(RegPwd);
            Controls.Add(RegLogin);
            Name = "Reg";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegLogin;
        private TextBox RegPwd;
        private TextBox RegPwd2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}