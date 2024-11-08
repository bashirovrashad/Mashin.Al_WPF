using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasinAl1.Models
{
   public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public float Mator { get; set; }
        public float At_gucu  { get; set; }
        public float    Qiymet { get; set; }
        public string    Mezenne { get; set; }
        public string Il { get; set; }
        public int Yurus { get; set; }
        public string Ban_novu { get; set; }
        public string Yanacaq { get; set; }
        public string Satis_seheri { get; set; }
        public string Oturucu { get; set; }
        public string Reng { get; set; }
        public string Suretler_qutusu { get; set; }
        public bool Barter { get; set; }
        public bool Veziyyet { get; set; }
        public bool Icare { get; set; }
        public bool Kredit { get; set; }
        public string[] Sekiller {  get; set; } 
        public string Elave_Melumat {  get; set; } 
        public string Gmail {  get; set; } 
      
        public Car() { }
        public Car(string marka , string model , float mator ,float guc, float qiymet,string mezenne, string il , int yurus , string ban , string yanacaq ,string seher , string oturucu , string reng , string qutu, bool barter ,bool veziyyet, bool icare , bool kredit, string[] sekiller, string elave,string gmail)
        {
            Marka = marka;
            Model = model;
            Mator = mator;
            At_gucu = guc;
            Qiymet = qiymet;
            Mezenne = mezenne;
            Il = il;
            Yurus = yurus;
            Ban_novu = ban;
            Yanacaq = yanacaq;
            Satis_seheri = seher;
            Oturucu = oturucu;
            Reng = reng;
            Suretler_qutusu = qutu;
            Barter = barter;
            Veziyyet = veziyyet;
            Icare = icare;
            Kredit = kredit;
            Sekiller = sekiller;
            Elave_Melumat = elave;
            Gmail = gmail;
          
        }



    }
}
