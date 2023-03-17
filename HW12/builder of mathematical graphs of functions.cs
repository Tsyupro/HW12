using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW12
{
    public partial class builder_of_mathematical_graphs_of_functions : Form
    {
        

        public builder_of_mathematical_graphs_of_functions()
        {
            InitializeComponent();
        }

        private void pbGraph_Paint(object sender, PaintEventArgs e)
        {
            
               
        }
        

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                double minX = double.Parse(txtMinX.Text);
                double maxX = double.Parse(txtMaxX.Text);
                double minY = double.Parse(txtMinY.Text);
                double maxY = double.Parse(txtMaxY.Text);

                // Очищаем график
                pbGraph.Refresh();

                // Получаем объект Graphics для рисования на PictureBox
                Graphics g = pbGraph.CreateGraphics();

                // Вычисляем шаг по оси X
                double stepX = pbGraph.Width / (maxX - minX);

                // Вычисляем шаг по оси Y
                double stepY = pbGraph.Height / (maxY - minY);

                // Создаем объект Pen для рисования графика
                Pen pen = new Pen(Color.Blue, 2);

                // Рисуем оси координат
                g.DrawLine(Pens.Black, 0, pbGraph.Height / 2, pbGraph.Width, pbGraph.Height / 2);
                g.DrawLine(Pens.Black, pbGraph.Width / 2, 0, pbGraph.Width / 2, pbGraph.Height);

                // Рисуем график функции
                for (double x = minX; x <= maxX; x += 0.1)
                {
                    double y = Math.Sin(x);
                    int screenX = (int)((x - minX) * stepX);
                    int screenY = (int)(pbGraph.Height / 2 - y * stepY);
                    g.DrawRectangle(pen, screenX, screenY, 1, 1);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения!");
            }
        }
    }
}
