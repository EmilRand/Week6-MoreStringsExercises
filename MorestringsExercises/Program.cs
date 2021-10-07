using System;

namespace MorestringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string car = "racecar";
                for (int i = car.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(car[i]);
                }
            }
        }
    }
}
