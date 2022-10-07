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
    public partial class Form_Square : Form
    {
        public Form_Square()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try{ double side = double.Parse(textBox1.Text);
                if (side <= 0) { MessageBox.Show("Input must be positive"); return; }
            label3.Text = $"Area is: {(double)((int)(Math.Pow(side, 2) * 100)) / 100}  Perimeter is: {side*4}"; }
            catch {
        MessageBox.Show("Enter an input in valid form");
        }
        }
        

        private void Form_Square_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm=new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
