using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawa_klasami_cs
{
    public class Program
    {
        Samochod Osobowy = new Samochod();

        static void Main(string[] args)
        {
            Samochod gbCar = new Samochod();
            gbCar.Kolor = "Zielony";
            gbCar.Marka = "Trabant";
            gbCar.Model = "601s";
            
            //Console.WriteLine("Podaj rodzaj paliwa: ");
            //gbCar.Paliwo = Console.ReadLine();

            Console.WriteLine("Podaj pojemność: ");
            gbCar.Pojemnosc = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj rok produkcji: ");
            gbCar.RokProdukcji = int.Parse(Console.ReadLine());

            Console.WriteLine("Kolor: " + gbCar.Kolor);
            Console.WriteLine("Marka: " + gbCar.Marka);

            if (gbCar.Model != null)
                Console.WriteLine("Model: " + gbCar.Model);
            else
                Console.WriteLine("nie zdefiniowano");

            Console.WriteLine("Paliwo: " + gbCar.Paliwo);
            Console.WriteLine("Pojemność: " + gbCar.Pojemnosc);
            Console.WriteLine("Rok produkcji: " + gbCar.RokProdukcji);
            Console.WriteLine("Silnik: " + gbCar.Silnik);
            Console.WriteLine("Typ: " + gbCar.Typ);
            Console.WriteLine("Uwagi: " + gbCar.Uwagi);

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

        public void Test_wypisu()
        {
            Osobowy.Typ = "Hatchback";
            Osobowy.Marka = "Toyota";
            //Osobowy.Model = "Auris";
            Osobowy.Kolor = "grafitowy";
            Osobowy.Silnik = "V4 8V";
            Osobowy.Paliwo = "Olej napędowy";
            Osobowy.Pojemnosc = 1.4;
            Osobowy.RokProdukcji = 2011;
            Osobowy.Uwagi = "super wóz - uwag brak";
        }

        public void WyswietNaEkran()
        {
            Test_wypisu();
            Console.WriteLine("Wyniki wyszukiwania:");
            Console.WriteLine(Osobowy.Typ.ToString());
            Console.WriteLine(Osobowy.Marka.ToString());
            Console.WriteLine(Osobowy.Model.ToString());
            Console.WriteLine(Osobowy.Kolor.ToString());
            Console.WriteLine(Osobowy.Silnik.ToString());
            Console.WriteLine(Osobowy.Paliwo.ToString());
            Console.WriteLine(Osobowy.Pojemnosc.ToString());
            Console.WriteLine(Osobowy.RokProdukcji.ToString());
            Console.WriteLine(Osobowy.Uwagi.ToString());
        }
    }
}