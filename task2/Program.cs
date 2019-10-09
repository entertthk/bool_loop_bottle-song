using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:
        int userNumber;
        Console.WriteLine("Please enter a number:");
        userNumber = int.Parse(Console.ReadLine());

        if (userNumber % 11 == 0 && userNumber % 5 == 0)
            {
                Console.WriteLine("User number is dividable.");
            }
        else
            {
                Console.WriteLine("User number is not dividable.");
            }

        goto Start;
        Console.ReadLine();

        }
    }
}
