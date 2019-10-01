using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
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

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius;

            radius = double.Parse(textBox2.Text);

            double circumference = 2.0 * radius * Math.PI;
            label8.Text = "=" + circumference;

            double area = Math.PI * radius * radius;
            label6.Text = "=" + area;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
