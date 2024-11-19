using System.Windows;

namespace Moduli_4
{
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void AnimatedButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы нашли секретную кнопку!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w1 = new MainWindow();
            w1.Show();
            Close();
        }
    }
}
