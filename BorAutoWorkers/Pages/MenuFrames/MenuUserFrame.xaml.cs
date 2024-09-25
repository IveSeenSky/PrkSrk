using BorAutoWorkers.AppData;
using BorAutoWorkers.Pages.DataGridPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BorAutoWorkers.Pages.MenuFrames
{
    /// <summary>
    /// Логика взаимодействия для MenuUserFrame.xaml
    /// </summary>
    public partial class MenuUserFrame : Page
    {
        public MenuUserFrame()
        {
            InitializeComponent();
        }

        private void pagesBtn_Click(object sender, RoutedEventArgs e)
        {
            Popup myPopup = (Popup)this.FindResource("MyPopupTables");
            myPopup.PlacementTarget = sender as Button;
            myPopup.IsOpen = true;
        }

        private void optPositionsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new PositionsPage());
        }

        private void optEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new EmployeePage());
        }

        private void optRolesBtn_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new RolesPage());
        }
        private void optStagesBtn_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Hframe.Navigate(new StagesPage());
        }

        private void otchEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Reports.Reports reports = new Reports.Reports();
            reports.Employees();
        }

        private void otchBtn_Click(object sender, RoutedEventArgs e)
        {
            Popup myPopup = (Popup)this.FindResource("MyPopupOtcheti");
            myPopup.PlacementTarget = sender as Button;
            myPopup.IsOpen = true;
        }

        private void otchPositionsBtn_Click(object sender, RoutedEventArgs e)
        {
            Reports.Reports reports = new Reports.Reports();
            reports.Positions();
        }

        private void otchStagesBtn_Click(object sender, RoutedEventArgs e)
        {
            Reports.Reports reports = new Reports.Reports();
            reports.Stages();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void srchBtn_Click(object sender, RoutedEventArgs e)
        {
            Popup myPopup = (Popup)this.FindResource("MyPopupSearch");
            myPopup.PlacementTarget = sender as Button;
            myPopup.IsOpen = true;
        }

        private void copyBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}