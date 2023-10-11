using System;

class Program
{/*
         Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated. Valid coins are
         

        · 0.1, 0.2, 0.5, 1 and 2

        If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.

        On the next lines, until the "End" command is given, you will start receiving products, which a customer wants to buy. The vending machine has only:

        · "Nuts" with a price of 2.0

        · "Water" with a price of 0.7

        · "Crisps" with a price of 1.5

        · "Soda" with a price of 0.8

        · "Coke" with a price of 1.0

        If the customer tries to purchase a not existing product, print "Invalid product".

        When a customer has enough money to buy the selected product, print "Purchased {product name}", otherwise print "Sorry, not enough money" and continue to the next line.

        When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".
         */
    static void Main(string[] args)
    {
        double amountOfMoneySummed = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Start")
            {
                break;
            }
            double money = double.Parse(input);

            if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
            {
                amountOfMoneySummed += money;
            }
            else
            {
                Console.WriteLine($"Cannot accept {money}");
            }
        }

        while (true)
        {
            string product = Console.ReadLine();
            if (product == "End")
            {
                break;
            }

            double price = 0;
            switch (product)
            {
                case "Nuts":
                    price = 2.0;
                    break;
                case "Water":
                    price = 0.7;
                    break;
                case "Crisps":
                    price = 1.5;
                    break;
                case "Soda":
                    price = 0.8;
                    break;
                case "Coke":
                    price = 1.0;
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    continue;
            }

            if (amountOfMoneySummed >= price)
            {
                Console.WriteLine($"Purchased {product.ToLower()}");
                amountOfMoneySummed -= price;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
        }

        Console.WriteLine($"Change: {amountOfMoneySummed:f2}");
    }
}
