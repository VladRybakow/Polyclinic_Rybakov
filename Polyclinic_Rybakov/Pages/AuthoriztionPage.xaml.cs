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
        public AuthoriztionPage()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow taskWindow = new AuthorizationWindow();
            taskWindow.Show();
            //foreach (var user in AuthoriztionPage.dbPractik.User)
            //{
            //    if (user.Login == Login.Text.Trim())
            //    {
            //        if (user.Password == Password.Text.Trim() && user.Id_user != 1)
            //        {
            //            MessageBox.Show($"Здравствуйте, пользователь: {user.Login}");
            //            AuthoriztionPage.authUser = user;
            //            NavigationService.Navigate(new Client());
            //        }
            //        if (user.Password == Password.Text.Trim() && user.Id_user == 1)
            //        {
            //            MessageBox.Show($"Вход с правами администратора: {user.Login}");
            //            AuthoriztionPage.authUser = user;
            //            NavigationService.Navigate(new Emp());
            //        }
            //        aut = user.Id_user;
            //    }
            //}
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            //User user = new User();

            //try
            //{
            //    var qwe = AuthoriztionPage.dbPractik.User.FirstOrDefault(a => a.Login == Login.Text.Trim());
            //    if (qwe != null)
            //    {
            //        MessageBox.Show("Ошибка с вводом данных/такой пароль уже существует");
            //    }
            //    else
            //    {
            //        user.Login = Login.Text.Trim();
            //        user.Password = Password.Text.Trim();
            //        user.Id_user = 2;
            //    }

            //    AuthoriztionPage.dbPractik.User.Add(user);
            //    dbPractik.SaveChanges();
            //}
            //catch
            //{
            //    MessageBox.Show("Такой логин уже существует");
            //}
        }
    }
}
