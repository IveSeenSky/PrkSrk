using BorAutoWorkers.AppData;
using BorAutoWorkers.Pages.DataGridPages;
using BorAutoWorkers.Pages.MenuFrames;
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

namespace BorAutoWorkers.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            NavFrame.Hframe = HireFrame;
            NavFrame.Vframe = VireFrame;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (PriorityLVL.RoleId == 1)
            {
                NavFrame.Vframe.Navigate(new MenuAdminFrame());
            }
            else if (PriorityLVL.RoleId == 2)
            {
                NavFrame.Vframe.Navigate(new MenuUserFrame());
            } else
            {
                NavFrame.Vframe.Navigate(new MenuAdminFrame());
            }
        }

    }
}
