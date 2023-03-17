using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW12
{
    public partial class a_charting_application : Form
    {
        public a_charting_application()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = Brushes.Blue;
            Font font = new Font("Arial", 10);

            int[] data = { 10, 20, 30, 40, 50 };
            string[] labels = { "Елемент 1", "Елемент 2", "Елемент 3", "Елемент 4", "Елемент 5" };
            int x = 50;
            int y = 50;
            int width = 200;
            int height = 200;
            int total = data.Sum();

            for (int i = 0; i < data.Length; i++)
            {
                int value = data[i];
                float sweepAngle = (float)value / total * 360;
                g.FillPie(brush, x, y, width, height, i * 72, sweepAngle);
                g.DrawPie(pen, x, y, width, height, i * 72, sweepAngle);
                g.DrawString(labels[i], font, Brushes.Black, x + width + 20, y + i * 20);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = Brushes.Blue;
            Font font = new Font("Arial", 10);

            int[] data = { 10, 20, 30 };
            string[] labels = { "Елемент 1", "Елемент 2", "Елемент 3" };
            int x = 50;
            int y = 50;
            int width = 200;
            int height = 200;
            int total = data.Sum();

            for (int i = 0; i < data.Length; i++)
            {
                int value = data[i];
                int angle = 120 / (data.Length - 1) * i;
                int x1 = x + (int)(width / 2 * Math.Cos(angle * Math.PI / 180));
                int y1 = y + (int)(height / 2 * Math.Sin(angle * Math.PI / 180));
                int x2 = x + (int)(width / 2 * Math.Cos((angle + 120) * Math.PI / 180));
                int y2 = y + (int)(height / 2 * Math.Sin((angle + 120) * Math.PI / 180));

                Point[] trianglePoints = { new Point(x + width / 2, y + height / 2), new Point(x1, y1), new Point(x2, y2) };

                float percent = (float)value / total;
                string label = string.Format("{0} ({1:P})", labels[i], percent);
                g.DrawPolygon(pen, trianglePoints);
                g.FillPolygon(brush, trianglePoints);
                g.DrawString(label, font, Brushes.Black, x1, y1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Дані для діаграми
            int[] data = { 20, 30, 40, 50 };
            string[] labels = { "A", "B", "C", "D" };

            // Визначаємо розміри діаграми
            int size = 200;
            int x = 50;
            int y = 50;

            // Визначаємо область діаграми
            Rectangle rect = new Rectangle(x, y, size, size);

            // Обчислюємо кут кожного сектора діаграми
            float angleStep = 360f / data.Length;

            // Визначаємо об'єкт Graphics для малювання
            Graphics g = panel1.CreateGraphics();

            // Заповнюємо діаграму білим кольором
            g.FillRectangle(Brushes.White, rect);

            // Малюємо кожен сектор діаграми
            float startAngle = 0f;
            for (int i = 0; i < data.Length; i++)
            {
                float sweepAngle = data[i] * angleStep;
                g.FillPie(new SolidBrush(GetRandomColor()), rect, startAngle, sweepAngle);
                startAngle += sweepAngle;
            }

            // Малюємо мітки на діаграмі
            float labelAngle = 0f;
            float labelRadius = size / 2f + 10f;
            PointF center = new PointF(x + size / 2f, y + size / 2f);
            for (int i = 0; i < labels.Length; i++)
            {
                PointF labelPos = new PointF(center.X + labelRadius * (float)Math.Cos(labelAngle * Math.PI / 180f),
                                             center.Y + labelRadius * (float)Math.Sin(labelAngle * Math.PI / 180f));
                SizeF labelSize = g.MeasureString(labels[i], this.Font);
                labelPos.X -= labelSize.Width / 2f;
                labelPos.Y -= labelSize.Height / 2f;
                g.DrawString(labels[i], this.Font, Brushes.Black, labelPos);
                labelAngle += angleStep;
            }

            // Звільняємо ресурси
            g.Dispose();
        }

        // Генерує випадковий колір
        private Color GetRandomColor()
        {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}
