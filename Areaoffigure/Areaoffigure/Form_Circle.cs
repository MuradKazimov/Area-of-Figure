using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areaoffigure
{
    public partial class Form_Circle : Form
    {
        public Form_Circle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);
            double area = (double)((int)(Math.Pow(radius, 2) * Math.PI) * 100) /100;
            double perimeter = (double)((int)(Math.PI * 2 * radius ) * 100) / 100;
            label3.Text = $"Area is: {area}  Perimeter is: {perimeter}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
