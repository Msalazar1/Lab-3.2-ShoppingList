using System;
using System.Collections;
using System.IO;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
                ArrayList Order = new ArrayList();
                ArrayList Price = new ArrayList();
                Dictionary<string, double> items = new Dictionary<string, double>();
                items["apple"] = 0.25;
                items["banana"] = 0.19;
                items["pear"] = 0.99;
                items["strawberry"] = 2.39;
                items["watermelon"] = 4.99;
                items["celery"] = 1.99;
                items["snozberry"] = 5.55;
                items["pineapple"] = 2.99;

                
            bool keepgoing = true;
            while (keepgoing)
            {


                Console.WriteLine("Welcome To S-Mart! " + "Shop smart, shop S-Mart!");
                Console.WriteLine($"{"Item",-20}{"Price",-20}");
                Console.WriteLine("=============================");
                foreach (KeyValuePair<string, double> item in items)
                {
                    Console.WriteLine($"{item.Key,-20}${item.Value,-20}");
                }
                Console.WriteLine("============================");
                Console.WriteLine("What would you like to add to your order?");
                string choice = Console.ReadLine();
                while (!items.ContainsKey(choice))
                {
                    Console.WriteLine();
                    Console.WriteLine("Out of stock.  Please choose another item.");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to add to your order?");
                    choice = Console.ReadLine();
                }

                Order.Add(choice);
                Price.Add(items[choice]);

                Console.WriteLine();
                Console.WriteLine($"{choice}s have been added to your order at ${items[choice]}");

                Console.WriteLine();
                Console.WriteLine($"Would you like to order anything else? y/n");
                string andThen = Console.ReadLine();
                if (andThen == "y")
                {
                    keepgoing = true;
                    {
                        Console.Clear();
                    }
                }
                else if (andThen == "n")
                {
                    keepgoing = false;
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you for shopping smart at S-Mart! " + "You ordered:");

                        /*for (int index = 0; index < Order.Count; index++)
                        {
                            Console.WriteLine(Order[index]);
                            Console.WriteLine(Price[index]);

                        }*/


                        double sum = 0;
                        for (int index = 0; index < Order.Count; index++)
                        {
                            Console.WriteLine($"{Order[index],-20}${Price[index],-20}");
                            sum = sum + (double)Price[index];
                        }

                        sum /= Price.Count;

                        Console.WriteLine($"The average price per item of your order is: ${sum:N2}");
                        Console.WriteLine();
                        Console.WriteLine("Thanks again for shopping smart at S-Mart!");

                    }
                }
            }
            
        }
    }
}
