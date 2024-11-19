using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace Практика2
{
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }
        private void Calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                double operand1 = Convert.ToDouble(Operand1.Text);
                double operand2 = Convert.ToDouble(Operand2.Text);
                string sign = Sign.Text;
                double result;
                switch (sign)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            CalculationResult.Text = "Ошибка: деление на ноль.";
                            return;
                        }
                        result = operand1 / operand2;
                        break;
                    default:
                        CalculationResult.Text = "Недопустимый знак операции.";
                        return;
                }
                CalculationResult.Text = $"Результат: {result}";
            }
            catch (FormatException)
            {
                CalculationResult.Text = "Ошибка: некорректный ввод.";
            }
        }
    }
}
