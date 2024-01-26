using System.Diagnostics.Metrics;
using System;
using System.Xml;
namespace sortirovkarascheskoi
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer timer;
        private int currentStateIndex;
        private Sorted sorter;
        public Form1()
        {
            InitializeComponent();
            AU auth_form = new AU();
            auth_form.ShowDialog();

            
            // Инициализация таймера
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Настройте по необходимости
            timer.Tick += Timer_Tick;

        }

        private void SortButton_Click(object sender, EventArgs e)
        {

            string input = Input.Text;
            sorter = new Sorted();
            sorter.Sort(input);

            currentStateIndex = 0;
            DrawHistogram(currentStateIndex);
            timer.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (sorter != null && currentStateIndex < sorter.States.Count)
            {
                DrawHistogram(e.Graphics, sorter.States[currentStateIndex]);
            }
        }

        private void DrawHistogram(Graphics g, int[] data)
        {
            if (data == null || data.Length == 0) return;

            int minValue = data.Min();
            int maxValue = data.Max();

            float barWidth = pictureBox1.Width / (float)data.Length;
            float barActualWidth = barWidth * 0.8f;
            float barSpacing = barWidth * 0.2f;

            float zeroLine = pictureBox1.Height / 2.0f;

            // Уменьшаем масштаб высоты столбцов
            float heightScaleFactor = 0.7f; // Уменьшаем высоту до 70% от возможного максимума
            float scale = zeroLine * heightScaleFactor / Math.Max(Math.Abs(maxValue), Math.Abs(minValue));

            g.DrawLine(Pens.Black, 0, zeroLine, pictureBox1.Width, zeroLine);

            for (int i = 0; i < data.Length; i++)
            {
                float barHeight = Math.Abs(data[i]) * scale;
                Brush brush = data[i] >= 0 ? Brushes.Blue : Brushes.Red;
                float y = data[i] >= 0 ? zeroLine - barHeight : zeroLine;

                // Отрисовка столбца с учетом промежутка
                float barX = i * barWidth + barSpacing / 2;
                g.FillRectangle(brush, barX, y, barActualWidth, barHeight);

                // Отрисовка значения столбца
                string text = data[i].ToString();
                SizeF textSize = g.MeasureString(text, SystemFonts.DefaultFont);
                float textX = i * barWidth + (barWidth - textSize.Width) / 2;
                float textY = data[i] >= 0 ? y - textSize.Height - 5 : y + barHeight + 5;
                g.DrawString(text, SystemFonts.DefaultFont, Brushes.Black, textX, textY);
            }
        }

        private void DrawHistogram(int index)
        {
            if (index < sorter.States.Count)
            {
                using (var g = pictureBox1.CreateGraphics())
                {
                    g.Clear(pictureBox1.BackColor); // Очистить предыдущий график
                    DrawHistogram(g, sorter.States[index]);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentStateIndex++;
            if (currentStateIndex < sorter.States.Count)
            {
                DrawHistogram(currentStateIndex);
            }
            else
            {
                timer.Stop();
            }
        }

    }
}
