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
    /// Логика взаимодействия для PositionsPage.xaml
    /// </summary>
    public partial class PositionsPage : Page
    {
        public PositionsPage()
        {
            InitializeComponent();
            positionDG.ItemsSource = Connection.context.Positions.ToList();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddPositionsPage(null));
        }

        private void Btn_Ref_Click(object sender, RoutedEventArgs e)
        {
            positionDG.ItemsSource = Connection.context.Positions.ToList();
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var delEmply = positionDG.SelectedItems.Cast<Positions>().ToList();
            if (MessageBox.Show($"Удалить {delEmply.Count} записей?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connection.context.Positions.RemoveRange(delEmply);
            try
            {
                Connection.context.SaveChanges();
                positionDG.ItemsSource = Connection.context.Positions.ToList();
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
            NavFrame.Hframe.Navigate(new AddPositionsPage((sender as Button).DataContext as Positions));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            positionDG.ItemsSource = Connection.context.Positions.ToList();
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
                        positionDG.ItemsSource = Connection.context.Positions.Where(x => x.id == searchInputInt).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 1)
                    {
                        positionDG.ItemsSource = Connection.context.Positions.Where(x => x.name == searchInput).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 2)
                    {
                        positionDG.ItemsSource = Connection.context.Positions.Where(x => x.stage_id == searchInputInt).ToList();
                    }
                }
            }
            catch { }
        }
    }
}
