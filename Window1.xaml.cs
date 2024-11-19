using System;
using System.Windows;
using System.Windows.Controls;

namespace Moduli_4
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TextBoxA.Text, out int A) && int.TryParse(TextBoxB.Text, out int B) && A < B)
            {
                int sum = 0;
                string oddNumbers = "Нечетные числа: ";

                for (int i = A + 1; i < B; i++)
                {
                    sum += i;
                    if (i % 2 != 0)
                    {
                        oddNumbers += i + " ";
                    }
                }

                ResultLabel.Content = $"Сумма: {sum}\n{oddNumbers}";
            }
            else
            {
                ResultLabel.Content = "Ошибка: Убедитесь, что A < B и оба значения целые.";
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
