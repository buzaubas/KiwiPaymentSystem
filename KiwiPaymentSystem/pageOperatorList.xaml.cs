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
using static KiwiPaymentSystem.MainAuthWindow;

namespace KiwiPaymentSystem
{
    /// <summary>
    /// Логика взаимодействия для pageOperatorList.xaml
    /// </summary>
    public partial class pageOperatorList : Page
    {
        public pageOperatorList()
        {
            InitializeComponent();

            List<Operator> operators = new List<Operator>();
            operators.Add(new Operator()
            {
                OperatorId = 1,
                Prefix = "+7 (777)",
                Logo = "https://upload.wikimedia.org/wikipedia/ru/0/0e/Beeline_logo_2021.png",
                Name = "Beeline",
                Percent = 0.5,
            });

            //lvOperatorList.Items.Add(operators);    
            lvOperatorList.ItemsSource = operators;



            //WrapPanel wp = new WrapPanel();
            //wp.Children.Add(new Label() { Content = "+7 777" });
            //wp.Children.Add(new Label() { Content = "logo" });
            //wp.Children.Add(new Label() { Content = "Beeline" });
            //wp.Children.Add(new Label() { Content = "0.5%" });

            //lbxOperatorList.Items.Add(wp);
        }

        private void btnEditData_Click(object sender, RoutedEventArgs e)
        {
            Operator data = (Operator)lvOperatorList.SelectedItem;
        }
    }
}
