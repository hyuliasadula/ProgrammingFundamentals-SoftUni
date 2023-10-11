using System;

namespace _10_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //subtracting M from N until N becomes less than M,
            int pokePower = int.Parse(Console.ReadLine()); //n
            int distanceBetweenPoke = int.Parse(Console.ReadLine()); //m
            int exhaustionFactor = int.Parse(Console.ReadLine()); // y
            //int substractingMfromN = 0;

            int pokesCount = 0;


            /*
             The PokeMon becomes gradually more exhausted. IF N becomes equal to EXACTLY 50 % of its
            original value, you must divide N by Y, if it is POSSIBLE. This DIVISION is between integers.
            If a division is not possible, you should NOT do it. Instead, you should continue subtracting.
            After dividing, you should continue subtracting from N, until it becomes less than M.
            When N becomes less than M, you must take what has remained of N and the count of targets
            you've poked, and print them as output.

             */
           

            while (pokePower >= distanceBetweenPoke)
            {
                pokePower -= distanceBetweenPoke;
                int pokePowerCollector = pokePower;
                pokesCount++;

                // Check if N is exactly 50% of its original value
                if (pokePowerCollector == pokePower)
                {
                    // Check if division is possible
                    if (exhaustionFactor % pokePowerCollector != 1) // TODO
                    {
                        pokePower /= exhaustionFactor;
                        pokesCount++;
                    }
                }
            }
            
            Console.WriteLine(pokePower);
            Console.WriteLine(pokesCount);
        }
    }
}
//while (true)
//{
//    pokePower -= distanceBetweenPoke;
//    substractingMfromN = pokePower;
//    if (substractingMfromN < distanceBetweenPoke)
//    {
//        break;5
//    }
//    else if (substractingMfromN == pokePower)
//    {

//        if (pokePower % 2 == 0) 
//        {
//            substractingMfromN = pokePower - distanceBetweenPoke;
//        }
//        pokePower /= exhaustionFactor;
//    }
//    pokesCount++;
//}