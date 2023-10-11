using System;

namespace _11_MultiplicationTable2
{
    internal class Program
    {

        /*
         input          output           input        output
        5                                 2
        1                                 5
                    5 X 1 = 5                       2 X 5 = 10
                    5 X 2 = 10                      2 X 6 = 12
                    5 X 3 = 15                      2 X 7 = 14
                    5 X 4 = 20                      2 X 8 = 16
                    5 X 5 = 25                      2 X 9 = 18
                    5 X 6 = 30                      2 X 10 = 20
                    5 X 7 = 35 
                    5 X 8 = 40 
                    5 X 9 = 45 
                    5 X 10 = 50
        
         */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fromWhereToStart = int.Parse(Console.ReadLine());

            if (fromWhereToStart > 10)
            {
                Console.WriteLine($"{number} X {fromWhereToStart} = {number * fromWhereToStart}");

            }

            for (int i = fromWhereToStart; i <= 10; i++)
            {
                
                Console.WriteLine($"{number} X {i} = {number * i}");
                fromWhereToStart++;
            }
        }
    }
}
