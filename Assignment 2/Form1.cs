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

        private void SeriesCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double UserInput = double.Parse(textBox1.Text);
                double UserInput2 = double.Parse(textBox2.Text);
                double UserInput3 = double.Parse(textBox3.Text);
                double Answer = UserInput + UserInput2 + UserInput3;
                label2.Text = Answer.ToString("0.00");

            }

            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");

            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
            }

            catch
            {

            }
        }

        private void ParallelCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                double Input = double.Parse(textBox4.Text);
                double Input2 = double.Parse(textBox5.Text);
                double Top = Input * Input2;
                double Bottom = Input + Input2;
                double Answer = Top / Bottom;
                label7.Text = Answer.ToString();
            }
            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");
            }

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double UserInput = double.Parse(textBox6.Text);
                double UserInput2 = double.Parse(textBox7.Text);
                double Answer = UserInput + UserInput2;
                label13.Text = Answer.ToString();

            }

            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                double UserInput = double.Parse(textBox8.Text);
                double UserInput2 = double.Parse(textBox9.Text);
                double UserInput3 = double.Parse(textBox10.Text);
                double UserInput4 = double.Parse(textBox11.Text);
                double Answer = UserInput + UserInput2 + UserInput3 + UserInput4;
                label15.Text = Answer.ToString();

            }

            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");

            }
        }
    }
}
