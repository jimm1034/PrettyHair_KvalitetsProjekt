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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ApplicationLayer;
using PrettyHair_KvalitetsProjekt;

namespace PrettyHair_KvalitetsProjekt.Content
{
    /// <summary>
    /// Interaction logic for RecieveOrderMainPage.xaml
    /// </summary>
    public partial class RecieveOrderMainPage : Page
    {
        public RecieveOrderMainPage()
        {
            InitializeComponent();
        }

        private void SearchCustomerId_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.ConCheckCustomer(fullName.Text, adress.Text);
            MessageBox.Show("kunde " + controller.ConCheckCustomer(fullName.Text, adress.Text));

            this.NavigationService.Navigate(new Content.MakeOrder());
        }

        private void NewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Content.NewCustomer());
        }
    }
}
