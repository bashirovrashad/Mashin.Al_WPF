using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasinAl1.Models
{
    public class Nomre
    {
        public string Name { get; set; }
        public float Qiymet { get; set; }
        public string Seher { get; set; }
        public string Sekil { get; set; }
       // public DateTime Zaman { get; set; }


        public Nomre() { }
        public Nomre(string name , float qiymet,string seher,string sekil) 
        {
            Name = name;
            Qiymet = qiymet;
            Seher = seher;
            Sekil = sekil;
          //  Zaman = zaman;
        }
    }
}
