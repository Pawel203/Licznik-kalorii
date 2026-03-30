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

namespace Licznik_kalorii
{
    public partial class Posiłki : Page
    {
        int B = 0;
        int T = 0;
        int W = 0;
        int Kalorie = 0;
        public Posiłki()
        {
            InitializeComponent();
        }
        private void Cofnij_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.Śniadanie.Visibility = Visibility.Visible;
            mainWindow.MainFrame.Visibility = Visibility.Collapsed;

        }

        private void DodajOwsianka(object sender, RoutedEventArgs e)
        {



            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.Śniadanie.Visibility = Visibility.Visible;
            mainWindow.MainFrame.Visibility = Visibility.Collapsed;
        }

        private void DodajJajecznica(object sender, RoutedEventArgs e)
        {

        }
    }
}

