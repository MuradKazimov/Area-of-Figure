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
            label3.Text = $"Area is: {(double)((int)(Math.Pow(side, 2) * 100)) / 100}  Perimeter is: {side*4}"; }
            catch {
        Messagebox.Show("Enter an input in valid form")
        }
        }
        

        private void Form_Square_Load(object sender, EventArgs e)
        {

        }
    }
}
