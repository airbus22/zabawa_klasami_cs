using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawa_klasami_cs
{
    public class Program : Samochod
    {
        Samochod Osobowy = new Samochod();

        static void Main(string[] args)
        {
            Console.WriteLine("..");            
            Console.ReadKey();            
        }

        //public void test_wypisu(string t, string m, string k, int s, string p, string poj, string w, string u)
        //{            
        //    Osobowy.typ = t;
        //    Osobowy.marka = m;
        //    Osobowy.kolor = k;
        //    Osobowy.silnik = s;
        //    Osobowy.paliwo = p;
        //    Osobowy.pojemnosc = poj;
        //    Osobowy.wiek = w;
        //    Osobowy.uwagi = u;
        //}

        public void test_wypisu()
        {
            Osobowy.typ = "Hathback";
            Osobowy.marka = "Toyota";
            Osobowy.model = "Auris";
            Osobowy.kolor = "grafitowy";
            Osobowy.silnik = "V4 8V";
            Osobowy.paliwo = "Olej napędowy";
            Osobowy.pojemnosc = 1.4;
            Osobowy.rokProdukcji = 2011;
            Osobowy.uwagi = "super wóz - uwag brak";
        }

        public void wyswietNaEkran()
        {
            test_wypisu();
            Console.WriteLine("Wyniki wyszukiwania:");
            Console.WriteLine(Osobowy.typ.ToString());
            Console.WriteLine(Osobowy.marka.ToString());
            Console.WriteLine(Osobowy.model.ToString());
            Console.WriteLine(Osobowy.kolor.ToString());
            Console.WriteLine(Osobowy.silnik.ToString());
            Console.WriteLine(Osobowy.paliwo.ToString());
            Console.WriteLine(Osobowy.pojemnosc.ToString());
            Console.WriteLine(Osobowy.rokProdukcji.ToString());
            Console.WriteLine(Osobowy.uwagi.ToString());
        }
    }
}
