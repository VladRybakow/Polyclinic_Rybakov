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
    public partial class AdminPage : Page
    {
        public static PolyclinicEntities1 dbPractik = new PolyclinicEntities1();
        public static DoctorType doctor = new DoctorType();
        public AdminPage()
        {
            InitializeComponent();

            DocRP.ItemsSource = MainWindow.dbPractik.Doctor.ToList();

            TypeSpec.ItemsSource = dbPractik.DoctorType.ToList();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctor = new Doctor();
            try
            {
                var rer = AdminPage.dbPractik.Doctor.FirstOrDefault(a => a.FullName ==  FullName.Text.Trim());
                if (rer != null)
                {
                    MessageBox.Show("Ошибка с вводом");
                }
                else
                {
                    doctor.FullName = FullName.Text.Trim();
                    doctor.Telephone = Telephone.Text.Trim();
                    doctor.DoctorType = TypeSpec.SelectedItem as DoctorType;
                    AdminPage.dbPractik.Doctor.Add(doctor);
                    dbPractik.SaveChanges();
                    MessageBox.Show("Сотрудник сохранен");
                }
            }
            catch
            {
                MessageBox.Show("Такой сотрудник уже есть");
            }
        }

        //private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        //{
        //    var qwe = DocRP.SelectedItem as Doctor;
        //    AdminPage.dbPractik.Doctor.Remove(qwe);
        //    dbPractik.SaveChanges();
        //    DocRP.ItemsSource = MainWindow.dbPractik.Doctor.ToList();
        //}
    }
}
