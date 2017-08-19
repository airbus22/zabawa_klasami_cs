using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawa_klasami_cs
{
    public class Samochod
    {
        public string Typ { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }   
        public string Kolor { get; set; }
        public string Silnik { get; set; }
        public string Paliwo { get; set; }
        public double Pojemnosc { get; set; }
        public int RokProdukcji { get; set; }
        public string Uwagi { get; set; }             
    }

    public class Motor
    {
        public string Typ { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
    }
}
