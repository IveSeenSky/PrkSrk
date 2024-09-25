using BorAutoWorkers.AppData;
using BorAutoWorkers.Pages.AddPages;
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

namespace BorAutoWorkers.Pages.DataGridPages
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddUsersPage(null));
        }

        private void Btn_Ref_Click(object sender, RoutedEventArgs e)
        {
            usersDG.ItemsSource = Connection.context.Users.ToList();
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var delEmply = Connection.context.Users.Cast<Users>().ToList();
            if (MessageBox.Show($"Удалить {delEmply.Count} записей?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connection.context.Users.RemoveRange(delEmply);
            try
            {
                Connection.context.SaveChanges();
                usersDG.ItemsSource = Connection.context.Users.ToList();
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить изменения", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavFrame.Hframe.CanGoBack)
            {
                NavFrame.Hframe.GoBack();
            }
        }

        private void Btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddUsersPage((sender as Button).DataContext as Users));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            usersDG.ItemsSource = Connection.context.Users.ToList();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string searchInput = searchBox.Text;
                int searchInputInt = Convert.ToInt32(searchInput);
                if (typeOfSearch.SelectedItem != null)
                {
                    if (typeOfSearch.SelectedIndex == 0)
                    {
                        usersDG.ItemsSource = Connection.context.Users.Where(x => x.id == searchInputInt).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 1)
                    {
                        usersDG.ItemsSource = Connection.context.Users.Where(x => x.name == searchInput).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 2)
                    {
                        usersDG.ItemsSource = Connection.context.Users.Where(x => x.email == searchInput).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 4)
                    {
                        usersDG.ItemsSource = Connection.context.Users.Where(x => x.password == searchInput).ToList();
                    }
                    if(typeOfSearch.SelectedIndex == 5)
                    {
                        usersDG.ItemsSource = Connection.context.Users.Where(x => x.role_id == searchInputInt).ToList();
                    }
                }
            }
            catch { }
        }
    }
}
