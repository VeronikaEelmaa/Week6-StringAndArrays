using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanimi
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");

            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length} sümbolit.");

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem.");
            }
            else if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem.");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanimi on ühepikkused.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
