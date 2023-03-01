using System;
using Bakery.Models;


namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Pierre's bakery!");
            Console.WriteLine("We sell bread and pastries. We have a deal on bread, buy 2 get 1 free! Pastries are buy 3 get 1 free!");
            Console.WriteLine("How many pastries would you like?");
            string pastryInput = Console.ReadLine();
            int pastry = Int32.Parse(pastryInput);
            Pastry newPastry = new Pastry(pastry);
            Console.WriteLine("How many loaves of bread would you like?");
            string breadInput = Console.ReadLine();
            int bread = Int32.Parse(breadInput);
            Bread newBread = new Bread(bread);
            int  totalCost = newBread.BreadCost + newPastry.PastryCost;
            Console.WriteLine($"Your total is {totalCost}");
            Console.WriteLine("Would you like to place another order? Enter y/n");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
            Main();
            }
            else
            {
            Console.WriteLine("Thank you come again.");
            }
            
        }
    }
}


