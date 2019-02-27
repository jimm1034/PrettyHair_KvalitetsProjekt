using ApplicationForPrettyHair;
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

namespace PrettyHair_KvalitetsProjekt.Content
{
    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Page
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void SaveNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.NewCustomer(customerName.Text, customerAdress.Text);
            this.NavigationService.Navigate(new MakeOrder());
        }
    }
}
