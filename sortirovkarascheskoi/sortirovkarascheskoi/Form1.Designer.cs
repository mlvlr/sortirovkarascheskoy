namespace sortirovkarascheskoi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NumbersTextBox = new Button();
            Input = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NumbersTextBox
            // 
            NumbersTextBox.Location = new Point(211, 525);
            NumbersTextBox.Margin = new Padding(2);
            NumbersTextBox.Name = "NumbersTextBox";
            NumbersTextBox.Size = new Size(188, 41);
            NumbersTextBox.TabIndex = 0;
            NumbersTextBox.Text = "Сортировать";
            NumbersTextBox.UseVisualStyleBackColor = true;
            NumbersTextBox.Click += SortButton_Click;
            // 
            // Input
            // 
            Input.Location = new Point(11, 47);
            Input.Margin = new Padding(2);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.Size = new Size(557, 21);
            Input.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите числа через пробел";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 72);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(553, 449);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 577);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Input);
            Controls.Add(NumbersTextBox);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Сортировщик";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NumbersTextBox;
        private TextBox Input;
        private Label label1;
        private PictureBox pictureBox1;
    }
}