using MasinAl1.Models;
using MasinAl1.RelayCommands;
using MasinAl1.ViewModels.WindowModels;
using MasinAl1.Views.PageViews;
using MasinAl1.Views.WindowViews;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasinAl1
{
   
    public partial class MainWindow : NavigationWindow
    {
        public ObservableCollection<string> adlar { get; set; }
        public ObservableCollection<string> adlar2 { get; set; }
      
        public ObservableCollection<Car> Cars { get; set; }
        public ObservableCollection<Car> ON_Cars { get; set; }
        public ObservableCollection<Nomre> nomreler { get; set; }
        public ObservableCollection<string> iller { get; set; }
        public ObservableCollection<string> iller2 { get; set; }
        public ObservableCollection<string> hecm { get; set; }
        public ObservableCollection<string> hecm2 { get; set; }


        public ICommand OpenAllCarsWindowCommand { get; }

        public ICommand OpenVipCarsWindowCommand { get; }
        public ICommand OpenNomreWindowCommand { get; }
      
        public MainWindow()
        {
            InitializeComponent();


            OpenAllCarsWindowCommand = new RelayCommand(OpenAllCarsWindow);
            OpenVipCarsWindowCommand = new RelayCommand(OpenVipCarsWindow);
            OpenNomreWindowCommand = new RelayCommand(OpenNomreWindow);
            
            string jsonFilePath = "..\\..\\..\\DataBases\\adlar.json";
            string jsonFilePath8 = "..\\..\\..\\DataBases\\adlar2.json";
            string jsonFilePath1 = "..\\..\\..\\DataBases\\cars.json";
            string jsonFilePath2 = "..\\..\\..\\DataBases\\one_cek_cars.json";
            string jsonFilePath3 = "..\\..\\..\\DataBases\\nomreler.json";
            string jsonFilePath4 = "..\\..\\..\\DataBases\\iller.json";
            string jsonFilePath5 = "..\\..\\..\\DataBases\\iller2.json";
            string jsonFilePath6 = "..\\..\\..\\DataBases\\hecm.json";
            string jsonFilePath7 = "..\\..\\..\\DataBases\\hecm2.json";
            string jsonFilePath9 = "..\\..\\..\\DataBases\\modeller.json";

           
            string jsonContent = File.ReadAllText(jsonFilePath);
            string jsonContent1 = File.ReadAllText(jsonFilePath1);
            string jsonContent2 = File.ReadAllText(jsonFilePath2);
            string jsonContent3 = File.ReadAllText(jsonFilePath3);
            string jsonContent4 = File.ReadAllText(jsonFilePath4);
            string jsonContent5 = File.ReadAllText(jsonFilePath5);
            string jsonContent6 = File.ReadAllText(jsonFilePath6);
            string jsonContent7 = File.ReadAllText(jsonFilePath7);
            string jsonContent8 = File.ReadAllText(jsonFilePath8);
            string jsonContent9 = File.ReadAllText(jsonFilePath9);

            var data = JsonConvert.DeserializeObject<ObservableCollection<string>>(jsonContent);
            var data1 = JsonConvert.DeserializeObject<ObservableCollection<Car>>(jsonContent1);
            var data2 = JsonConvert.DeserializeObject<ObservableCollection<Car>>(jsonContent2);
            var data3 = JsonConvert.DeserializeObject<ObservableCollection<Nomre>>(jsonContent3);
            var data4 = JsonConvert.DeserializeObject<ObservableCollection<string>>(jsonContent4);
            var data5 = JsonConvert.DeserializeObject<ObservableCollection<string>>(jsonContent5);
            var data6 = JsonConvert.DeserializeObject<ObservableCollection<string>>(jsonContent6);
            var data7 = JsonConvert.DeserializeObject<ObservableCollection<string>>(jsonContent7);
            var data8 = JsonConvert.DeserializeObject<ObservableCollection<string>>(jsonContent8);
            var data9 = JsonConvert.DeserializeObject<List<string[]>>(jsonContent9);

          
            adlar = data;
            adlar2 = data8;
            Cars = data1;
            ON_Cars = data2;
            nomreler = data3;
            iller = data4;
            iller2 = data5;
            hecm = data6;
            hecm2 = data7;
           
            DataContext = this;

        }


        private void OpenAllCarsWindow(object parameter)
        {
            AllCarsWindow secondWindow = new AllCarsWindow();
            secondWindow.Show();
        }


        private void OpenVipCarsWindow(object parameter)
        {
            VipCarsWindow vipWindow = new VipCarsWindow();
            vipWindow.Show();
        }

        private void OpenNomreWindow(object parameter)
        {
            NomreWindow nomreWindow = new NomreWindow();
            nomreWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DaxilOlPage yeniSayfa = new DaxilOlPage();
            this.Content = yeniSayfa;
        }
        private void yeniElan(object sender, RoutedEventArgs e)
        {
            YeniElanPage yeniSayfa = new YeniElanPage();
            this.Content = yeniSayfa;
        }



    }
}
