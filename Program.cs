using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs php = new Kurs();
            php.informacje();
            Console.ReadKey();
        }
    }
    class Produkty
    {
        public void informacje(string nazwa, double cena, string kategoria)
        {
            Console.WriteLine(nazwa);
            Console.WriteLine(cena);
            Console.WriteLine(kategoria);
        }


    }
    class Kurs : Produkty
    {
        int rozdzialy = 80;
        public void informacje()
        {
            base.informacje("test", 42.2, "internet");
            Console.WriteLine(rozdzialy);
        }
    }


       
}
