using System;
using System.Windows;

namespace Moduli_4
{
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void CalculateBonusButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TextBoxSalary.Text, out double salary) && int.TryParse(TextBoxExperience.Text, out int experience))
            {
                double bonusPercentage;

                if (experience < 5)
                    bonusPercentage = 0.10;
                else if (experience < 10)
                    bonusPercentage = 0.15;
                else if (experience < 15)
                    bonusPercentage = 0.25;
                else if (experience < 20)
                    bonusPercentage = 0.35;
                else if (experience < 25)
                    bonusPercentage = 0.45;
                else
                    bonusPercentage = 0.50;

                double bonus = salary * bonusPercentage;
                BonusLabel.Content = $"Премия: {bonus:C}";
            }
            else
            {
                BonusLabel.Content = "Ошибка: Введите корректные значения.";
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
