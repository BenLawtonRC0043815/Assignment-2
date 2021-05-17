using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // read force and angle from textboxes 
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox2.Text);
                //
                double area = 2.0 * (length * width + length * height + width + height);
                double volume = length * width * height;
                //d
                label1.Text = "surface area;" + area;
                label2.Text = "volume;" + volume;
            }
            catch
            {
                // show error message on screen if fail 
                MessageBox.Show("Uh OH");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // read force and angle from textboxes 
                double radius = double.Parse(textBox1.Text);

                //
                double area = 4.0 * 3.14 * radius * radius; 
                double volume = 
                //d
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;
            }
            catch
            {
                // show error message on screen if fail 
                MessageBox.Show("D'oh!");
            }
        }
    }
}
