using Lab2;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1._1
{
    public partial class Form1 : Form
    {
        private Shape shape1;
        private Shape shape2;

        public Form1()
        {
            InitializeComponent();
        }

        private void RedrawShapes()
        {
            pictureBox1.Refresh();

            if (shape1 != null)
                shape1.Draw(pictureBox1, Color.Blue);

            if (shape2 != null)
                shape2.Draw(pictureBox1, Color.Red);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x;
            float y;
            float width;
            float height;

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Оберіть фігуру");
                return;
            }

            if (!float.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Помилка");
                return;
            }

            if (!float.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Помилка");
                return;
            }

            if (!float.TryParse(textBox3.Text, out width))
            {
                MessageBox.Show("Помилка");
                return;
            }

            if (!float.TryParse(textBox4.Text, out height))
            {
                MessageBox.Show("Помилка");
                return;
            }

            pictureBox1.Refresh();

            Shape shape;

            switch (comboBox1.Text)
            {
                case "П'ятикутник":
                    shape = new Pentagon(x, y, width, height);
                    break;

                case "Еліпс":
                    shape = new Ellipse(x, y, width, height);
                    break;

                default:
                    return;
            }

            shape.Draw(pictureBox1, Color.Blue);

            MessageBox.Show(
                "Площа = " +
                shape.Area().ToString("F2"));
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shape1 = new Ellipse(50, 50, 120, 80);
            shape2 = new Pentagon(220, 50, 100, 100);

            RedrawShapes();

            shape1++;
            shape2--;

            RedrawShapes();

            float sum = shape1 + shape2;
            float diff = shape1 - shape2;

            string compare;
            if (shape1 > shape2)
                compare = "Shape1 > Shape2";
            else if (shape1 < shape2)
                compare = "Shape1 < Shape2";
            else
                compare = "Shape1 = Shape2";

            MessageBox.Show(
                "Після операцій ++ і -- фігури переміщені.\n\n" +
                "S1 + S2 = " + sum.ToString("F2") + "\n" +
                "S1 - S2 = " + diff.ToString("F2") + "\n" +
                compare);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (shape1 == null || shape2 == null)
            {
                MessageBox.Show("Сначала создайте фигуры (button1)");
                return;
            }

            float sum = shape1 + shape2;
            float diff = shape1 - shape2;

            string result = "";

            if (shape1 > shape2)
                result = "Shape1 > Shape2";
            else if (shape1 < shape2)
                result = "Shape1 < Shape2";
            else
                result = "Shape1 = Shape2";

            MessageBox.Show(
                "S1 + S2 = " + sum.ToString("F2") + "\n" +
                "S1 - S2 = " + diff.ToString("F2") + "\n" +
                result
            );
        }
    }
}