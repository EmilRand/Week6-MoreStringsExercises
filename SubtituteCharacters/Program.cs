using System;

namespace SubtituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string perekonnanimi = Console.ReadLine();
            string fullname = $"{eesnimi} {perekonnanimi}";

            fullname = fullname.Replace('a', '*');
            Console.WriteLine(fullname);
        }
    }
}
