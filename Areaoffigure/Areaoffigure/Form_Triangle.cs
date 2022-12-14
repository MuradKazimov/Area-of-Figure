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
    public partial class Form_Triangle : Form
    {
        public Form_Triangle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try { double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
                if (a <= 0 || b <= 0 || c <= 0) { MessageBox.Show("Input must be positive"); return; }
                if (a + b < c || a + c < b || b + c < a)
            {
                MessageBox.Show("Triangle with such sides doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double p = (a + b + c) / 2;
            double area = (double)(int)(Math.Sqrt(p * (p - a) * (p - b) * (p-c))) * 100 / 100;

            label5.Text = $"Area: {area}  Perimeter: {p*2}"; }
            
            catch {
        MessageBox.Show("Enter an input in valid form");
        }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Triangle_Load(object sender, EventArgs e)
        {

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
