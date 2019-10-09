using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ylesanded
{
    class Program
    {
        static void Main(string[] args)
        {

        int userNumber;
        Console.WriteLine("Please enter a number:");
        userNumber = int.Parse(Console.ReadLine());

        
        if (userNumber > 0)
            {
                Console.WriteLine("User number is positive.");
            }

        else if (userNumber < 0)
            {
                Console.WriteLine("User number is negative.");
            }

        else 
            {
                Console.WriteLine("User number is zero.");
            }

        Console.ReadLine();
        }
    }
}
