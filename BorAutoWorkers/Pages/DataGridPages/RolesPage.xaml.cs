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
    /// Логика взаимодействия для RolesPage.xaml
    /// </summary>
    public partial class RolesPage : Page
    {
        public RolesPage()
        {
            InitializeComponent();
            rolesDG.ItemsSource = Connection.context.Roles.ToList();
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var delEmply = rolesDG.SelectedItems.Cast<Roles>().ToList();
            if (MessageBox.Show($"Удалить {delEmply.Count} записей?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connection.context.Roles.RemoveRange(delEmply);
            try
            {
                Connection.context.SaveChanges();
                rolesDG.ItemsSource = Connection.context.Roles.ToList();
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить изменения", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddRolesPage(null));
        }

        private void Btn_Ref_Click(object sender, RoutedEventArgs e)
        {
            rolesDG.ItemsSource = Connection.context.Roles.ToList();
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
            NavFrame.Hframe.Navigate(new AddRolesPage((sender as Button).DataContext as Roles));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            rolesDG.ItemsSource = Connection.context.Roles.ToList();
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
                        rolesDG.ItemsSource = Connection.context.Roles.Where(x => x.id == searchInputInt).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 1)
                    {
                        rolesDG.ItemsSource = Connection.context.Roles.Where(x => x.priority == searchInput).ToList();
                    }
                }
            }
            catch { }
        }
    }
}
