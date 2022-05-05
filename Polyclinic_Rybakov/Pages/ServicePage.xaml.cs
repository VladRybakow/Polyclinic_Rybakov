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
        public static PolyclinicEntities1 dbPractik = new PolyclinicEntities1();
        public static Applicationsss applicationsss = new Applicationsss();
        public static Service service = new Service();
        Doctor selDoc;
        public ServicePage(Doctor doctor)
        {
            InitializeComponent();

            selDoc = doctor;
            var gg = (from ser in dbPractik.Service where ser.Id_doctor == selDoc.Id_doctorType select ser).ToList();
            ServiceCB.ItemsSource = gg;
            ServiceCB.DisplayMemberPath = "Name";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client());
        }
         
        public void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            var a = ((Service)ServiceCB.SelectedItem).Name;
            var service = MainWindow.dbPractik.Service.Where(x => x.Name == a).FirstOrDefault();
            Price.Text = service.Price.ToString();
            Doctor.Text = service.Doctor.FullName;
            Cabinet.Text = service.Cabinet.Id_cabinet.ToString();
        }

        private void AppointmentBTN_Click(object sender, RoutedEventArgs e)
        {
            //Applicationsss applicationsss = new Applicationsss();

            //try
            //{
            //    var rer = ServicePage.dbPractik.Applicationsss.FirstOrDefault(a => a.Id_application.ToString() == Cabinet.Text.Trim());

            //    if (rer != null)
            //    {
            //        MessageBox.Show("AAAAAAAAAAAA");
            //    }
            //    else
            //    {
            //        applicationsss.Id_cabinet = service.Cabinet.Id_cabinet;
            //        applicationsss.Id_doctor = service.Doctor.Id_doctor;

            //        ServicePage.dbPractik.Applicationsss.Add(applicationsss);
            //        dbPractik.SaveChanges();
            //        MessageBox.Show("Заявка отправлена");
            //    }
            //}

            //catch
            //{
            //    MessageBox.Show("Ошибка с отправкой");
            //}


        }
    }
}
