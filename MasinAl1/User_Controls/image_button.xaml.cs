using MasinAl1.Models;
using MasinAl1.RelayCommands;
using MasinAl1.Views.WindowViews;
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

namespace MasinAl1.User_Controls
{
   
    public partial class image_button : UserControl
    {
     
        public image_button()
        {
            InitializeComponent();
        

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            if (myButton.DataContext is Car car)
            {
                ShowCarWindow showCarWindow = new ShowCarWindow();
                showCarWindow.bir.Content = car.Marka;
                showCarWindow.iki.Content = car.Model;
                showCarWindow.uc.Content = car.Mator;
                showCarWindow.dord.Content = car.Il;
                showCarWindow.alti.Content = car.Yurus;
                BitmapImage bitmapImage = new BitmapImage(new Uri(car.Sekiller[0], UriKind.RelativeOrAbsolute));
                showCarWindow.onsekil.Source = bitmapImage;
                showCarWindow.sekkiz.Content = car.Qiymet;
                showCarWindow.dogguz.Content = car.Mezenne;
                showCarWindow.on.Content = car.Il;
                showCarWindow.onbir.Content = car.Satis_seheri;
                showCarWindow.oniki.Content = car.Reng;
                showCarWindow.onuc.Content = car.At_gucu;
                showCarWindow.on4.Content = car.Ban_novu;
                showCarWindow.on5.Content = car.Suretler_qutusu;
                showCarWindow.on6.Content = car.Oturucu;
                showCarWindow.on7.Content = car.Yurus;
                showCarWindow.Show();
              
            }
          
        }
    }
}
