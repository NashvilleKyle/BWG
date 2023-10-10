// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    private static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Big Wallet Gangstas");
        WaitForEnter();

        Console.WriteLine("A Williams' Enterprises Production");
        WaitForEnter();

        Console.WriteLine("Welcome to the Gabagoolio Family. As our newest member, you will be expected to be a good earner. You will report here every day and give your tribute to your Lieutenant. Good luck out there. Now get out there and earn us some dough!");
        WaitForEnter();

        List<decimal> moneyList = new List<decimal>();
        decimal total = 0;

        while (true)
        {
            Console.WriteLine("Another beautiful day in Mafia City. Time to make some dough so I can pay my tribute and earn my keep!");
            WaitForEnter();

            Console.WriteLine("How do you want to earn?\n1. Extort local business owner\n2. Mug random sucker on the street\n3. Rob the cannoli store");
            string earningMethod = Console.ReadLine()!;

            if (earningMethod == "1")
            {
                Console.WriteLine("Which business would you like to extort?\n1. Paulie's Liquor Cabinet\n2. Mort's Pharmacy\n3. Vinny's Tires and Auto Repair");
                string businessChoice = Console.ReadLine()!;
                var randomNumber = random.Next(2);
                if (randomNumber == 0)  // Randomly decide success or gun pull
                {
                    decimal moneyExtorted = random.Next(1, 11);  // Randomly choose a value between 1 and 10
                    Console.WriteLine($"You successfully extorted the business owner for ${moneyExtorted}");
                    total += moneyExtorted;
                    WaitForEnter();
                }
                else
                {
                    Console.WriteLine("The business owner decided to pull out a gun and tell you to leave the store.");
                    WaitForEnter();
                    Console.WriteLine("What do you do?\n1. Run out the door\n2. Pull out a gun and point it back at them");
                    string reaction = Console.ReadLine()!;

                    if (reaction == "1")
                    {
                        Console.WriteLine("Phew! That was a close one! We'll come back tomorrow and teach him a lesson he'll never forget!");
                        WaitForEnter();
                    }
                    else if (reaction == "2")
                    {
                        Console.WriteLine("The store owner had the drop on you and shot you before you even got your hand on your gun. You were dead before you hit the floor.");
                        return;
                    }
                }
            }

            Console.WriteLine("Time to head back to the hideout and pay tribute on today's earnings.");
            WaitForEnter();

            Console.WriteLine("Give the money to the Lieutenant? Y or N");
            string decision = Console.ReadLine()!.ToUpper();

            if (decision == "Y")
            {
                Console.WriteLine("How much do you have for tribute?");
                decimal moneyGiven;
                while (!decimal.TryParse(Console.ReadLine(), out moneyGiven))
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                if (moneyGiven == 0)
                {
                    Console.WriteLine("That's banana ducks! Get outta here and don't come back!");
                    WaitForEnter(); 
                    Console.WriteLine("The Don does not look upon you with favor.");
                }
                else
                {
                    // Message based on amount
                    if (moneyGiven >= 5)
                    {
                        Console.WriteLine("That's a good day's earnings, kid. Keep it up.");
                    }
                    else if (moneyGiven >= 1 && moneyGiven <= 4)
                    {
                        Console.WriteLine("This is pretty low, but it will do for today. Earn more tomorrow!");
                    }

                    total += moneyGiven;

                    if (total % 30 == 0)
                    {
                        Console.WriteLine("The Don appreciates your hard work. Keep it up, kid.");
                    }
                }

                Console.WriteLine("Running Total: " + total);
                WaitForEnter();
            }
            else if (decision == "N")
            {
                Console.WriteLine("You have been shot!");
                return;
            }
        }
    }

    private static void WaitForEnter()
    {
        while (Console.ReadKey(intercept: true).Key != ConsoleKey.Enter) ;
    }
}