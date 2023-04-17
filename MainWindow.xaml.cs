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

namespace BugakovEkzamenPM04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text.Length < 10 || textBox.Text.Length > 60) 
            {
                textBox.Background = Brushes.Red;
                string text = "Количество букв от 10 до 60!";
                textBlock.Text = text;

            }
            else
            {
                textBox.Background = Brushes.Green;
                string text1 = "успешно";
                textBlock.Text = text1;
            }
        }
        private void TextBox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            if (textBox_adress.Text.Length < 20 || textBox_adress.Text.Length > 85)
            {
                textBox_adress.Background = Brushes.Red;
                string text = "Количество букв от 20 до 85!";
                textBlock_adress.Text = text;

            }
            else
            {
                textBox_adress.Background = Brushes.Green;
                string text1 = "успешно";
                textBlock_adress.Text = text1;
            }
        }

    }
}
