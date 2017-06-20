using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            getUserInfo();

            Console.WriteLine("press any key to continue....");
            //game starts

            int max = 10;

            //add score to modify game

            while(true)
            { 
                //random class
                Random random = new Random(); 


                int correctNumber = random.Next(max);
                string Input;

                Console.WriteLine("Enter your number");
                Input = Console.ReadLine();


                //type conversion
                int userInput = int.Parse(Input);
                while (userInput != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    // Console.ResetColor();
                    Console.WriteLine("wrong number. Try again.");
                    Console.ResetColor();
                    Input = Console.ReadLine();

                    userInput = int.Parse(Input);


                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct Number");


                string choice;
                Console.WriteLine("Do u want to play again.? Y/N ");
                choice = Console.ReadLine().ToUpper();

                if (choice == "Y")
                {
                    continue;
                }

                else
                {
                    return;
                }
            }//while ends here
            
     
            
            Console.ReadKey();
        }

        static void GetAppInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("This is a number guessing game.  For numbers between 1 and 10");
            Console.WriteLine("Version 1.0");
            Console.WriteLine("Iyke");
            Console.WriteLine(Environment.NewLine);
            Console.ResetColor();
        }

        private static void getUserInfo()
        {
            string user;
            Console.WriteLine("Enter your name");
            user = Console.ReadLine();

            Console.WriteLine("Welcome {0}", user);
            Console.WriteLine(Environment.NewLine);
        }


    }
}
