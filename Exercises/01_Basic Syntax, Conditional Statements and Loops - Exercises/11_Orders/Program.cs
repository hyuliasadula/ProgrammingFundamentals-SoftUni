using System;
using System.Diagnostics;

namespace _11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int timesCounter = 0;
            double priceSum = 0.0;

            while (timesCounter < n)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                timesCounter++;

                double price = pricePerCapsule * days * capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                priceSum+= price;

            }
            Console.WriteLine($"Total: ${priceSum:f2}");
        }
    }
}
/*
         We are placing N orders at a time. You need to calculate the price with the following formula:

        ((daysInMonth * capsulesCount) * pricePerCapsule)

        Input / Constraints

        · On the first line, you will receive integer N – the count of orders the shop will receive.

        · For each order you will receive the following information:

        o Price per capsule – floating-point number in the range [0.00…1000.00].

        o Days – integer in the range [1…31].

        o Capsules count – integer in the range [0…2000].

        The input will be in the described format, there is no need to check it explicitly.

        Output

        The output should consist of N + 1 line. For each order you must print a single line in the following format:

        · "The price for the coffee is: ${price}"

        On the last line, you need to print the total price in the following format:

        · "Total: ${totalPrice}"

        The price must be formatted to 2 decimal places.


1

1.53

30

8           The price for the coffee is: $367.20 
            Total: $367.20 We are given only 1 order.              Then we use the formula: orderPrice = 30 * 8 *                                                       1.53 = 367.20

2

4.99

31

3

0.35

31

5                       The price for the coffee is: $464.07 
                        The price for the coffee is: $54.25 
                        Total: $518.32

1

9.223

31

433                     The price for the coffee is: $123800.33 Total: $123800.33
 
 */