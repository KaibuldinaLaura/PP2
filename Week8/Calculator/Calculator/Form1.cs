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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Factorial(double n)
        {
            int a = 1;
            for (int i = 2; i <= n; i++)
                a *= i;
            return a;
        }

        static bool IsPrime(double n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }

        static int SumOfPrimes(double a)
        {
            int n = Convert.ToInt32(a);
            bool[] prime = new bool[n + 1];
            for (int i = 0; i < n + 1; i++)
                prime[i] = true;
            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }
            int sum = 0;
            for (int i = 2; i <= n; i++)
                if (prime[i])
                    sum += i;
            return sum;
        }

        static int ToBinary(double a)
        {
            int num=Convert.ToInt32(a);
            string result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            int c = Convert.ToInt32(result);
            return c;
        }

        static int ToDecimal(double a)
        {
            int num = Convert.ToInt32(a);
            int binary_val = num, decimal_val = 0, base_val = 1, rem;
            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem * base_val;
                num = num / 10;
                base_val = base_val * 2;
            }
            return decimal_val;
        }

        static int fibonacci(double a)
        {
            int n = Convert.ToInt32(a);
            if (n <= 0)
                return 0;
            int[] fibo = new int[n + 1];
            fibo[0] = 0; fibo[1] = 1; 
            int sum = fibo[0] + fibo[1];
            for (int i = 2; i <= n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                sum += fibo[i];
            }
            return sum;
        }

        static float gcd(double a, float n2)
        {
            int n1 = Convert.ToInt32(a);
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }

        static float lcm(double a, float b)
        {
            int n1 = Convert.ToInt32(a);
            int n2 = Convert.ToInt32(b);
            float hcf, lcm;
            hcf = gcd(n1, n2);
            lcm = (n1 * n2) / hcf;
            return lcm;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = Factorial(a);
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    if (IsPrime(a))
                    {
                        textBox1.Text = "yes";
                    }
                    else
                    {
                        textBox1.Text = "no";
                    }
                    break;
                case 8:
                    b = SumOfPrimes(a);
                    textBox1.Text = b.ToString();
                    break;
                case 9:
                    b = ToBinary(a);
                    textBox1.Text = b.ToString();
                    break;
                case 10:
                    b = ToDecimal(a);
                    textBox1.Text = b.ToString();
                    break;
                case 11:
                    b = fibonacci(a);
                    textBox1.Text = b.ToString();
                    break;
                case 12:
                    b = gcd(a, float.Parse(textBox1.Text));
                    textBox1.Text = b.ToString();
                    break;
                case 13:
                    b = lcm(a, float.Parse(textBox1.Text));
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }

        double a, b;
        int count;
        bool znak = true;

        private void button3_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "x";
            znak = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 5;
            label1.Text = "sqrt(" + a.ToString() + ")";
            znak = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 6;
            label1.Text = a.ToString() + "!";
            znak = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 7;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 8;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 9;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 10;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 11;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 12;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 13;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}