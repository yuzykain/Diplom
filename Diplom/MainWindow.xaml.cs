using System.ComponentModel;
using System.Windows;

namespace Diplom
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

        private void MenuCloseApp_Click(object sender, RoutedEventArgs e) => Close();

        private void MenuHelpEdit_Click(object sender, RoutedEventArgs e)
        {
            UserHelpWindow helpWindow = new UserHelpWindow();
            helpWindow.ShowDialog();
        }

        private void MenuChange_Click(object sender, RoutedEventArgs e)
        {
            CangeWindow changeWindow = new CangeWindow();
            changeWindow.ShowDialog();
        }
    }
}
