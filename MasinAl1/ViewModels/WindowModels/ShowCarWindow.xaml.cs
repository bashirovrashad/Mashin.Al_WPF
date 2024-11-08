using MasinAl1.Models;
using MasinAl1.RelayCommands;
using MasinAl1.User_Controls;
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
using System.Windows.Shapes;

namespace MasinAl1.Views.WindowViews
{
    /// <summary>
    /// Interaction logic for ShowCarWindow.xaml
    /// </summary>
    public partial class ShowCarWindow : Window
    {
        public Car OtherCar { get; set; }
        public ShowCarWindow()
        {
            InitializeComponent();
           
        }



    }
}
