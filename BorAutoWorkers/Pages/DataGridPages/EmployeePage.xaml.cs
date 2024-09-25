using BorAutoWorkers.AppData;
using BorAutoWorkers.Pages.AddPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
            employeeDG.ItemsSource = Connection.context.Employee.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            employeeDG.ItemsSource = Connection.context.Employee.ToList();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddEmployeePage(null));
        }

        private void Btn_Ref_Click(object sender, RoutedEventArgs e)
        {
            employeeDG.ItemsSource = Connection.context.Employee.ToList();
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var delEmply = employeeDG.SelectedItems.Cast<Employee>().ToList();
            if (MessageBox.Show($"Удалить {delEmply.Count} записей?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) 
            Connection.context.Employee.RemoveRange(delEmply);
            try
            {
                Connection.context.SaveChanges();
                employeeDG.ItemsSource = Connection.context.Employee.ToList();
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить изменения", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavFrame.Hframe.CanGoBack) {
                NavFrame.Hframe.GoBack();
            }
        }

        private void Btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new AddEmployeePage((sender as Button).DataContext as Employee));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                searchBox.Foreground = Brushes.Black;
                string searchTxt = searchBox.Text;

                if (typeOfSearch.SelectedIndex == 0 || typeOfSearch.SelectedIndex == 2) // Поиск по id_storozha (целое число)
                {
                    int searchInt;
                    if (int.TryParse(searchTxt, out searchInt))
                    {
                        if (typeOfSearch.SelectedIndex == 0)
                        {
                            employeeDG.ItemsSource = Connection.context.Employee.Where(x => x.id.Equals(searchTxt)).ToList();
                        }
                        else if (typeOfSearch.SelectedIndex == 2)
                        {
                            employeeDG.ItemsSource = Connection.context.Employee.Where(x => x.position_id.Equals(searchTxt)).ToList();
                        }
                        else if (typeOfSearch.SelectedIndex == 3)
                        {
                            employeeDG.ItemsSource = Connection.context.Employee.Where(x => x.salary.Equals(searchTxt)).ToList();
                        }
                    }
                }
                else if (typeOfSearch.SelectedIndex == 1 || typeOfSearch.SelectedIndex == 3) 
                {
                    if (typeOfSearch.SelectedIndex == 1)
                    {
                        employeeDG.ItemsSource = Connection.context.Employee.Where(x => x.name.Contains(searchTxt)).ToList();
                    }
                }
            }
            catch
            {
                searchBox.Foreground = Brushes.Red;
            }
        }
    }
}
