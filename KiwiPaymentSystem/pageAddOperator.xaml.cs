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
        public pageAddOperator() : this(new Operators())
        {
        }
        public pageAddOperator(Operators operators)
        {
            InitializeComponent();

            btnAdd.Content = operators.Id == 0 ? "Add" : "Edit";
            gridOperator.DataContext = operators;

            //if(operators == null)
            //{
            //    btnAdd.Content = "Add";
            //}
            //else
            //{
            //    btnAdd.Content = "Edit";
            //    //tbxId.Text = operators.Id.ToString();
            //    //tbxLogo.Text = operators.Logo;
            //    //tbxName.Text = operators.Name;
            //    //tbxPhone.Text = operators.Phone;
            //    //tbxPercent.Text = operators.Percent.ToString();

            //    gridOperator.DataContext = operators;
            //}

            _operators = operators;
            _operatorsService = new OperatorService();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(_operators.Id == 0)
            {
                //Operators op = new Operators();

                Operators op = (Operators)gridOperator.DataContext;

                //if (tbxId != null)
                //{
                //    op.Id = Convert.ToInt32(tbxId.Text);
                //}

                //op.Logo = tbxLogo.Text;
                //op.Name = tbxName.Text;
                //op.Phone = tbxPhone.Text;
                //op.Percent = Convert.ToDouble(tbxPercent.Text);
                if (dpCreateDate.SelectedDate != null)
                    op.CreateDate = (DateTime)dpCreateDate.SelectedDate;
                else
                    op.CreateDate = DateTime.Now;

                if (_operatorsService.AddOperator(op))
                    MessageBox.Show("Added");
                else
                    MessageBox.Show("Error occured");
            }
            else
            {
                //Operators op = new Operators();
                Operators op = (Operators)gridOperator.DataContext;

                //op.Id = _operators.Id;
                //op.Logo = tbxLogo.Text;
                //op.Name = tbxName.Text;
                //op.Phone = tbxPhone.Text;
                //op.Percent = Convert.ToDouble(tbxPercent.Text);
                if (dpCreateDate.SelectedDate != null)
                    op.CreateDate = (DateTime)dpCreateDate.SelectedDate;
                else
                    op.CreateDate = DateTime.Now;

                if (_operatorsService.editOperator(op))
                {
                    MessageBox.Show("Edited");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }

            pageOperatorList pad = new pageOperatorList();

            MainAuthWindow._frameMain.Navigate(pad);
        }

       
    }
}
