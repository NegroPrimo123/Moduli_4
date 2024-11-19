using System;
using System.Windows;
using System.Windows.Controls;

namespace Moduli_4
{
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void CalculateSumButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TextBoxN.Text, out int n))
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                SumLabel.Content = $"Сумма от 1 до {n}: {sum}";
            }
            else
            {
                SumLabel.Content = "Ошибка: Введите корректное целое число.";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w1 = new MainWindow();
            w1.Show();
            Close();
        }
    }
}
