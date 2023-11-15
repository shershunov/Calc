using org.mariuszgromada.math.mxparser;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calc
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.input.SelectionAlignment = HorizontalAlignment.Right;
        }

        public void addDigitButtonClick(string digit)
        {
            int cursorPosition = input.SelectionStart;
            string currentText = input.Text;
            currentText = currentText.Insert(cursorPosition, digit);
            input.Text = currentText;
            input.SelectionStart = cursorPosition + 1;
            input.Focus();
        }

        private void deleteButton_Click()
        {
            int cursorPosition = input.SelectionStart;
            string currentText = input.Text;
            if (cursorPosition > 0)
            {
                currentText = currentText.Remove(cursorPosition - 1, 1);
                input.Text = currentText;
                input.SelectionStart = cursorPosition - 1;
            }

            input.Focus();
        }

        private void buttonDigit1_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(1.ToString());
        }

        private void buttonDigit2_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(2.ToString());
        }

        private void buttonDigit3_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(3.ToString());
        }

        private void buttonDigit4_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(4.ToString());
        }

        private void buttonDigit5_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(5.ToString());
        }

        private void buttonDigit6_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(6.ToString());
        }

        private void buttonDigit7_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(7.ToString());
        }

        private void buttonDigit8_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(8.ToString());
        }

        private void buttonDigit9_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(9.ToString());
        }

        private void buttonDigit0_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(0.ToString());
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            deleteButton_Click();
        }

        private void buttonOP_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("(");
        }

        private void buttonCP_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(")");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("/");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("*");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("+");
        }

        void buttonEqual_Click(object sender, EventArgs e)
        {
            Expression e1 = new Expression(input.Text);
            double result = e1.calculate();
            input.Text = Convert.ToString(result.ToString());
            input.SelectionStart = input.Text.Length;
            input.Focus();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(".");
        }

        private void buttonRTP_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("^");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            input.Clear();
            input.Focus();
        }

        private void buttonPI_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(Math.PI.ToString());
            input.SelectionStart = input.Text.Length;
            input.Focus();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            addDigitButtonClick(Math.E.ToString());
            input.SelectionStart = input.Text.Length;
            input.Focus();
        }

        double ChangeSign(double number)
        {
            return -number;
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            try
            {
                input.Text = ChangeSign(Convert.ToDouble(input.Text)).ToString();
            }
            catch { }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEqual_Click(sender, e);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                buttonClear_Click(sender, e);
            }
        }

        void AdjustFontSize()
        {
            if (input.Text.Length > 10)
            {
                input.Font = new Font(input.Font.FontFamily, 32, input.Font.Style);
            }
            if (input.Text.Length > 17)
            {
                input.Font = new Font(input.Font.FontFamily, 24, input.Font.Style);
            }
            if (input.Text.Length > 22)
            {
                input.Font = new Font(input.Font.FontFamily, 20, input.Font.Style);
            }
            if (input.Text.Length > 28)
            {
                input.Font = new Font(input.Font.FontFamily, 16, input.Font.Style);
            }
            if (input.Text.Length < 10)
            {
                input.Font = new Font(input.Font.FontFamily, 44, input.Font.Style);
            }
        }
        void input_TextChanged(object sender, EventArgs e)
        {
            if (input.Text == "1337")
            {
                DialogResult result = MessageBox.Show("Показать секретик?)", "Секретик", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                while (true)
                {
                    if (result == DialogResult.Yes)
                    {
                        secret secret = new secret();
                        secret.Show();
                        break;
                    }
                    else
                    {
                        result = MessageBox.Show("Показать секретик?)", "Секретик", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                }
            }
            AdjustFontSize();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("log2()");
            input.SelectionStart = input.Text.Length - 1;
            input.Focus();
        }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("√()");
            input.SelectionStart = input.Text.Length - 1;
            input.Focus();
        }
    }
}
