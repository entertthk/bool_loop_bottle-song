using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BottleSOng99
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            

            for (int i = 99; i >0; i--)
                {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. \nTake one down and pass it around, {i-1} bottles of beer on the wall. \n ");
                }
                
                
                
                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. \nGo to the store and buy some more, 99 bottles of beer on the wall. ");
                Console.ReadLine();

                
            }

            

        }
    }

