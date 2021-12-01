using System;
using System.Collections.Generic;

namespace NumberGuesserExplorerMode
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberRangeMaximum = int.Parse(Greeting());
            var numberRangeMinimum = 0;
            var systemGuess = (numberRangeMaximum + numberRangeMinimum) / 2;
            Console.WriteLine();
            maxGuessesCalculator(ref numberRangeMaximum, ref numberRangeMinimum);

            Console.WriteLine();
            Console.Write($@"Is your number {systemGuess}? ");
            var userResponse = Console.ReadLine();
            ResponseLoop(ref numberRangeMaximum, ref numberRangeMinimum, ref systemGuess, ref userResponse);
        }
        static string Greeting()
        {
            Console.WriteLine("\n");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("                      WELCOME TO THE ALMIGHTY NUMBER GUESSER                          ");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("Hello!");
            Console.WriteLine();
            Console.WriteLine("My goal is to guess a number that you have chosen in your mind.");
            Console.WriteLine();
            Console.WriteLine("You may pick any whole number you'd like.");
            Console.WriteLine();
            Console.WriteLine("Do not enter your number! Keep it in your head, please.");
            Console.WriteLine();
            Console.WriteLine("Now do me a favor and type any number that is higher than the number you've picked.");
            Console.WriteLine();
            return Console.ReadLine();
        }
        public static void maxGuessesCalculator(ref int numberRangeMaximum, ref int numberRangeMinimum)
        {
            var maxGuesses = Math.Round(Math.Log2((numberRangeMaximum - numberRangeMinimum)) + 1);
            Console.WriteLine($"(I'll have this in less than {maxGuesses} guesses, guaranteed.)");
        }
        public static void ResponseLoop(ref int numberRangeMaximum, ref int numberRangeMinimum, ref int systemGuess, ref string userResponse)
        {
            var affirmativeUserResponse = new List<string>() { "y", "Y", "Yes", "yes", "YES", "yasss", "YAS", "YUS", "yup", "yuppp", "yep", "Yeah", "Yep", "you got it!", "that's it!", "yep!" };
            var List_Of_Possible_Responses_For_Guess_Lower = new List<string>() { "l", "L", "Lower", "lower", "LOWER" };
            var List_Of_Possible_Responses_For_Guess_Higher = new List<string>() { "h", "H", "higher", "Higher", "HIGHER" };
            var negativeUserResponse = new List<string>() { "n", "N", "no", "NO", "No", "Nope", "nope", "Nerp", "nerp" };

            int count = 1;

            while (!affirmativeUserResponse.Contains(userResponse))
            {
                while (List_Of_Possible_Responses_For_Guess_Higher.Contains(userResponse))
                {
                    numberRangeMinimum = systemGuess;
                    systemGuess = (numberRangeMaximum + numberRangeMinimum) / 2;
                    Console.WriteLine();
                    Console.Write($"Is your number {systemGuess}? ");
                    userResponse = Console.ReadLine();
                    count++;
                }
                while (List_Of_Possible_Responses_For_Guess_Lower.Contains(userResponse))
                {
                    numberRangeMaximum = systemGuess;
                    systemGuess = (numberRangeMaximum + numberRangeMinimum) / 2;
                    Console.WriteLine();
                    Console.Write($"Is your number {systemGuess}? ");
                    userResponse = Console.ReadLine();
                    count++;
                }
                while (negativeUserResponse.Contains(userResponse))
                {
                    Console.WriteLine();
                    Console.Write("Well then tell me if it's higher or lower, please: ");
                    userResponse = Console.ReadLine();
                }
            }
            if (affirmativeUserResponse.Contains(userResponse))
            {
                Console.WriteLine();
                if (count == 1)
                {
                    Console.WriteLine("Only " + count + " guess!");
                }
                else
                {
                    Console.WriteLine("Only " + count + " guesses!");
                }
                Console.WriteLine();
                Console.WriteLine("I'm sure you could've done this too (but likely, not as quickly). ☺️");
                Console.WriteLine("\n");
                Console.WriteLine("\n");

            }
        }

    }
}
