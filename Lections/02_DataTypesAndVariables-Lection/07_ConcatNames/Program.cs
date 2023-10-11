using System;

namespace _07_ConcatNames
{
    internal class Program
    {
        /*
         Read two names and a delimiter. Print the names joined by the delimiter.
                Examples
                Input Output
                John
                Smith
                ->
                John->Smith

                Jan
                White
                <->
                Jan<->White

                Linda
                Terry
                =>
                Linda=>Terry
         
         */
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimiter}{lastName}");
        }
    }
}
