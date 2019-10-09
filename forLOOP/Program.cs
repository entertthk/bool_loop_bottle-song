using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forLOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            // int i = 0 - start of the loop; i <10 - stop: i++ -step
            for (int i = 1; i < 11; i++ )
            {
                Console.WriteLine($"i equals {i}");
            }

            Console.WriteLine("\n");

            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine($"i equals {i}");
            }

            Console.ReadLine();
        }
    }
}
