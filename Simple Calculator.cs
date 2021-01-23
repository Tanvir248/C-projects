using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double Input1, Input2, Result;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Input1 = Convert.ToDouble(textBox1.Text);
            Input2 = Convert.ToDouble(textBox2.Text);
            Result = Input1 / Input2;
            resultBox.Text = Result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            Input1 = Convert.ToDouble(textBox1.Text);
            Input2 = Convert.ToDouble(textBox2.Text);
            Result = Input1 - Input2;
            resultBox.Text = Result.ToString();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Input1 = Convert.ToDouble(textBox1.Text);
            Input2 = Convert.ToDouble(textBox2.Text);
            Result = Input1 * Input2;
            resultBox.Text = Result.ToString();
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            Input1 = Convert.ToDouble(textBox1.Text);
           // Input2 = Convert.ToDouble(textBox2.Text);
            Result = Math.Sqrt(Input1);
            resultBox.Text = Result.ToString();
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            Input1 = Convert.ToDouble(textBox1.Text);
            Input2 = Convert.ToDouble(textBox2.Text);
            Result = Input1 % Input2;
            resultBox.Text = Result.ToString();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Input1 = Convert.ToDouble(textBox1.Text);
            //Input2 = Convert.ToDouble(textBox2.Text);
            Result = Math.Pow(Input1 ,2);
            resultBox.Text = Result.ToString();
        }

        private void welcomeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                   Team Sparta \n Group Leader : Md. Tanvir Rahman. \n Member 1:  Zannatun Nayem Smriti. \n Member 2: Md. Mostafizur Rahman.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           textBox2.Text = "";
            resultBox.Text = "";
        }

        private void answerButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
                
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Input1 = Convert.ToDouble(textBox1.Text);
            Input2 = Convert.ToDouble(textBox2.Text);
            Result = Input1 + Input2;
            resultBox.Text = Result.ToString();
        }
    }
}
