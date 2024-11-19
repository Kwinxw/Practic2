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
    public partial class TranslatorWindow : Window
    {
        private Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "солнце", "sun" },
            { "дождь", "rain" },
            { "снег", "snow" },
            { "ветер", "wind" },
            { "облако", "cloud" },
            { "туман", "fog" },
            { "гроза", "thunderstorm" },
            { "тепло", "warmth" },
            { "холод", "cold" },
            { "влажность", "humidity" }
        };
        public TranslatorWindow()
        {
            InitializeComponent();
        }
        private void TranslateWord(object sender, RoutedEventArgs e)
        {
            string input = InputWord.Text.ToLower();
            if (translations.TryGetValue(input, out string translation))
            {
                OutputTranslation.Text = translation;
            }
            else
            {
                OutputTranslation.Text = "Такого слова нет.";
            }
        }
    }
}
