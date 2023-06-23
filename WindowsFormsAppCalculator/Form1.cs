using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        //Поля
        Double result = 0;
        string operation = string.Empty;
        string firstNum, secondNum;
        bool enterValue = false;
        double memory;
        bool memoryFlag = false;



        public Form1()
        {
            InitializeComponent();

            buttonMC.Enabled = false;
            buttonMR.Enabled = false;
        }

        //кнопка математической операции
        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) buttonEquals.PerformClick();
            else result = Double.Parse(textDisplay1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (textDisplay1.Text != "0")
            {
                textDisplay2.Text = firstNum = $"{result}{operation}";
                textDisplay1.Text = string.Empty;
            }
        }

        //функция для проверки введено ли правильно десятичное число (например, 8.6 , а не 8. )
        private bool IsCompleteDecimalNumber(string number)
        {
            double result;
            return double.TryParse(number, out result);
        }

        //кнопка равно
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secondNum = textDisplay1.Text;

            if (!IsCompleteDecimalNumber(secondNum))
            {
                MessageBox.Show("Ошибка: Введите полное десятичное число.");
                return;
            }

            textDisplay2.Text = $"{textDisplay2.Text} {textDisplay1.Text} =";
            if (textDisplay1.Text != string.Empty)
            {
                if (textDisplay1.Text == "0")
                {
                    textDisplay2.Text = string.Empty;
                }

                switch (operation)
                {
                    case "+":
                        textDisplay1.Text = (result + Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{firstNum}{secondNum} = {textDisplay1.Text} \n");
                        break;

                    case "-":
                        textDisplay1.Text = (result - Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{firstNum}{secondNum} = {textDisplay1.Text} \n");
                        break;

                    case "×":
                        textDisplay1.Text = (result * Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{firstNum}{secondNum} = {textDisplay1.Text} \n");
                        break;

                    case "÷":
                        if (Double.Parse(secondNum) == 0)
                        {
                            MessageBox.Show("Ошибка: Деление на ноль недопустимо.");
                            return;
                        }
                        else
                        {
                            textDisplay1.Text = (result / Double.Parse(textDisplay1.Text)).ToString();
                            RtBoxDisplayHistory.AppendText($"{firstNum}{secondNum} = {textDisplay1.Text} \n");
                            break;
                        }

                        

                    default: textDisplay2.Text = $"{textDisplay1.Text} = ";
                        break;
                }

                result = Double.Parse(textDisplay1.Text);
                operation = string .Empty;
            }
        }

        //кнопка раскрытия истории

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PanelHistory.Height = (PanelHistory.Height == 5) ? PanelHistory.Height = 345 : 5;
        }

        //кнопка очистки истории
        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
            {
                RtBoxDisplayHistory.Text = "Журнал истории пустой";
            }
        }

        //кнопка backspace
        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text.Length > 0)
            {
                textDisplay1.Text = textDisplay1.Text.Remove(textDisplay1.Text.Length - 1, 1);
            }

            if (textDisplay1.Text == string.Empty)
            {
                textDisplay1.Text = "0";
            }
        }

        //кнопка C
        private void BtnC_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
            textDisplay2.Text = string.Empty;
            result = 0;
        }

        //кнопка CE
        private void BtnCE_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
        }

        //кнопки дополнительных операций
        private void BtnOperations_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "√x":

                    if (double.Parse(textDisplay1.Text) < 0)
                    {
                        MessageBox.Show("Ошибка: Извлечение квадратного корня из отрицательного числа недопустимо.");
                        return;
                    }
                    else
                    {
                        textDisplay2.Text = $"√({textDisplay1.Text})";
                        textDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(textDisplay1.Text)));
                        break;
                    }

                    

                case "x^2":
                    textDisplay2.Text = $"({textDisplay1.Text})^2";
                    textDisplay1.Text = Convert.ToString(Convert.ToDouble(textDisplay1.Text) * Convert.ToDouble(textDisplay1.Text));
                    break;

                case "1/x":
                    textDisplay2.Text = $"1/({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(textDisplay1.Text));
                    break;

                case "%":
                    textDisplay2.Text = $"%({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(Convert.ToDouble(textDisplay1.Text) / Convert.ToDouble(100));
                    break;

                case "±":
                    textDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(textDisplay1.Text));
                    break;

                default:
                    break;
            }

            if (double.Parse(textDisplay1.Text) < 0)
            {
                RtBoxDisplayHistory.AppendText("");
            }
            else
            {
                RtBoxDisplayHistory.AppendText($"{textDisplay2.Text} = {textDisplay1.Text} \n");
            }
                
        }

        //кнопка выхода
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //кнопка свернуть
        private void BtnCollapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //КНОПКИ ДЛЯ РАБОТЫ С ПАМЯТЬЮ
        private void BtnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(textDisplay1.Text);
            buttonMC.Enabled = true;
            buttonMR.Enabled = true;

            memoryFlag = true;

        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = memory.ToString();
            memoryFlag = true;
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
            memory = 0;
            buttonMR.Enabled= false;
            buttonMC.Enabled= false;
        }

        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(textDisplay1.Text);

        }

        private void BtnMMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(textDisplay1.Text);
        }

        //НАЖАТИЕ кнопки
        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0" || enterValue || memoryFlag) 
            {
                textDisplay1.Text = string.Empty;
                memoryFlag = false;
            }
            

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textDisplay1.Text.Contains(".")) textDisplay1.Text = textDisplay1.Text + button.Text;
            }
            else textDisplay1.Text = textDisplay1.Text + button.Text;
        }


    }
}
