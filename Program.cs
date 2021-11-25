using System;
using System.Collections.Generic;

namespace NumberGuesserExplorerMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();

            GuessingLoop();

            closingStatement();

        }
        static void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("                      WELCOME TO THE ALMIGHTY NUMBER GUESSER!                          ");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hello!");
            Console.WriteLine();
            Console.WriteLine("My goal is to guess a number that you have chosen in your mind.");
            Console.WriteLine();
            Console.WriteLine("You may pick any number between 1 - 1,024.");
            Console.WriteLine();
            Console.WriteLine("Do not enter your number! Keep it in your head, please.");
            Console.WriteLine();
        }
        static void GuessingLoop()
        {
            var maxGuess = 1024;
            var minGuess = 0;

            Console.WriteLine($"Is you number 512? Please type Y if so; otherwise type h " +
                              "if your number is higher or type l if your number is lower.");
            var response = Console.ReadLine();

            var affirmatives = new List<string>() { "y", "Y", "Yes", "yes", "YES", "YUS", "yep", "Yeah", "Yep" };
            var higher = new List<string>() { "n", "N", "no", "NO", "No", "Nope", "nope", "Nerp", "nerp" };
            var lower = new List<string>() { "l", "L", "Lower", "lower" };
            var highGuess = new List<string>() { "h", "H", "higher", "Higher" };

            if (affirmatives.Contains(response))
            {
                Console.WriteLine("Well that was easy! Only 1 guess!");
                //     }
                //     else if (higher.Contains(response))
                //     {

                //     }
                //     else if (negat == "h")
                //     {
                //         var newGuess = maxGuess / 2;
                //         Console.WriteLine($"Is {newGuess} your number?");
                //     }
                //     else if (response == "l")
                //     {
                //         var newGuess = minGuess / 2;
                //         Console.WriteLine($"Is {newGuess} your number?");
                //     }
                //     else
                //     {
                //         Console.WriteLine("Please enter an acceptable response.");
            }
        }
        static void closingStatement()
        {
            Console.WriteLine("Bet you couldn't do that as quickly.");
        }
    }
}


