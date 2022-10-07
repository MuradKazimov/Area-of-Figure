using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areaoffigure
{
    public partial class Form_Rectangle : Form
    {
        public Form_Rectangle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
                if (a <= 0 || b <= 0) { MessageBox.Show("Input must be positive"); return; }
                label4.Text = $"Area: {(float)(int)(a * b) * 100 / 100}   Perimeter: {2*(a+b)}"; }
            catch {
        MessageBox.Show("Enter an input in valid form");
        }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
    
}
