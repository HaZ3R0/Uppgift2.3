using System;
namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar har du hyrt bilen?");
            string dagartext = Console.ReadLine();
            double dagar = double.Parse(dagartext);
            Console.WriteLine("Hur många km har du kört");
            string kmtext = Console.ReadLine();
            double km = double.Parse(kmtext);
            double total = 300 + (1 * km) + (500 * dagar) - 500;
            Console.WriteLine("Den totalla konstnaden blir " +  total);
            Console.ReadKey();
        }
    }
}