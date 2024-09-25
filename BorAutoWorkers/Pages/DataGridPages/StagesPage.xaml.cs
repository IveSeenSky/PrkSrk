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
    /// Логика взаимодействия для StagesPage.xaml
    /// </summary>
    public partial class StagesPage : Page
    {
        public StagesPage()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddStagesPage(null));
        }

        private void Btn_Ref_Click(object sender, RoutedEventArgs e)
        {
            stagesDG.ItemsSource = Connection.context.Stages.ToList();
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var delEmply = stagesDG.SelectedItems.Cast<Stages>().ToList();
            if (MessageBox.Show($"Удалить {delEmply.Count} записей?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connection.context.Stages.RemoveRange(delEmply);
            try
            {
                Connection.context.SaveChanges();
                stagesDG.ItemsSource = Connection.context.Stages.ToList();
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            stagesDG.ItemsSource = Connection.context.Stages.ToList();
        }

        private void Btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddStagesPage((sender as Button).DataContext as Stages));
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
                        stagesDG.ItemsSource = Connection.context.Stages.Where(x => x.id == searchInputInt).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 1)
                    {
                        stagesDG.ItemsSource = Connection.context.Stages.Where(x => x.name == searchInput).ToList();
                    }
                    if (typeOfSearch.SelectedIndex == 2)
                    {
                        stagesDG.ItemsSource = Connection.context.Stages.Where(x => x.stage == searchInput).ToList();
                    }
                }
            }
            catch { }
        }
    }
}
