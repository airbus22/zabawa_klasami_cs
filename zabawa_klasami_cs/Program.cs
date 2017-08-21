using System;

namespace zabawa_klasami_cs
{
    public class Program
    {
        static void Main(string[] args)
        {            
            //Samochod gbCar = new Samochod();
            //gbCar.Kolor = "Zielony";
            //gbCar.Marka = "Trabant";
            //gbCar.Model = "601s";
            Samochod gbCar = new Samochod()
            {
                Kolor = "Zielony",
                Marka = "Trabant",
                Model = "601s"
            };

            Console.WriteLine("Podaj rodzaj paliwa: ");
            gbCar.Paliwo = Console.ReadLine();

            Console.WriteLine("Podaj pojemność: ");
            gbCar.Pojemnosc = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj rok produkcji: ");
            gbCar.RokProdukcji = int.Parse(Console.ReadLine());

            Console.WriteLine("Silnik: ");
            gbCar.Silnik = Console.ReadLine();

            Console.WriteLine("Typ: ");
            gbCar.Typ = Console.ReadLine();

            Console.WriteLine("Uwagi: ");
            gbCar.Uwagi = Console.ReadLine();

            Console.Clear();

            if (gbCar.Kolor != null)
            {
                Console.WriteLine("Kolor: " + gbCar.Kolor);
            }
            else
            {
                Console.WriteLine("Kolor: nie zdefiniowano");
            }

            if (gbCar.Marka != null)
            {
                Console.WriteLine("Marka: " + gbCar.Marka);
            }
            else
            {
                Console.WriteLine("Marka: nie zdefiniowano");
            }

            if (gbCar.Model != null)
            {
                Console.WriteLine("Model: " + gbCar.Model);
            }
            else
            {
                Console.WriteLine("Model: nie zdefiniowano");
            }

            if (gbCar.Paliwo != null)
            {
                Console.WriteLine("Paliwo: " + gbCar.Paliwo);
            }
            else
            {
                Console.WriteLine("Paliwo: nie zdefiniowano");
            }

            if (gbCar.Pojemnosc != 0)
            {
                Console.WriteLine("Pojemność: " + gbCar.Pojemnosc);
            }
            else
            {
                Console.WriteLine("Pojemnosc: nie zdefiniowano");
            }

            if (gbCar.RokProdukcji != 0)
            {
                Console.WriteLine("Rok produkcji: " + gbCar.RokProdukcji);
            }                
            else
            {
                Console.WriteLine("Rok produkcji: nie zdefiniowano");
            }

            if (gbCar.Silnik != null)
            {
                Console.WriteLine("Silnik: " + gbCar.Silnik);
            }
            else
            {
                Console.WriteLine("Silnik: nie zdefiniowano");
            }

            if (gbCar.Typ != null)
            {
                Console.WriteLine("Typ: " + gbCar.Typ);
            }                
            else
            {
                Console.WriteLine("Typ: nie zdefiniowano");
            }                

            if (gbCar.Uwagi != null)
            {
                Console.WriteLine("Uwagi: " + gbCar.Uwagi);
            }
            else
            {
                Console.WriteLine("Uwagi: nie zdefiniowano");
            }

            Console.ReadKey();            
        }

        Samochod Osobowy = new Samochod()
        {
            Kolor = "grafit",
            Pojemnosc = 1360
        };

        Samochod Ciezorowy = new Samochod()
        {
            Kolor = "biały",
            Pojemnosc = 8500
        };
    }    
}
