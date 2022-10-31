using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Program
    {
        public static void Main()
        {
            //function variables
            int balance = 1000;
            string user = "";

            //displays welcome message
            Console.WriteLine("*****************************************");
            Console.WriteLine("Welcome to the clothing shop!");
            Console.WriteLine("*****************************************\n");

            //displays categories
            Console.WriteLine("*****************************************");
            Console.WriteLine("Women's Clothes press [1]");
            Console.WriteLine("Men's Clothes press [2]");
            Console.WriteLine("Children's Clothes press [3]");

            //displays products for category 1
            Console.WriteLine("Welcome to Women's Clothing!");
            Console.WriteLine("Press [1] to buy a dress");
            Console.WriteLine("Press [2] to buy a top");
            Console.WriteLine("Press [3] to buy some beachwear");
            Console.WriteLine("Press [4] to buy some lingerie");
            Console.WriteLine("Press [5] to buy some activewear");

            //displays products for category 1
            Console.WriteLine("Welcome to Men's Clothing!");
            Console.WriteLine("Press [1] to buy a t-shirt");
            Console.WriteLine("Press [2] to buy a polo shirt");
            Console.WriteLine("Press [3] to buy some jeans");
            Console.WriteLine("Press [4] to buy some track pants");
            Console.WriteLine("Press [5] to buy some shoes");

            //displays products for category 1
            Console.WriteLine("Welcome to Children's Clothing!");
            Console.WriteLine("Press [1] to buy a baby onesie");
            Console.WriteLine("Press [2] to buy a boy's t-shirt");
            Console.WriteLine("Press [3] to buy a girl's t-shirt");
            Console.WriteLine("Press [4] to buy boys pants");
            Console.WriteLine("Press [5] to buy girls pants");

            while (true)
            {
                //displays selection menu
                Console.WriteLine("****************************");
                Console.WriteLine("Show current balance [1]");
                Console.WriteLine("Deposit funds [2]");
                Console.WriteLine("Exit application [3]");

                //allows user input for calculations
                string userSelection = Console.ReadLine();
                switch (Int32.Parse(userSelection))
                {
                    case 1: //allows the user to view current balance
                        Console.WriteLine("Your current balance is: " + balance);
                        break;

                    case 2: //allows the user to deposit an amount in whole numbers
                        Console.WriteLine("Enter deposit amount:");
                        int deposit = Int32.Parse(Console.ReadLine());

                        if (deposit < 1)
                        {
                            Console.WriteLine("You can only deposit whole numbers");
                            break;
                        }

                        balance += deposit;
                        break;

                    case 3: //allows the user to withdraw an amount in whole numbers
                        Console.WriteLine("Enter withdrawal amount:");
                        int withdraw = Int32.Parse(Console.ReadLine());

                        if (withdraw < 1)
                        {
                            Console.WriteLine("You can only withdraw whole numbers");
                            break;
                        }

                        balance -= withdraw;
                        break;

                    case 4: //allows the user to exit the program
                        Environment.Exit(0);
                        break;
                    //if the input is anything other than a whole number, the default statement is below
                    default:
                        Console.WriteLine("Wrong input try again");
                        break;
                }
            }
        }
    }
}
