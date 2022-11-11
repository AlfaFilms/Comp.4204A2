using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    internal class Program
    {
        // Global class variables
        public static int money = 1000;

        //Welcome message, receives a user input and allows the user to progress to the menu
        public static void WelcomeMessage()
        { 
            Console.WriteLine("Hello and Welcome to the Generic Clothes Store");
        }

        //Main Menu
        public static void ShopFront()
        {
            
            Console.WriteLine("*********************************************************\n");
            Console.WriteLine($"\tYour current shop balance is [${money}].\n");
            Console.WriteLine("\tWomen's Clothing           - Press [1].");
            Console.WriteLine("\tMen's Clothing             - Press [2].");
            Console.WriteLine("\tChildren's Clothing        - Press [3].");
            Console.WriteLine("\tAdd Funds to Shop Balance  - Press [4].");
            Console.WriteLine("\tExit Application           - Press [x].\n");
            Console.WriteLine("*********************************************************\n");
            Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    CategoryOne();
                    break;
                case "2":
                    CategoryTwo();
                    break;
                case "3":
                    CategoryThree();
                    break;
                case "4":
                    AddFunds();
                    break;
                case "x":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\tYour chosen option in invalid, choose again\n");
                    ShopFront();
                    break;
            }

        }

        //First area of the shop, Women's Clothing
        public static void CategoryOne()
        {
            Console.WriteLine("\tPress any button to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t*********** Women's Clothing ***********\n");
            Console.WriteLine("\tBlue Dress ($70)           - Press 1 to purchase [1]");
            Console.WriteLine("\tBlue Top ($50)             - Press 2 to purchase [2]");
            Console.WriteLine("\tAll Swimwear Sets ($80)    - Press 1 to purchase [3]");
            Console.WriteLine("\tAll Lingerie ($10)         - Press 1 to purchase [4]");
            Console.WriteLine("\tReturn to Shop Front       - Press [5]\n");
            Console.WriteLine("\tExit                       - Press [6]");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    money -= 70;
                    Console.WriteLine($"\tYou have purchased Blue Dress for $70 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "2":
                    money -= 50;
                    Console.WriteLine($"\tYou have purchased Blue Top for $50 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "3":
                    money -= 80;
                    Console.WriteLine($"\tYou have purchased a Swimwear set for $80 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "4":
                    money -= 100;
                    Console.WriteLine($"\tYou have purchased a Lingerie set for $100 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "5":
                    ShopFront();
                    break;
                default:
                    Console.WriteLine("\tYour chosen option in invalid, choose again\n");
                    CategoryOne();
                    break;
            }

        }

        //Second area of the shop, Men's Clothing
        public static void CategoryTwo()
        {
            Console.WriteLine("\tPress any button to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t*********** Men's Clothing ***********\n");
            Console.WriteLine("\tM1 ($70)           - Press 1 to purchase [1]");
            Console.WriteLine("\tM2 ($50)             - Press [2] to purchase ");
            Console.WriteLine("\tM3 ($80)    - Press 1 to purchase [3]");
            Console.WriteLine("\tM4 ($10)         - Press 1 to purchase [4]");
            Console.WriteLine("\tReturn to Shop Front       - Press [5]\n");
            Console.WriteLine("\tExit                       - Press [6]");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    money -= 10;
                    Console.WriteLine($"\tYou have purchased Blue Dress for $70 your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;
                case "2":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Blue Top for $50 your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;
                case "3":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased All Swimwear Sets for $80 your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;
                case "4":
                    money -= 10;
                    Console.WriteLine($"\tYou have purchased All Lingerie for $100 your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;
                case "5":
                    ShopFront();
                    break;
                default:
                    Console.WriteLine("\tYour chosen option in invalid, choose again\n");
                    CategoryTwo();
                    break;
            }
        }

        //Third area of the shop, Children's Clothing
        public static void CategoryThree()
        {
            Console.WriteLine("\tPress any button to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t*********** Children's Clothing ***********\n");
            Console.WriteLine("\tBlue Dress ($70)           - Press 1 to purchase [1]");
            Console.WriteLine("\tBlue Top ($50)             - Press 2 to purchase [2]");
            Console.WriteLine("\tAll Swimwear Sets ($80)    - Press 1 to purchase [3]");
            Console.WriteLine("\tAll Lingerie ($10)         - Press 1 to purchase [4]");
            Console.WriteLine("\tReturn to Shop Front       - Press [5]\n");
            Console.WriteLine("\tExit                       - Press [6]");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    money -= 70;
                    Console.WriteLine($"\tYou have purchased Blue Dress for $70 your remaining shop funds is ${money}");
                    CategoryThree();
                    break;
                case "2":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Blue Top for $50 your remaining shop funds is ${money}");
                    CategoryThree();
                    break;
                case "3":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased All Swimwear Sets for $80 your remaining shop funds is ${money}");
                    CategoryThree();
                    break;
                case "4":
                    money -= 10;
                    Console.WriteLine($"\tYou have purchased All Lingerie for $100 your remaining shop funds is ${money}");
                    CategoryThree();
                    break;
                case "5":
                    ShopFront();
                    break;
                default:
                    Console.WriteLine("\tYour chosen option in invalid, choose again\n");
                    CategoryThree();
                    break;

            }
        }
            //allow the user to add funds
            public static void AddFunds()
        {
            Console.WriteLine("\tAdd Funds ↓↓↓↓");
            money = int.Parse(Console.ReadLine()) + money;
            Console.WriteLine($"\tShop Funds available is now {money}");
            ShopFront();
        }

        static void Main(string[] args)
        {
            ShopFront();
        }
    }
}