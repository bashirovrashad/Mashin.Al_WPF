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

namespace MasinAl1.ViewModels.WindowModels
{
    /// <summary>
    /// Interaction logic for NomreWindow.xaml
    /// </summary>
    /// 
    public partial class NomreWindow : Window
    {
        public ObservableCollection<Nomre> nomreler { get; set; }
        public NomreWindow()
        {
            InitializeComponent();
            string jsonFilePath3 = "..\\..\\..\\DataBases\\nomreler.json";

            string jsonContent3 = File.ReadAllText(jsonFilePath3);
            var data3 = JsonConvert.DeserializeObject<ObservableCollection<Nomre>>(jsonContent3);

            nomreler = data3;
            DataContext = this;
        }
    }
}
