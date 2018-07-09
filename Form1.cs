using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bjarzynka
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Visual C#";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "lorem ipsum";
     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.textBox3.Text);
            int b = Convert.ToInt32(this.textBox4.Text);
            int c = a / b;
            textBox5.Text = c.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.textBox6.Text);
            int b = Convert.ToInt32(this.textBox7.Text);
            int c = 0;

            if (radioButton1.Checked)
            {

                c = a + b;

            }
            else if (radioButton2.Checked)
            {

                c = a - b;

            }
           else if (radioButton3.Checked)
            {

                c = a * b;

            }
            label3.Text = c.ToString();
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
