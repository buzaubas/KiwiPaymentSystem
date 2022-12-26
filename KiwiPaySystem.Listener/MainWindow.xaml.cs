using KiwiPaySystem.Listener.Modal;
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

namespace KiwiPaySystem.Listener
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = System.Windows.WindowState.Minimized;
            EntityModal db = new EntityModal();
            var results = db.Events.Where(w => w.Status == false);
            foreach (var item in results)
            {
                MessageBox.Show(item.Message + item.CreateDate);
            }
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
