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

namespace FactoryPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }

        private void Ncheese_Click(object sender, RoutedEventArgs e)
        {
            Pizza pizza = NYPizzaStore.INSTANCE.OrderPizza("cheese");
        }

        private void Nclam_Click(object sender, RoutedEventArgs e)
        {
            Pizza pizza = NYPizzaStore.INSTANCE.OrderPizza("clam");
        }

        private void Ccheese_Click(object sender, RoutedEventArgs e)
        {
            Pizza pizza = ChicagoPizzaStore.INSTANCE.OrderPizza("cheese");
        }

        private void Cclam_Click(object sender, RoutedEventArgs e)
        {
            Pizza pizza = ChicagoPizzaStore.INSTANCE.OrderPizza("clam");
        }
    }
}
