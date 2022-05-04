using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Polyclinic_Rybakov.DB;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace Polyclinic_Rybakov.Pages
{
    public partial class AuthorizationWindow : Window
    {
        public static PolyclinicEntities dbPractik = new PolyclinicEntities();
        public AuthoriztionPage auth = new AuthoriztionPage();
        public static User authUser;
        public static int aut { get; set; }

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in AuthorizationWindow.dbPractik.User)
            {
                if (user.Login == Login.Text.Trim() && user.Password == Password.Text.Trim())
                {

                    AuthoriztionPage.authUser = user;
                    this.Close();
                }
            }
        }

        private void RegistButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            try
            {
                var qwe = AuthorizationWindow.dbPractik.User.FirstOrDefault(a => a.Login == Login.Text.Trim());
                if (qwe != null)
                {
                    MessageBox.Show("Ошибка с вводом данных/такой пароль уже существует");
                }
                else
                {
                    user.Login = Login.Text.Trim();
                    user.Password = Password.Text.Trim();
                    user.Id_user = 2;

                    AuthorizationWindow.dbPractik.User.Add(user);
                    dbPractik.SaveChanges();
                    MessageBox.Show("Пользователь сохранен");
                }
            }
            catch
            {
                MessageBox.Show("Такой логин уже существует");
            }
        }
    }
}
