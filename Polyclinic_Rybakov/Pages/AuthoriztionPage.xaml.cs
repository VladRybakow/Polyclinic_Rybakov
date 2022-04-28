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
        public static PolyclinicEntities dbPractik = new PolyclinicEntities();
        public static User authUser;

        public static int aut { get; set; }
        public AuthoriztionPage()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in AuthoriztionPage.dbPractik.User)
            {
                if (user.Login == Login.Text.Trim())
                {
                    if (user.Password == Password.Text.Trim() && user.Id_user != 1)
                    {
                        MessageBox.Show($"Здравствуйте, пользователь: {user.Login}");
                        AuthoriztionPage.authUser = user;
                        //NavigationService.Navigate(new ());
                    }
                    if (user.Password == Password.Text.Trim() && user.Id_user == 1)
                    {
                        MessageBox.Show($"Вход с правами администратора: {user.Login}");
                        AuthoriztionPage.authUser = user;
                        //NavigationService.Navigate(new ());
                    }
                    aut = user.Id_user;
                }
            }
        }
    }
}
