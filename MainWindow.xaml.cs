using System.Text;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Śniadanie_Dodaj(object sender, RoutedEventArgs e)
        {
            Śniadanie.Visibility = Visibility.Collapsed;

            MainFrame.Visibility = Visibility.Visible;

            MainFrame.Navigate(new Posiłki());
        }

        private void Obiad_Dodaj(object sender, RoutedEventArgs e)
        {

        }

        private void Kolacja_Dodaj(object sender, RoutedEventArgs e)
        {

        }
    }
}