using org.mariuszgromada.math.mxparser;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calc
{
    public partial class main : Form
    {
        public const int EM_GETRECT = 0xB2;
        public const int EM_SETRECT = 0xB3;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, ref RECT lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public void CenterText(RichTextBox richTextBox)
        {
            RECT rect = new RECT();
            SendMessage(richTextBox.Handle, EM_GETRECT, 0, ref rect);
            int height = rect.Bottom - rect.Top;
            int lineCount = richTextBox.GetLineFromCharIndex(richTextBox.TextLength) + 1;
            int lineHeight = richTextBox.Font.Height;
            int textHeight = lineCount * lineHeight;
            int pad = (height - textHeight) / 2;
            rect.Top += pad;
            rect.Bottom -= pad;
            SendMessage(richTextBox.Handle, EM_SETRECT, 0, ref rect);
        }

        public main()
        {
            InitializeComponent();
            this.input.SelectionAlignment = HorizontalAlignment.Right;
            this.MaximizeBox = false;
            this.Shown += new EventHandler(this.Form1_Shown);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            input.Focus();
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

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonText = button.Text;
                addDigitButtonClick(buttonText);
            }
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
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.C)
            {
                buttonClear_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void AdjustFontSize()
        {
            if (input.Text.Length > 12)
            {
                input.Font = new Font(input.Font.FontFamily, 32, input.Font.Style);
            }
            if (input.Text.Length > 16)
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
            if (input.Text.Length < 12)
            {
                input.Font = new Font(input.Font.FontFamily, 44, input.Font.Style);
            }
            CenterText(input);
        }
        public static long ConvertToDecimal(string numberString)
        {
            if (string.IsNullOrWhiteSpace(numberString))
            {
                throw new ArgumentException("Строка не может быть пустой.");
            }

            numberString = numberString.ToUpper(); // Приведение к верхнему регистру для упрощения проверки

            // Проверка на двоичное число
            if (numberString.All(c => c == '0' || c == '1'))
            {
                return Convert.ToInt64(numberString, 2);
            }

            // Проверка на шестнадцатеричное число
            if (numberString.All(c => (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
            {
                return Convert.ToInt64(numberString, 16);
            }

            return Convert.ToInt64(numberString, 10);
        }
        void input_TextChanged(object sender, EventArgs e)
        {
            AdjustFontSize();
            string str = input.Text;
            if (str.Length > 0)
            {
                try
                {
                    long bits = long.Parse(str);
                    string hexNumber = bits.ToString("X");
                    label1.Text = $"HEX: {hexNumber}";
                    string binaryNumber = Convert.ToString(bits, 2);
                    label2.Text = $"BIN: {binaryNumber}";
                    label3.Text = $"DEC: {ConvertToDecimal(str)}";
                }
                catch { }
            }
            if (str.Length == 0)
            {
                label1.Text = "HEX: 0";
                label2.Text = "BIN: 0";
                label3.Text = "DEC: 0";
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            int cursorPosition = input.SelectionStart;
            addDigitButtonClick("log2()");
            input.SelectionStart = cursorPosition + 5;
            input.Focus();
        }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            int cursorPosition = input.SelectionStart;
            addDigitButtonClick("√()");
            input.SelectionStart = cursorPosition + 2;
            input.Focus();
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            int cursorPosition = input.SelectionStart;
            addDigitButtonClick("ln()");
            input.SelectionStart = cursorPosition + 3;
            input.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            input.Text = label1.Text.Substring(5);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            input.Text = label2.Text.Substring(5);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            input.Text = label3.Text.Substring(5);
        }
    }
}
