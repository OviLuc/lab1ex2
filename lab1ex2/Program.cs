using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura */
            Console.WriteLine("Acest program va calcula media aritmetica a trei numere.");
            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Rezultatul este: " + (x + y + z) / 3);
        }
    }
}
