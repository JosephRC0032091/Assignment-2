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
                double UserInput = double.Parse(textBox1.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput2 = double.Parse(textBox2.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput3 = double.Parse(textBox3.Text);//This provides an input for the user to be able to type their desired values.
                double Answer = UserInput + UserInput2 + UserInput3;
                label2.Text = Answer.ToString("0.00");//This text

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
                double Input = double.Parse(textBox4.Text);//This provides an input for the user to be able to type their desired values.
                double Input2 = double.Parse(textBox5.Text);//This provides an input for the user to be able to type their desired values.
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
                double UserInput = double.Parse(textBox6.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput2 = double.Parse(textBox7.Text);//This provides an input for the user to be able to type their desired values.
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
                double UserInput = double.Parse(textBox8.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput2 = double.Parse(textBox9.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput3 = double.Parse(textBox10.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput4 = double.Parse(textBox11.Text);//This provides an input for the user to be able to type their desired values.
                double Answer = UserInput + UserInput2 + UserInput3 + UserInput4;//This section of the code performs the set equation.
                label15.Text = Answer.ToString();

            }

            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double UserInput = double.Parse(textBox12.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput2 = double.Parse(textBox13.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput3 = double.Parse(textBox14.Text);//This provides an input for the user to be able to type their desired values.
                double Answer = 1.0 / (1.0 / UserInput + 1.0 / UserInput2 + 1.0 / UserInput3);//This section of the code performs the set equation.
                label17.Text = Answer.ToString();
            }
            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double UserInput = double.Parse(textBox15.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput2 = double.Parse(textBox16.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput3 = double.Parse(textBox17.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput4 = double.Parse(textBox18.Text);//This provides an input for the user to be able to type their desired values.
                double Answer = 1.0 / (1.0 / UserInput + 1.0 / UserInput2 + 1.0 / UserInput3 + 1.0 / UserInput4);//This section of the code performs the set equation.
                label19.Text = Answer.ToString();
            }
            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double UserInput = double.Parse(textBox19.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput2 = double.Parse(textBox20.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput3 = double.Parse(textBox21.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput4 = double.Parse(textBox22.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput5 = double.Parse(textBox23.Text);//This provides an input for the user to be able to type their desired values.

                double Answer = UserInput + UserInput2 + UserInput3 + UserInput4 + UserInput5;//This section of the code performs the set equation.
                label21.Text = Answer.ToString();

            }

            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try// I have implemented a 
            {
                double UserInput = double.Parse(textBox24.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput2 = double.Parse(textBox25.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput3 = double.Parse(textBox26.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput4 = double.Parse(textBox27.Text);//This provides an input for the user to be able to type their desired values.
                double UserInput5 = double.Parse(textBox28.Text);//This provides an input for the user to be able to type their desired values.
                double Answer = 1.0 / (1.0 / UserInput + 1.0 / UserInput2 + 1.0 / UserInput3 + 1.0 / UserInput4 + 1.0 / UserInput5);//This section of the code performs the set equation.
                label23.Text = Answer.ToString();
            }
            catch
            {
                MessageBox.Show("Please Read Instuctions And Attempt Again, if further problems occur restart.");
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
