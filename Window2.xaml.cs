using System;
using System.Windows;

namespace Moduli_4
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ShowSquaresButton_Click(object sender, RoutedEventArgs e)
        {
            string squares = "Квадраты чисел от 10 до 20:\n";
            for (int i = 10; i <= 20; i++)
            {
                squares += $"{i}^2 = {i * i}\n";
            }
            SquaresLabel.Content = squares;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w1 = new MainWindow();
            w1.Show();
            Close();
        }
    }
}
