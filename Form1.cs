using System;
using System.Drawing;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Calc
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.input.AutoSize = false;
        }
        public void addDigitButtonClick(string digit)
        {
            // Получаем позицию курсора в текстовом поле
            int cursorPosition = input.SelectionStart;

            // Получаем текущий текст в текстовом поле
            string currentText = input.Text;

            // Добавляем цифру (например, "1") в текущий текст на позицию курсора
            currentText = currentText.Insert(cursorPosition, digit);

            // Обновляем текстовое поле с учетом добавленной цифры
            input.Text = currentText;

            // Перемещаем курсор после вставленной цифры
            input.SelectionStart = cursorPosition + 1;

            // Устанавливаем фокус на текстовом поле
            input.Focus();
        }
        private void deleteButton_Click()
        {
            // Получаем позицию курсора в текстовом поле
            int cursorPosition = input.SelectionStart;

            // Получаем текущий текст в текстовом поле
            string currentText = input.Text;

            // Проверяем, что есть символы перед курсором
            if (cursorPosition > 0)
            {
                // Удаляем символ слева от курсора
                currentText = currentText.Remove(cursorPosition - 1, 1);

                // Обновляем текстовое поле с учетом удаленной цифры
                input.Text = currentText;

                // Перемещаем курсор на предыдущую позицию
                input.SelectionStart = cursorPosition - 1;
            }

            // Устанавливаем фокус на текстовом поле
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
        private void Form1_KeyDown(object sender, KeyEventArgs  e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEqual_Click(sender, e);
            }
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs  e)
        {
            if (e.KeyCode == Keys.C)
            {
                buttonClear_Click(sender, e);
            }
        }

        void AdjustFontSize(TextBox textBox)
        {
            if (textBox.Text == "1337")
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
            if (textBox.Text.Length > 10)
            {
                textBox.Font = new Font(textBox.Font.FontFamily, 32, textBox.Font.Style);
            }
            if (textBox.Text.Length > 17)
            {
                textBox.Font = new Font(textBox.Font.FontFamily, 24, textBox.Font.Style);
            }
            if (textBox.Text.Length > 23)
            {
                textBox.Font = new Font(textBox.Font.FontFamily, 20, textBox.Font.Style);
            }
            if (textBox.Text.Length < 10)
            {
                textBox.Font = new Font(textBox.Font.FontFamily, 48, textBox.Font.Style);
            }
        }
        void input_TextChanged(object sender, EventArgs e)
        {
            AdjustFontSize(input);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("log2()");
        }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            addDigitButtonClick("√()");
        }
    }
}
