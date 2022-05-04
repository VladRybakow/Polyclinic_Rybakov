using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Polyclinic_Rybakov.DB;

namespace Polyclinic_Rybakov.Pages
{
    public partial class AuthoriztionPage : Page
    {
        public static User authUser;
        public AuthoriztionPage()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow taskWindow = new AuthorizationWindow();
            taskWindow.Show();
            taskWindow.Closed += (s, eventarg) =>
            {
                this.ReloadPage();
            };
        }

        public void Recording_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Emp());
        }
        public void ReloadPage() 
        {
            if (authUser.Id_user == 1)
            {
                LoginInBtn.Visibility = Visibility.Collapsed;
                Recording.Visibility = Visibility.Visible;
                admin.Visibility = Visibility.Visible;
                emp.Visibility = Visibility.Visible;
            }
            if (authUser.Id_user != 1)
            {
                LoginInBtn.Visibility = Visibility.Collapsed;
                Recording.Visibility = Visibility.Visible;
            }
        }
    }
}
