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

namespace Observer
{

    public partial class MainWindow : Window
    {
        List<IObservable> ObservableList = new List<IObservable>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Humidity_Click(object sender, RoutedEventArgs e)
        {
            Humidity h = new Humidity(10);
            ObservableList.Add(h);

        }

        private void Pressure_Click(object sender, RoutedEventArgs e)
        {
            Pressure p = new Pressure(1);
            ObservableList.Add(p);
        }

        private void Temperature_Click(object sender, RoutedEventArgs e)
        {
            Temperature t = new Temperature(23);
            ObservableList.Add(t);
        }

        private void Humudityplus_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ObservableList.Count; i++)
            {
                if (ObservableList[i] is Humidity)
                {
                    ObservableList[i].setData(ObservableList[i].getData() + 1);
                }
            }
        }

        private void Pressureplus_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ObservableList.Count; i++)
            {
                if (ObservableList[i] is Pressure)
                {
                    ObservableList[i].setData(ObservableList[i].getData() + 1);
                }
            }
        }

        private void Temperatureplus_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ObservableList.Count; i++)
            {
                if(ObservableList[i] is Temperature)
                {
                    ObservableList[i].setData(ObservableList[i].getData() + 1);
                }
            }
        }

        private void LAB_Click(object sender, RoutedEventArgs e)
        {
            LAB l = new LAB();
            for (int i = 0; i < ObservableList.Count; i++)
            {
                ObservableList[i].RegisterObserver(l);
            }
        }

        private void Office_Click(object sender, RoutedEventArgs e)
        {
            Office l = new Office();
            for (int i = 0; i < ObservableList.Count; i++)
            {
                ObservableList[i].RegisterObserver(l);
            }
        }

        private void BS_Click(object sender, RoutedEventArgs e)
        {
            BS l = new BS();
            for (int i = 0; i < ObservableList.Count; i++)
            {
                ObservableList[i].RegisterObserver(l);
            }
        }

        private void School_Click(object sender, RoutedEventArgs e)
        {
            School l = new School();
            for (int i = 0; i < ObservableList.Count; i++)
            {
                ObservableList[i].RegisterObserver(l);
            }
        }
    }
}
