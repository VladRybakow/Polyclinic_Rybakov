using Polyclinic_Rybakov.DB;
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

namespace Polyclinic_Rybakov.Pages
{
    public partial class Emp : Page
    {
        public Emp()
        {
            InitializeComponent();

            Bid.ItemsSource = MainWindow.dbPractik.Doctor.ToList();
        }

        private void Bid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = Bid.SelectedItem as Doctor;
            NavigationService.Navigate(new BidPage(gg));
        }
    }
}
