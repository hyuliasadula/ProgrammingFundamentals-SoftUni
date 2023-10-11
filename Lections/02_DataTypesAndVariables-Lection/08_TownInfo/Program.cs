using System;

namespace _08_TownInfo
{
    internal class Program
    {

        /*
         You will be given 3 lines of input. On the first line, you will be given the name of the town, on the second – the
        population and on the third the area. Use the correct data types and print the result in the following format:
        "Town {town name} has population of {population} and area {area} square km".



        Sofia
        1286383
        492


        Town Sofia has population of 1286383 and area 492 square
        km.



      
         
         */
        static void Main(string[] args)
        {
            

            string nameOfTown = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}
