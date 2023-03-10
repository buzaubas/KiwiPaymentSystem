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

namespace KiwiPaymentSystem
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

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            string login = tbxLogin.Text;
            string password = tbxPassword.Password;

            if (string.IsNullOrWhiteSpace(login))
                lblLoginMessage.Content = "enter login";
            else
                lblLoginMessage.Content = null;

            if (string.IsNullOrWhiteSpace(password))
                lblPasswordMessage.Content = "enter password";
            else
                lblPasswordMessage = null;

            UserService userService = new UserService();
            if (userService.CheckUser(login, password))
            {
                MainAuthWindow mainAuth = new MainAuthWindow();
                mainAuth.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
