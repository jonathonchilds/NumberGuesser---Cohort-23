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
            Console.WriteLine($"(At most, this will only take me {maxGuesses} guesses to figure out.)");
        }

        public static void ResponseLoop(ref int numberRangeMaximum, ref int numberRangeMinimum, ref int systemGuess, ref string userResponse)
        {
            // would love to import a text file containing every possible "yes" response; or, perhaps, just add radio buttons. That would be was easier. But the text file idea could apply for something like voice recognition
            var affirmativeUserResponse = new List<string>() { "y", "Y", "Yes", "yes", "YES", "yasss", "YAS", "YUS", "yup", "yuppp", "yep", "Yeah", "Yep", "you got it!", "that's it!" };
            var List_Of_Possible_Responses_For_Guess_Lower = new List<string>() { "l", "L", "Lower", "lower", "LOWER" };
            var List_Of_Possible_Responses_For_Guess_Higher = new List<string>() { "h", "H", "higher", "Higher", "HIGHER" };
            var negativeUserResponse = new List<string>() { "n", "N", "no", "NO", "No", "Nope", "nope", "Nerp", "nerp" };
            //how to make loop return to beginning while condition is user enters anything other than a provided list?
            int count = 1;
            while (!affirmativeUserResponse.Contains(userResponse))
            {
                while (List_Of_Possible_Responses_For_Guess_Higher.Contains(userResponse))
                {
                    numberRangeMinimum = systemGuess;
                    systemGuess = (numberRangeMaximum + numberRangeMinimum) / 2;
                    Console.Write($"Is your number {systemGuess}? ");
                    userResponse = Console.ReadLine();
                    count++;
                }
                while (List_Of_Possible_Responses_For_Guess_Lower.Contains(userResponse))
                {
                    numberRangeMaximum = systemGuess;
                    systemGuess = (numberRangeMaximum + numberRangeMinimum) / 2;
                    Console.WriteLine($"Is your number {systemGuess}?");
                    userResponse = Console.ReadLine();
                    count++;
                }
                while (negativeUserResponse.Contains(userResponse))
                {
                    Console.WriteLine("Well then tell me if it's higher or lower, please.");
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
                Console.WriteLine("I'm sure you could do this too, but likely not as quickly. ☺️");
                Console.WriteLine("\n");
                Console.WriteLine("\n");

            }
        }

    }
}
