using System;
using System.Collections.Generic;

namespace _04_ListOfProducts
{
    internal class Program
    {
        /*
         Read a number n and n lines of products. Print a numbered list of all the products ordered by name.
        
        Input

        4
        Potatoes
        Tomatoes
        Onions
        Apples

        Output

        1.Apples
        2.Onions
        3.Potatoes
        4.Tomatoes
         */
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string nameOfProduct = Console.ReadLine();
                products.Add(nameOfProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
