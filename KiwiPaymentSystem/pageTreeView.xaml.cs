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
    /// Логика взаимодействия для pageTreeView.xaml
    /// </summary>
    public partial class pageTreeView : Page
    {
        public pageTreeView()
        {
            InitializeComponent();

            OperatorService operatorService = new OperatorService();

            tvOperators.ItemsSource = operatorService.GetOperators();
        }
    }
}
