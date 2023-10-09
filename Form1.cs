using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorrectFinal;

namespace CorrectFinal
{
    public partial class Form1 : Form
    {
        //List<int> operators = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //1st fraction text box
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //2nd fraction text box
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //operation being applied
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // result text box
        }

        // create an active text box var from the TextBox class
        private TextBox ActiveTextBox;

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = textBox1;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = textBox2;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = textBox3;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = textBox4;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
            ActiveTextBox = textBox5;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clear the active text box when clr button is selected.
            ActiveTextBox.Clear();
        }

        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            // A/C button, to clear all text boxes from the application.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        // clear the error message if invalid fraction is entered
        private void clearError_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "9";
        }

        private void buttonSlash_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "/";
        }

        // Operation methods. Operations will only be applied to textBox3, the small operator window and only one character will be applied on click.

        // Each operator that is applied, will have spacing for visibility and then spaces will be split once inputed.
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox3.Text = " + ";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox3.Text = " - ";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBox3.Text = " * ";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox3.Text = " / ";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // calculate the fractions when '=' is pressed
            Fraction fraction1;
            Fraction fraction2;
            Fraction result = new Fraction();

            try
            {
                fraction1 = Fraction.Parse(textBox1.Text);
                fraction2 = Fraction.Parse(textBox2.Text);
            }
            catch (ArgumentException ex)
            {
                textBox5.Text = ex.Message;
                return;
            }

            // remove the spaces from the operator input.
            string input = textBox3.Text.Trim();

            if (input == "+")
            {
                result = fraction1 + fraction2;
            }
            else if (input == "-")
            {
                result = fraction1 - fraction2;
            }
            else if (input == "*")
            {
                result = fraction1 * fraction2;
            }
            else if (input == "/")
            {
                result = fraction1 / fraction2;
            }

            textBox4.Text = result.ToString();
        }

        private void label1Frac_Click(object sender, EventArgs e)
        {

        }

        private void label2Frac_Click(object sender, EventArgs e)
        {

        }
        // Helpful messages displayed if user hovers over text boxes that allow input.

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            label1Frac.Visible = true; 
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            label1Frac.Visible = false;   
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            label2Frac.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            label2Frac.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
