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
    /// Логика взаимодействия для AddPositionsPage.xaml
    /// </summary>
    public partial class AddPositionsPage : Page
    {
        Positions positions;
        bool checkNew;
        public AddPositionsPage(Positions c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new Positions();
                checkNew = true;
            }
            else
                checkNew = false;
            DataContext = positions = c;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                Connection.context.Positions.Add(positions);
            }
            try
            {
                Connection.context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить изменения", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            NavFrame.Hframe.Navigate(new PositionsPage());
        }
    }
}
