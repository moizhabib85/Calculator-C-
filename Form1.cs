namespace CalculaTorFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "7";
                i = 1;
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "1";
                i = 1;
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                textBox1.Text = "2";
                i = 1;
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "3";
                i = 1;
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "4";
                i = 1;
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "5";
                i = 1;
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "6";
                i = 1;
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "8";
                i = 1;
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "9";
                i = 1;
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = ".";
                i = 1;
            }
            else if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "0";
                i = 1;
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1 != null && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        double val1 = 0.0, val2 = 0.0;
        string op = "";
        private void button17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                val1 = Convert.ToDouble(textBox1.Text);
                op = "+";
                textBox1.Text = textBox1.Text + " +";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                val1 = Convert.ToDouble(textBox1.Text);
                op = "*";
                textBox1.Text = textBox1.Text + " *";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                val1 = Convert.ToDouble(textBox1.Text);
                op = "-";
                textBox1.Text = textBox1.Text + "-";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                val1 = Convert.ToDouble(textBox1.Text);
                op = "/";
                textBox1.Text = textBox1.Text + " /";
            }
        }


        double res = 0.0;
        private void button11_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "." && op != "")
            {
                string[] parts = textBox1.Text.Split(new string[] { op }, StringSplitOptions.None);
                val2 = Convert.ToDouble(parts[1].Trim());
                if (parts.Length > 1)
                {
                    if (op == "+")
                    {
                        res = val1 + val2;
                    }
                    else if (op == "-")
                    {
                        res = val1 - val2;
                    }
                    else if (op == "/")
                    {
                        res = val1 / val2;
                    }
                    else if (op == "*")
                    {
                        res = val1 * val2;
                    }
                    textBox1.Text = res.ToString();
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            val1 = 0.0;
            val2 = 0.0;
            i = 0;
            op = "";
        }
    }
}