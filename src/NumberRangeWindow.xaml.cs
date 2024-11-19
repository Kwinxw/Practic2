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
    public partial class NumberRangeWindow : Window
    {
        public NumberRangeWindow()
        {
            InitializeComponent();
        }
        private void CheckRange(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(InputNumber.Text);
                string result;
                if (number >= 0 && number <= 14)
                    result = "[0 - 14]";
                else if (number >= 15 && number <= 35)
                    result = "[15 - 35]";
                else if (number >= 36 && number <= 50)
                    result = "[36 - 50]";
                else if (number >= 51 && number <= 100)
                    result = "[51 - 100]";
                else
                    result = "Число вне диапазона.";
                RangeResult.Text = $"Число попадает в диапазон: {result}";
            }
            catch (FormatException)
            {
                RangeResult.Text = "Ошибка: некорректный ввод.";
            }
        }
    }
}
