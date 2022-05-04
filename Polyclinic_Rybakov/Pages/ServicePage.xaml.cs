using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Polyclinic_Rybakov.DB;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Polyclinic_Rybakov.Pages
{
    public partial class ServicePage : Page
    {
        public static Service service = new Service();
        Doctor selDoc;
        Service ser;
        public ServicePage(Doctor doctor)
        {
            InitializeComponent();

            selDoc = doctor;

            ServiceCB.ItemsSource = MainWindow.dbPractik.Service.Where(c => c.Id_doctor == selDoc.Id_doctor).ToList();

            //Price.SelectAll = MainWindow.dbPractik.Service.Where(c => c.Id_doctor == selDoc.Id_doctor).ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client());
        }
         
        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            var a = ((Service)ServiceCB.SelectedItem).Name;
            var service = MainWindow.dbPractik.Service.Where(x => x.Name == a).FirstOrDefault();
            Price.Text = service.Price.ToString();
            Doctor.Text = service.Doctor.FullName;
            Cabinet.Text = service.Cabinet.Id_cabinet.ToString();
        }

        private void AppointmentBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
