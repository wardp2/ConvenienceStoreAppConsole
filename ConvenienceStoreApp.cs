using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvienienceStoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stop & Shop! Press Enter to select a product category.");
            start: Console.WriteLine("Select 1 for Beverages. Select 2 for Snacks. Select 3 for grocery. Select 4 for Miscellaneous.");
            string selectInput = Console.ReadLine();
            double bevTotal = 0.00;
            double snackTotal = 0.00;
            double groceryTotal = 0.00;
            double miscTotal = 0.00;

            if (selectInput == "1" || selectInput == "2" || selectInput == "3" || selectInput == "4")
            {
                switch (selectInput)
                {
                    case "1":
                        Console.WriteLine("Thirsty? You are in luck. We have Coke for $1.25, " +
                        "Water for $0.75, Monster Energy for $2.50, and Gatorade for $1.75. Type what you want, or enter next for next category.");
                        string bevSelection = Console.ReadLine();
                        string lowerBevSelection = bevSelection.ToLower();
                        {
                            if (lowerBevSelection == "coke")
                            {
                                bevTotal += 1.25;
                                Console.WriteLine("Would you like another beverage? Select Y/N");
                                string ans1 = Console.ReadLine();
                                if (ans1 == "Y" || ans1 == "y") goto case "1";
                                if (ans1 == "N" || ans1 == "n") goto case "2";
                            }
                            else if (lowerBevSelection == "water")
                            {
                                bevTotal += 0.75;
                                Console.WriteLine("Would you like another beverage? Select Y/N");
                                string ans1 = Console.ReadLine();
                                if (ans1 == "Y" || ans1 == "y") goto case "1";
                                if (ans1 == "N" || ans1 == "n") goto case "2";
                            }
                            else if (lowerBevSelection == "monter energy" || lowerBevSelection == "monster")
                            {
                                bevTotal += 2.50;
                                Console.WriteLine("Would you like another beverage? Select Y/N");
                                string ans1 = Console.ReadLine();
                                if (ans1 == "Y" || ans1 == "y") goto case "1";
                                if (ans1 == "N" || ans1 == "n") goto case "2";
                            }
                            else if (lowerBevSelection == "gatorade")
                            {
                                bevTotal += 1.75;
                                Console.WriteLine("Would you like another beverage? Select Y/N");
                                string ans1 = Console.ReadLine();
                                if (ans1 == "Y" || ans1 == "y") goto case "1";
                                if (ans1 == "N" || ans1 == "n") goto case "2";
                            }
                            else if (lowerBevSelection == "next")
                            {
                                goto case "2";
                            }
                            else goto case "1";
                        }
                        break;
                    case "2":
                        Console.WriteLine("Hungry? How about a snack? Doritos are $1.75, Starbursts are $1.00," +
                  " Oreos are $2.25, and Trail Mix is $3.75. Type what you want, or enter next for next category.");
                        string snackSelection = Console.ReadLine();
                        string lowerSnackSelection = snackSelection.ToLower();
                        {
                            if (lowerSnackSelection == "doritos")
                            {
                                snackTotal += 1.75;
                                Console.WriteLine("Would you like another snack? Select Y/N");
                                string ans2 = Console.ReadLine();
                                if (ans2 == "Y" || ans2 == "y") goto case "2";
                                if (ans2 == "N" || ans2 == "n") goto case "3";
                            }
                            else if (lowerSnackSelection == "starbursts")
                            {
                                snackTotal += 1.00;
                                Console.WriteLine("Would you like another snack? Select Y/N");
                                string ans2 = Console.ReadLine();
                                if (ans2 == "Y" || ans2 == "y") goto case "2";
                                if (ans2 == "N" || ans2 == "n") goto case "3";
                            }
                            else if (lowerSnackSelection == "oreos")
                            {
                                snackTotal += 2.25;
                                Console.WriteLine("Would you like another snack? Select Y/N");
                                string ans2 = Console.ReadLine();
                                if (ans2 == "Y" || ans2 == "y") goto case "2";
                                if (ans2 == "N" || ans2 == "n") goto case "3";
                            }
                            else if (lowerSnackSelection == "trail mix")
                            {
                                bevTotal += 1.75;
                                Console.WriteLine("Would you like another snack? Select Y/N");
                                string ans2 = Console.ReadLine();
                                if (ans2 == "Y" || ans2 == "y") goto case "2";
                                if (ans2 == "N" || ans2 == "n") goto case "3";
                            }
                            else if (lowerSnackSelection == "next")
                            {
                                goto case "3";
                            }
                            else goto case "2";
                        }
                        break;
                    case "3":
                        Console.WriteLine("So you want some groceries! Bananas are $0.49 each, milk is $2.00 per gallon, " +
                  "dried mango is $4.75, and frozen pizza is $5.75. Type what you want, or enter next for next category.");
                        string grocerySelection = Console.ReadLine();
                        string lowerGrocerySelection = grocerySelection.ToLower();
                        {
                            if (lowerGrocerySelection == "banana" || lowerGrocerySelection == "bananas")
                            {
                                groceryTotal += 0.49;
                                Console.WriteLine("Would you like another grocery item? Select Y/N");
                                string ans3 = Console.ReadLine();
                                if (ans3 == "Y" || ans3 == "y") goto case "3";
                                if (ans3 == "N" || ans3 == "n") goto case "4";
                            }
                            else if (lowerGrocerySelection == "milk")
                            {
                                snackTotal += 2.00;
                                Console.WriteLine("Would you like another grocery item? Select Y/N");
                                string ans3 = Console.ReadLine();
                                if (ans3 == "Y" || ans3 == "y") goto case "3";
                                if (ans3 == "N" || ans3 == "n") goto case "4";
                            }
                            else if (lowerGrocerySelection == "dried mango" || lowerGrocerySelection == "mango")
                            {
                                groceryTotal += 4.75;
                                Console.WriteLine("Would you like another grocery item? Select Y/N");
                                string ans3 = Console.ReadLine();
                                if (ans3 == "Y" || ans3 == "y") goto case "3";
                                if (ans3 == "N" || ans3 == "n") goto case "4";
                            }
                            else if (lowerGrocerySelection == "frozen pizza")
                            {
                                groceryTotal += 5.75;
                                Console.WriteLine("Would you like another grocery item? Select Y/N");
                                string ans3 = Console.ReadLine();
                                if (ans3 == "Y" || ans3 == "y") goto case "3";
                                if (ans3 == "N" || ans3 == "n") goto case "4";
                            }
                            else if (lowerGrocerySelection == "next")
                            {
                                goto case "4";
                            }
                            else goto case "3";
                        }

                        break;
                    case "4":
                        Console.WriteLine("What do you need? Toothpaste is $3.25, deoderant is $2.80," +
                  " gum is $1.75, and bodywash is $5.50. Type what you want, or enter done to complete shopping.");
                        string miscSelection = Console.ReadLine();
                        string lowerMiscSelection = miscSelection.ToLower();
                        {
                            if (lowerMiscSelection == "toothpaste")
                            {
                                miscTotal += 3.25;
                                Console.WriteLine("Would you like to do more shopping? Select Y/N");
                                string ans4 = Console.ReadLine();
                                if (ans4 == "Y" || ans4 == "y") goto case "1";
                                if (ans4 == "N" || ans4 == "n") break;
                            }
                            else if (lowerMiscSelection == "deoderant")
                            {
                                miscTotal += 2.80;
                                Console.WriteLine("Would you like to do more shopping? Select Y/N");
                                string ans4 = Console.ReadLine();
                                if (ans4 == "Y" || ans4 == "y") goto case "1";
                                if (ans4 == "N" || ans4 == "n") break;
                            }
                            else if (lowerMiscSelection == "gum")
                            {
                                miscTotal += 1.75;
                                Console.WriteLine("Would you like to do more shopping? Select Y/N");
                                string ans4 = Console.ReadLine();
                                if (ans4 == "Y" || ans4 == "y") goto case "1";
                                if (ans4 == "N" || ans4 == "n") break;
                            }
                            else if (lowerMiscSelection == "bodywash")
                            {
                                miscTotal += 5.50;
                                Console.WriteLine("Would you like to do more shopping? Select Y/N");
                                string ans4 = Console.ReadLine();
                                if (ans4 == "Y" || ans4 == "y") goto case "1";
                                if (ans4 == "N" || ans4 == "n") break;

                                else if (lowerMiscSelection == "done")
                                {
                                    goto total;
                                }
                                else goto case "4";
                            }
                            break;

                        }
                }
            }
            else
            {
                goto start;
            }
            total: double total = bevTotal + snackTotal + groceryTotal + miscTotal;
            double tax = total * .08;
            Console.WriteLine("Thank you for shopping! Your pretax total is $" + total +
            ", your tax is $" + tax + ", so your grand total is $" + (tax + total).ToString());
            Console.ReadLine();
        }
    }
}
