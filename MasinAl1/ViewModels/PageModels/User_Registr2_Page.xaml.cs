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
    /// <summary>
    /// Interaction logic for User_Registr2_Page.xaml
    /// </summary>
    public partial class User_Registr2_Page : Page
    {
        public int random1 = 0;
        public string Gmail { get; set; }
        public User_Registr2_Page()
        {
            InitializeComponent();
        }

        private void back_button2(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        


        private void comfirm_button(object sender, RoutedEventArgs e)
        { if(random1.ToString()== this.text.Text) 
            {
                MyAccountPage myAccount = new MyAccountPage();
                myAccount.Gmail = this.Gmail;
                NavigationService?.Navigate(myAccount);
            }
           else { MessageBox.Show("Daxil Edilen Kod yanlisdir!!!"); }
        }


    }
}
