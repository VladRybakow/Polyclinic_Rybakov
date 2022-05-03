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
        public int yy = AuthorizationWindow.authOk;
        public AuthoriztionPage()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow taskWindow = new AuthorizationWindow();
            taskWindow.Show();
        }

        public void Recording_Click(object sender, RoutedEventArgs e)
        {
            yy = AuthorizationWindow.authOk;
            if (yy > 2)
            {
                NavigationService.Navigate(new Client());
            }
            else
            {
                MessageBox.Show("Сначала зарегистрируйтесь");
            }
        }
    }
}
