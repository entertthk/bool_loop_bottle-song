using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kivipaber
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int cpuNumber;
            
            int tries = 0;
            bool gameOver = false;

            // generate a random number for the cpu 1-5

            Random rnd = new Random();
            cpuNumber = rnd.Next(1, 6);

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");




            // !gameOver = NOT gameOver = true
            while (!gameOver)
            {
                int userNumber;
                Console.WriteLine("Game has started.Try to guess the rumber:");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > cpuNumber)
                {
                    Console.WriteLine("CPU number is smaller.");
               
                }

                else if (userNumber < cpuNumber)
                {
                    Console.WriteLine("CPU number is bigger.");
                }

                else
                {
                    Console.WriteLine("Got me!");
                    gameOver = true;
                }

            }

            Console.ReadLine();




        }
    }
}
