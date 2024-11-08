using MasinAl1.Models;
using MasinAl1.RelayCommands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
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
    /// Interaction logic for VipCarsWindow.xaml
    /// </summary>
    public partial class VipCarsWindow : Window
    {
        public ObservableCollection<Car> ON_Cars { get; set; }
        
        public VipCarsWindow()
        {
            InitializeComponent();
          
            string jsonFilePath2 = "..\\..\\..\\DataBases\\one_cek_cars.json";

            string jsonContent2 = File.ReadAllText(jsonFilePath2);                 
            var data2 = JsonConvert.DeserializeObject<ObservableCollection<Car>>(jsonContent2);

            ON_Cars = data2;
            DataContext = this;

        }

       

    }
   
}
