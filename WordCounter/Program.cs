using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloW = "Hello World!";
            int i = 0;
            int wordcounter = 1;
            while (i < helloW.Length)
            {
              if(helloW[i] == ' ')
              {
                    wordcounter++;              
              }

                i++;
            
            }

            Console.WriteLine($"lauses {helloW} on {wordcounter} sõna" );
        }
    }
}
