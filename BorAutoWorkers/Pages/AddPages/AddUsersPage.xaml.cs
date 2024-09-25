using BorAutoWorkers.AppData;
using BorAutoWorkers.Pages.DataGridPages;
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

namespace BorAutoWorkers.Pages.AddPages
{
    /// <summary>
    /// Логика взаимодействия для AddUsersPage.xaml
    /// </summary>
    public partial class AddUsersPage : Page
    {
        Users users;
        bool checkNew;
        public AddUsersPage(Users c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new Users();
                checkNew = true;
            }
            else
                checkNew = false;
            DataContext = users = c;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                Connection.context.Users.Add(users);
            }
            try
            {
                Connection.context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить изменения", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            NavFrame.Hframe.Navigate(new UsersPage());
        }
    }
}
