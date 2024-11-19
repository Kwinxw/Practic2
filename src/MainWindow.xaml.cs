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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Практика2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenTranslatorWindow(object sender, RoutedEventArgs e)
        {
            TranslatorWindow translatorWindow = new TranslatorWindow();
            translatorWindow.Show();
        }

        private void OpenCalculatorWindow(object sender, RoutedEventArgs e)
        {
            CalculatorWindow calculatorWindow = new CalculatorWindow();
            calculatorWindow.Show();
        }

        private void OpenNumberRangeWindow(object sender, RoutedEventArgs e)
        {
            NumberRangeWindow numberRangeWindow = new NumberRangeWindow();
            numberRangeWindow.Show();
        }

        private void OpenPasswordWindow(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            passwordWindow.Show();
        }
    }
}
