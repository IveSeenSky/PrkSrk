using BorAutoWorkers.AppData;
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

namespace BorAutoWorkers.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            //ImageBrush backgroundBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/BackGroundImage.png")));
            //backgroundBrush.Opacity = 0.1; 
            //this.Background = backgroundBrush;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var currectUser = Connection.context.Users.FirstOrDefault(x => x.name == txtLogin.Text);
            if (Connection.context.Users.FirstOrDefault(x => x.password == txtPswrd.Password) != null &&
                Connection.context.Users.FirstOrDefault(x => x.name == txtLogin.Text) != null ||
                Connection.context.Users.FirstOrDefault(x => x.email == txtLogin.Text) != null) {
                var currectRole = Connection.context.Roles.FirstOrDefault(x => x.id == currectUser.role_id);
                if (currectRole != null) {
                    PriorityLVL.RoleId = currectRole.id;
                    PriorityLVL.Priority = currectRole.priority;
                    NavFrame.Mframe.Navigate(new MenuPage());
                } else {
                    MessageBox.Show("Не удалось получить данные о правах пользователя", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            } else {
                MessageBox.Show("Не верный логин или пароль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
