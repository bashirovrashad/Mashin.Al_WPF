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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasinAl1.Views.PageViews
{
    /// <summary>
    /// Interaction logic for MyAccountPage.xaml
    /// </summary>
    public partial class MyAccountPage : Page
    {   public string Gmail {  get; set; }
        public List<Car> MyCars { get; set; }
        public MyAccountPage()
        {
            InitializeComponent();


            string jsonFilePath1 = "..\\..\\..\\DataBases\\cars.json";
            string jsonContent1 = File.ReadAllText(jsonFilePath1);
            var data = JsonConvert.DeserializeObject<List<Car>>(jsonContent1);
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Gmail != this.Gmail) data.Remove(data[i]);
            }
            MyCars = data;
            DataContext = this;
        }

        private void go_main(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            NavigationService.GoBack();
            NavigationService.GoBack();
            NavigationService.GoBack();
        }

        private void save(object sender, RoutedEventArgs e)

        {
            bool yoxla = false;
            string jsonFilePath1 = "..\\..\\..\\DataBases\\cars.json";
            string jsonContent1 = File.ReadAllText(jsonFilePath1);
            var data = JsonConvert.DeserializeObject<List<Car>>(jsonContent1);
            for (int i = 0; i < data.Count; i++)
            {
                if (this.Gmail != this.myTextBox1.Text) { data[i].Gmail = this.myTextBox1.Text;yoxla = true; }
               
            }
            
            if (yoxla) {
                string json = JsonConvert.SerializeObject(data);
                File.WriteAllText("..\\..\\..\\DataBases\\cars.json", json);
                MessageBox.Show("Ugurla Save Edildi"); }

        }



    }
}
