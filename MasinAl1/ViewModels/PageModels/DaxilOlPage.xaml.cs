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

namespace MasinAl1.Views.PageViews
{
   
    public partial class DaxilOlPage : Page
    {
        public DaxilOlPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        

        private void User_Click(object sender, RoutedEventArgs e)
        {
            User_Registr_Page user_Registr_Page = new User_Registr_Page();
            NavigationService?.Navigate(user_Registr_Page);
        }


    }
}
