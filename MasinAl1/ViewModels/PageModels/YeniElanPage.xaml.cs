using MasinAl1.Models;
using Microsoft.Win32;
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
    /// Interaction logic for YeniElanPage.xaml
    /// </summary>
    public partial class YeniElanPage : Page
    {
        public Car other = new();
        public string[] sekiller1 = new string[1];
        public YeniElanPage()
        {
            InitializeComponent();
        }

        private void sekil(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png|Tüm Dosyalar|*.*";
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    MessageBox.Show("Sekil Ugurla Saxlanildi.");
                    string yol =  openFileDialog.FileName;
                    sekiller1[0] = yol;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
           
        }
        
        private void elave_masin(object sender, RoutedEventArgs e)
        {

            if (!(string.IsNullOrEmpty(bir.Text) && string.IsNullOrEmpty(iki.Text) && string.IsNullOrEmpty(uc.Text) && string.IsNullOrEmpty(dord.Text) && string.IsNullOrEmpty(bes.Text) && string.IsNullOrEmpty(alti.Text) &&
                string.IsNullOrEmpty(yeddi.Text) && string.IsNullOrEmpty(dukkuz.Text) && string.IsNullOrEmpty(on.Text) && string.IsNullOrEmpty(on1.Text)))
            {
                other.Sekiller = sekiller1;
                other.Marka = bir.Text;
                other.Model = iki.Text;
                other.Il = uc.Text;
                other.Ban_novu = dord.Text;
                other.Yanacaq = bes.Text;
                other.Oturucu = alti.Text;
                other.Suretler_qutusu = yeddi.Text;
                if (on3.IsChecked == true) other.Veziyyet = true;
                else other.Veziyyet = false;
                if (on2.IsChecked == true) other.Mezenne = "AZN";
                else other.Mezenne = "USD";
                other.Reng = dukkuz.Text;
                other.Qiymet = float.Parse(on1.Text);


                string jsonFilePath1 = "..\\..\\..\\DataBases\\cars.json";
                string jsonContent1 = File.ReadAllText(jsonFilePath1);
                var data1 = JsonConvert.DeserializeObject<ObservableCollection<Car>>(jsonContent1);
                data1.Add(other);
                string json = JsonConvert.SerializeObject(data1);
                File.WriteAllText("..\\..\\..\\DataBases\\cars.json", json);
                MessageBox.Show("Masin Ugurla Yaradildi.");
                NavigationService.GoBack();
            }

            else MessageBox.Show("Xanalari Tam Doldurun");

        }
            



        private void go_main_button(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        
    }
}
