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
    public partial class Client : Page
    {
        public Client()
        {
            InitializeComponent();
            DoctorLV.ItemsSource = MainWindow.dbPractik.Doctor.ToList();
        }

        private void DoctorLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = DoctorLV.SelectedItem as Doctor;
            NavigationService.Navigate(new ServicePage(gg));
        }

        private void ReviewBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReviewPage());
        }
    }
}
