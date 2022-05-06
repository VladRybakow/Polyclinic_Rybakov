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
    public partial class BidPage : Page
    {
        public static PolyclinicEntities1 dbPractik = new PolyclinicEntities1();
        Doctor Doc;
        public BidPage(Doctor doctor)
        {
            InitializeComponent();
            Doc = doctor;
            Bid.ItemsSource = (from ap in dbPractik.Applicationsss
                                   join ser in dbPractik.Service on ap.Id_service equals ser.Id_service
                                   where ap.Id_service == ser.Id_service
                                   where ap.Id_doctor == Doc.Id_doctor
                                   select ser).ToList();
        }

        private void ChekBTN_Click(object sender, RoutedEventArgs e)
        {
            var gg = Bid.SelectedItem as Service;
            gg.Name = Name.Text;
            gg.Price = Convert.ToDouble(Price.Text);
            gg.Id_cabinet = Convert.ToInt32(Cabinet.Text);
            var rt = (from ap in dbPractik.Applicationsss
                      where ap.Id_doctor == Doc.Id_doctor
                      where ap.Id_service == gg.Id_service
                      select ap).First();
            rt.Status = Rt.Text;
            var dot = (from doc in dbPractik.Doctor
                       where doc.Id_doctor == gg.Id_doctor
                       select doc).First();
            dot.FullName = Doctor.Text;
            dbPractik.SaveChanges();

        }

        private void Bid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = Bid.SelectedItem as Service;
            Name.Text = gg.Name;
            Price.Text = gg.Price.ToString();
            Cabinet.Text = gg.Id_cabinet.ToString();
            Rt.Text = (from ap in dbPractik.Applicationsss
                       where ap.Id_doctor == Doc.Id_doctor
                       where ap.Id_service == gg.Id_service
                       select ap.Status).First();
            Doctor.Text = (from doc in dbPractik.Doctor
                           where doc.Id_doctor == gg.Id_doctor
                           select doc.FullName).First();
        }
    }
}
