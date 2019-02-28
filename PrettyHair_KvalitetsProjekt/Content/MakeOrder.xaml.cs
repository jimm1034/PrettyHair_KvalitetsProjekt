using ApplicationLayer;
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
    /// Interaction logic for MakeOrder.xaml
    /// </summary>
    public partial class MakeOrder : Page
    {
        public Nullable<bool> DialogResult { get; set; }

        public MakeOrder()
        {
            InitializeComponent();
        }

        private void NewOrderLine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveOrder_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.ConCreateNewOrder(productTypeId.Text, quantity.Text,
                                    deliveryDate.Text);

            Confirm popup = new Confirm();
            if (popup.ShowDialog().Value == true)
            {
                MessageBox.Show(controller.ConCreateNewOrder(productTypeId.Text, quantity.Text,
                                    deliveryDate.Text) +
                "\nOrdre blev gemt");
                this.Content = null;
            }
        }
    }
}
