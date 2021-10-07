using System;

namespace CharecterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string perekonnanimi = Console.ReadLine();
            string fullname = $"{eesnimi}{perekonnanimi}";
            int count = 0;
            foreach (char c in fullname) 
            {

                count++;
           
            }

            Console.WriteLine($"sinu nime sees on {count} sümbolit");      
        }
    }
}
