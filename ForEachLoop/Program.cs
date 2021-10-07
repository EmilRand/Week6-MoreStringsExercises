using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloW = "Hello World";
            int charCounter = 0;
            foreach(char c in helloW)
            {
                charCounter++;
            }

            Console.WriteLine($"Lause pikkus {helloW} on {charCounter}.");

        }
    }
}
