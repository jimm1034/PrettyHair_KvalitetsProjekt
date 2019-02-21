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
            Confirm popup = new Confirm();
            if (popup.ShowDialog().Value == true)
            {
                MessageBox.Show("Ordre blev gemt");
                this.Content = null;
            }
        }
    }
}
