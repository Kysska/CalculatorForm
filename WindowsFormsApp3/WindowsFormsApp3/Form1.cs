using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        double number1 = 0;
        double number2 = 0;
        double number3 = 0;
        double number4 = 0;
        char sign;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += button13_KeyDown;
            this.KeyDown += button1_KeyDown;
            this.KeyDown += button19_KeyDown;
            this.KeyDown += button23_KeyDown;
            this.KeyDown += button9_KeyDown;
            this.KeyDown += button20_KeyDown;
            this.KeyDown += button2_KeyDown;
            this.KeyDown += button22_KeyDown;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = number.Text;
            else
                textBox1.Text = textBox1.Text + number.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            sign = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = ('-').ToString();
            }
            else
            {
                number1 = Convert.ToDouble(textBox1.Text);
                sign = (sender as Button).Text[0];
                textBox1.Clear();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            if (number2 == 0 && sign == '/')
            {
                textBox1.Text = ("Деление на ноль невозможно");
            }
            else
            {
                switch (sign)
                {
                    case '+':
                        number3 = number1 + number2;
                        textBox1.Text = number3.ToString();
                        break;
                    case '-':
                        number3 = number1 - number2;
                        textBox1.Text = number3.ToString();
                        break;
                    case '/':
                        number3 = number1 / number2;
                        textBox1.Text = number3.ToString();
                        break;
                    case '*':
                        number3 = number1 * number2;
                        textBox1.Text = number3.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number4 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (1 / number4).ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            number4 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (Math.Sqrt(number4)).ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            number4 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (number4 * (-1)).ToString();
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                button1.PerformClick();
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                button2.PerformClick();
            }
        }
        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide){
                button9.PerformClick();
            } 
            if (e.KeyCode == Keys.OemQuestion)
            {
                if (e.Shift)
                {
                    button22.PerformClick();
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                else
                {
                    button9.PerformClick();
                }
            }
        }
        private void button13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                button13.PerformClick();
            }
            if(e.KeyCode == Keys.D8)
            {
                if (e.Shift)
                {
                    button13.PerformClick();
                }
            }
        }
        private void button19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract || (e.KeyCode == Keys.OemMinus))
            {
                button19.PerformClick();
            }
        }
        private void button23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || (e.KeyCode == Keys.Oemplus))
            {
                button23.PerformClick();
            }
        }
        private void button20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button20.PerformClick();
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
              textBox1.Text = textBox1.Text + ",";
            }       
        }
        private void button3_Click(object sender, EventArgs e)
        {
            number4 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (Math.Pow(number4, 2)).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number4 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (number4 / 100).ToString();
        }

        private void button22_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal)
            {
                button22.PerformClick();
            }
        }
    }
}
