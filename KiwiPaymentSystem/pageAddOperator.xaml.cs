using KiwiPaymentSystem.Modal;
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
    /// Логика взаимодействия для pageAddOperator.xaml
    /// </summary>
    public partial class pageAddOperator : Page
    {
        private Operators _operators { get; set; }
        private OperatorService _operatorsService { get; set; }
        public pageAddOperator() : this(null)
        {

        }
        public pageAddOperator(Operators operators)
        {
            InitializeComponent();
            if(operators == null)
            {
                btnAdd.Content = "Add";
            }
            else
            {
                btnAdd.Content = "Edit";
                tbxLogo.Text = operators.Logo;
                tbxName.Text = operators.Name;
                tbxPhone.Text = operators.Phone;
                tbxPercent.Text = operators.Percent.ToString();


            }

            _operators = operators;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(_operators == null)
            {
                Operators op = new Operators();
                op.Logo = tbxLogo.Text;
                op.Name = tbxName.Text;
                op.Phone = tbxPhone.Text;
                op.Percent = Convert.ToDouble(tbxPercent.Text);
                op.CreateDate = (DateTime)dpCreateDate.SelectedDate;

                if (_operatorsService.AddOperator(op))
                {
                    MessageBox.Show("Successfuly Added");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

            }
            else
            {

            }

            pageOperatorList pad = new pageOperatorList();
            MainAuthWindow._frameMain.Navigate(pad);
        }
    }
}
