using System;

namespace _05_Orders
{
    internal class Program
    {
        /*
         Create a program that calculates and prints the total price of an order. The method should receive two parameters:
            • A string, representing a product - "coffee", "water", "coke", "snacks"
            • An integer, representing the quantity of the product


            The prices for a single item of each product are:
            • coffee – 1.50
            • water – 1.00
            • coke – 1.40
            • snacks – 2.00
            Print the result, rounded to the second decimal place.

         
         */
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double quantityOfProduct = double.Parse(Console.ReadLine());

            Order(productName, quantityOfProduct);
        }

        static void Order(string productName, double quantityOfProduct)
        {
            if (productName == "coffee")
            {
                double priceOfProduct = 1.50;
                PriceOfOrder(quantityOfProduct , priceOfProduct);

            }
            else if (productName == "water")
            {
                double priceOfProduct = 1.00;
                PriceOfOrder(quantityOfProduct , priceOfProduct);
            }
            else if (productName == "coke")
            {
                double priceOfProduct = 1.40;
                PriceOfOrder(quantityOfProduct , priceOfProduct);
            }
            else // snacks
            {
                double priceOfProduct = 2.00;
                PriceOfOrder(quantityOfProduct , priceOfProduct);
            }
        }

        private static void PriceOfOrder(double quantityOfProduct, double priceOfProduct)
        {
            
            Console.WriteLine($"{quantityOfProduct * priceOfProduct:f2}");
        }
    }
}
