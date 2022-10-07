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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Square")
            {
                Form_Square frm =new Form_Square();
                frm.ShowDialog();
            }

            if (comboBox1.Text == "Rectangle")
            {
                Form_Rectangle frm = new Form_Rectangle();
                frm.ShowDialog();
            }

            if (comboBox1.Text == "Triangle")
            {
                Form_Triangle frm = new Form_Triangle();
                frm.ShowDialog();
            }

            if (comboBox1.Text == "Circle")
            {
                Form_Circle frm = new Form_Circle();
                frm.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
