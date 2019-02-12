using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_WindowsForms
{
    public partial class Form1 : Form
    {
        CalculationMemory Mem;
        int countOfPress = 0;

        public delegate void Message();
        public event Message Event;
        void message()
        {
            MessageBox.Show("Let's calculate!");
        }

        public Form1()
        {
            InitializeComponent();

            Mem = new CalculationMemory();
        }

        int num, count;
        double ans, buf;
        

        private void Form1_Load(object sender, EventArgs e) // sender - объект, инициировавший событие
                                                            //аргумент, хранящий информацию о событии(в данном случае EventArgs e).
        {
            Event += new Message(message);
            Event();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e) //+
        {            
            try
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
                label1.Text = num.ToString() + "+"; //display

            }
            catch (FormatException)
            {
                MessageBox.Show("The number is not an integer");
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
            
        }

        private void button13_Click(object sender, EventArgs e) //-
        {
            try { 
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
                label1.Text = num.ToString() + "-";
            }
            catch (FormatException)
            {
                MessageBox.Show("The number is not an integer");
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
}

        private void button5_Click(object sender, EventArgs e) //*
        {
            try
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
                label1.Text = num.ToString() + "*";
            }
            catch (FormatException)
            {
                MessageBox.Show("The number is not an integer");
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button4_Click(object sender, EventArgs e) // /
        {
            try
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
                label1.Text = num.ToString() + "/";
            }
            catch (FormatException)
            {
                MessageBox.Show("The number is not an integer");
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button10_Click(object sender, EventArgs e) //=
        {
            try
            {
                compute(); //call function to perform such operation
                count = 5;
                label1.Text = ""; //clear
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division by zero is impossible!");
                textBox1.Clear();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button20_Click(object sender, EventArgs e) // AC
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e) // Div %
        {
            try
            {
                num = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 6;
                label1.Text = num.ToString() + " div %";
            }
            catch (FormatException)
            {
                MessageBox.Show("The number is not an integer");
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button17_Click(object sender, EventArgs e) // +/-
        {
            try
            {
                textBox1.Text = (int.Parse(textBox1.Text) * -1).ToString();
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }

        private void button19_Click(object sender, EventArgs e) // <--
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void button12_Click(object sender, EventArgs e)
        {
           // Button button12 = (Button)sender;
            //textBox1.Text = textBox1.Text + button12.Text;

            textBox1.Text = textBox1.Text + "0";
            //textBox1.ForeColor = Color.RoyalBlue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {           
            textBox1.Text = textBox1.Text + "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void compute()
        {
            switch(count)
            {
                case 1:

                    //ans = num + int.Parse(textBox1.Text);
                    ans = calculator.Add(num, int.Parse(textBox1.Text));//для конвертации любого значения в значение определенного типа
                    textBox1.Text = ans.ToString(); //конвертируем int в string
                    break;

                case 2:                    
                    ans = calculator.Sub(num, int.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;

                case 3:                    
                    ans = calculator.Mult(num, int.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;

                case 4:                    
                        ans = calculator.Div(num, Double.Parse(textBox1.Text));
                        textBox1.Text = ans.ToString();
                    break;

                case 5: //=
                    ans = calculator.Equally(num, Double.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;

                case 6:
                    ans = calculator.Div2(num, int.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

        private void button21_Click(object sender, EventArgs e) // MEMORY
        {
            countOfPress++;
            if(countOfPress == 1)
            {
                textBox1.Text = Mem.MemoryShow().ToString();
            }
            if(countOfPress == 2)
            {
                Mem.Memory_Clear();
                label2.Text = "0";
                textBox1.Text = "0";
                countOfPress = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e) // M+
        {
            try
            {
                Mem.M_Sum(Double.Parse(textBox1.Text));
                buf = Double.Parse(textBox1.Text);
                label2.Text = buf.ToString();

                //label2.Focus();//display
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
            //num = int.Parse(textBox1.Text);
            //label2.Text = num.ToString(); //display
        }

        private void button22_Click(object sender, EventArgs e) // M-
        {
            try
            {
                Mem.M_Sub(Double.Parse(textBox1.Text));
                buf = Double.Parse(textBox1.Text);
                label2.Text = buf.ToString();
            }
            catch
            {
                MessageBox.Show("Insert a number!");
            }
        }
    }
}
