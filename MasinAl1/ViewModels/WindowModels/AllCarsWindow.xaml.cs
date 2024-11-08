using MasinAl1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// Interaction logic for AllCarsWindow.xaml
    /// </summary>
    public partial class AllCarsWindow : Window
    {
        public ObservableCollection<Car> Cars { get; set; }
        public AllCarsWindow()
        {
            InitializeComponent();
            string jsonFilePath1 = "..\\..\\..\\DataBases\\cars.json";                 
            string jsonContent1 = File.ReadAllText(jsonFilePath1);                  
            var data1 = JsonConvert.DeserializeObject<ObservableCollection<Car>>(jsonContent1);
            Cars = data1;
            DataContext = this;
        }
    }
}
