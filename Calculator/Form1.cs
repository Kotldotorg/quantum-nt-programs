// Copyright (c) Moise Tiberiu 2023

namespace Calculator
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";

            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "+";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "*";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst - valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst + valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst / valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst * valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TextBox.Text = "0";
        }
    }
}