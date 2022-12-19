﻿using System;
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
using System.Windows.Shapes;

namespace KiwiPaymentSystem
{
    /// <summary>
    /// Логика взаимодействия для MainAuthWindow.xaml
    /// </summary>
    public partial class MainAuthWindow : Window
    {
        public MainAuthWindow()
        {
            InitializeComponent();

        }

        public class Operator
        {
            public int OperatorId { get; set; }
            public string Prefix { get; set; }
            public string Logo { get; set; }    
            public string Name { get; set; }
            public double Percent { get; set; }
        }

        private void miOperatorList_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Source = new Uri("pageOperatorList.xaml", UriKind.RelativeOrAbsolute);
        }

        private void miClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}