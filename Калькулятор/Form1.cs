using System;
using System.Windows.Forms;
namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float firstVal, secondVal, endVal;
        int count, curop;

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
                {
                    case Keys.NumPad0:
                        button0.PerformClick();
                        break;
                    case Keys.NumPad1:
                        button1.PerformClick();
                        break;
                    case Keys.NumPad2:
                        button2.PerformClick();
                        break;
                    case Keys.NumPad3:
                        button3.PerformClick();
                        break;
                    case Keys.NumPad4:
                        button4.PerformClick();
                        break;
                    case Keys.NumPad5:
                        button5.PerformClick();
                        break;
                    case Keys.NumPad6:
                        button6.PerformClick();
                        break;
                    case Keys.NumPad7:
                        button7.PerformClick();
                        break;
                    case Keys.NumPad8:
                        button8.PerformClick();
                        break;
                    case Keys.NumPad9:
                        button9.PerformClick();
                        break;
                    case Keys.Decimal:
                        buttonDot.PerformClick();
                        break;
                    case Keys.Subtract:
                        buttonMinus.PerformClick();
                        break;
                    case Keys.Add:
                        buttonPlus.PerformClick();
                        break;
                    case Keys.Multiply:
                        buttonMultiply.PerformClick();
                        break;
                    case Keys.Divide:
                        buttonDivide.PerformClick();
                        break;
                    case Keys.Delete:
                        buttonDelete.PerformClick();
                        break;
                    case Keys.Enter:
                        buttonCalc.PerformClick();
                        break;
                    default:
                        break;
                }
            base.OnKeyDown(e);
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #region Числа

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))
                return;
            else
            {
                if (textBox1.Text != string.Empty)
                    textBox1.Text += ",";
                else if (textBox1.Text == string.Empty)
                    textBox1.Text = "0,";
            }
        }
        #endregion 

        #region Операции
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (curop != 1)
            {
                curop = 1;
                if (textBox1.Text == String.Empty)
                {
                    textBox2.Text = firstVal + " / ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " / ";
                }
                count = 1;
            }

            else
            {
                curop = 1;
                if (textBox1.Text == String.Empty)
                {
                    firstVal = 0;
                    textBox2.Text = firstVal.ToString() + " / ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " / ";
                }
                count = 1;
            }

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (curop != 2)
            {
                curop = 2;
                if (textBox1.Text == String.Empty)
                {
                    textBox2.Text = firstVal + " * ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " * ";
                }
                count = 2;
            }

            else
            {
                curop = 2;
                if (textBox1.Text == String.Empty)
                {
                    firstVal = 0;
                    textBox2.Text = firstVal.ToString() + " * ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " * ";
                }
                count = 2;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (curop != 3)
            {
                curop = 3;
                if (textBox1.Text == String.Empty)
                {
                    textBox2.Text = firstVal + " - ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " - ";
                }
                count = 3;
            }

            else
            {
                curop = 3;
                if (textBox1.Text == String.Empty)
                {
                    firstVal = 0;
                    textBox2.Text = firstVal.ToString() + " - ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " - ";
                }
                count = 3;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (curop != 4)
            {
                curop = 4;
                if (textBox1.Text == String.Empty)
                {
                    textBox2.Text = firstVal + " + ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " + ";
                }
                count = 4;
            }

            else
            {
                curop = 4;
                if (textBox1.Text == String.Empty)
                {
                    firstVal = 0;
                    textBox2.Text = firstVal.ToString() + " + ";
                }
                else
                {
                    firstVal = float.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                    textBox2.Text = firstVal.ToString() + " + ";
                }
                count = 4;
            }
        }

        #endregion 


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            firstVal = 0;
            secondVal = 0;
            count = 0;
            curop = 0;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (curop == 0)
            {
                return;
            }
            else
            {
                if (textBox1.Text == String.Empty)
                {
                    secondVal = 0;
                    textBox2.Text += secondVal.ToString() + " = ";
                }
                else
                {
                    secondVal = float.Parse(textBox1.Text);
                    textBox2.Text += secondVal.ToString() + " = ";
                }
                calculate();
                curop = 0;
                firstVal = 0;
                secondVal = 0;
                endVal = 0;
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    if (secondVal == 0)
                    {
                        textBox1.Text = String.Empty;
                        textBox2.Text = String.Empty;
                        MessageBox.Show("Делить на ноль нельзя");
                        break;
                    }
                    else
                    {
                        endVal = firstVal / secondVal;
                        textBox1.Text = String.Empty;
                        textBox2.Text += endVal.ToString();
                        
                    }
                    break;
                case 2:
                    if (String.IsNullOrEmpty(textBox1.Text)) secondVal = 0;
                    else secondVal = float.Parse(textBox1.Text);
                    endVal = firstVal * secondVal;
                    textBox1.Text = String.Empty;
                    textBox2.Text += endVal.ToString();
                    break;
                case 3:
                    if (String.IsNullOrEmpty(textBox1.Text)) secondVal = 0;
                    else secondVal = float.Parse(textBox1.Text);
                    endVal = firstVal - secondVal;
                    textBox1.Text = String.Empty;
                    textBox2.Text += endVal.ToString();
                    break;
                case 4:
                    if (String.IsNullOrEmpty(textBox1.Text)) secondVal = 0;
                    else secondVal = float.Parse(textBox1.Text);
                    endVal = firstVal + secondVal;
                    textBox1.Text = String.Empty;
                    textBox2.Text += endVal.ToString();
                    break;

                default:
                    break;

            }
        }
    }
}