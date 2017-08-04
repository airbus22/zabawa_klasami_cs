using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawa_klasami_cs
{
    public class Program : Samochod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolor jest: ");
            
            Console.ReadKey();
        }

        public void test_wypisu(string t, string m, string k, int s, string p, string poj, string w, string u)
        {
            Samochod Osobowy = new Samochod();
            Osobowy.typ = t;
            Osobowy.marka = m;
            Osobowy.kolor = k;
            Osobowy.silnik = s;
            Osobowy.paliwo = p;
            Osobowy.pojemnosc = poj;
            Osobowy.wiek = w;
            Osobowy.uwagi = u;
        }
        
        Console.WriteLine("coś");
        
    }
}
