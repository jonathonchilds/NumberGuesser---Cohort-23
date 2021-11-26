using System;
using System.Collections.Generic;

namespace NumberGuesserExplorerMode
{
    class Program
    {
        static void Main(string[] args)
        {
            var affirmativeUserResponse = new List<string>() { "y", "Y", "Yes", "yes", "YES", "yasss", "YAS", "YUS", "yup", "yuppp", "yep", "Yeah", "Yep" };
            var negativeUserResponse = new List<string>() { "n", "N", "no", "NO", "No", "Nope", "nope", "Nerp", "nerp" };
            var lowerGuess = new List<string>() { "l", "L", "Lower", "lower", "LOWER" };
            var higherGuess = new List<string>() { "h", "H", "higher", "Higher", "HIGHER" };

            var passingMaxValue = int.Parse(Greeting());

            var guess = NumberGuess(passingMaxValue);

            var response = IsYourNumber(guess);

            if (higherGuess.Contains(response))
            {
                NumberIsHigherLoop(passingMaxValue, guess);
            }
            else if (lowerGuess.Contains(response)) ;
            {
                NumberIsLowerLoop(guess);
            }
            ClosingStatement();


        }
        static string Greeting()
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
            Console.WriteLine("You may pick any whole number you'd like.");
            Console.WriteLine();
            Console.WriteLine("Do not enter your number! Keep it in your head, please.");
            Console.WriteLine();
            Console.WriteLine("Now do me a favor and type any number that is higher than the number you've picked.");
            var userEnteredMaxValue = Console.ReadLine();
            return userEnteredMaxValue;
        }
        static int NumberGuess(int passingMaxValue)
        {
            var guess = passingMaxValue / 2;
            return guess;
        }
        static string IsYourNumber(int guess)
        {
            Console.WriteLine($"Is you number {guess}? If not, please tell me if your number is higher or lower.");
            var response = Console.ReadLine();
            return response;
        }
        static string NumberIsHigherLoop(int passingMaxValue, int guess)
        {
            var newGuess = (passingMaxValue + guess) / 2;
            Console.WriteLine($"Is your number {newGuess}?");
            var response = Console.ReadLine();
            return response;
        }
        static string NumberIsLowerLoop(int guess)
        {
            var newGuess = (0 + guess) / 2;
            Console.WriteLine($"Is your number {newGuess}?");
            var response = Console.ReadLine();
            return response;
        }
        static void ClosingStatement()
        {
            Console.WriteLine("Well that was easy.");
        }
    }

    // Console.WriteLine($"Is you number {initialGuess}? Please type Y if so; otherwise type h " +
    //               "if your number is higher or type l if your number is lower.");
    // var response = Console.ReadLine();

    // else if (negat == "h")
    // {
    //     var newGuess = maxGuess / 2;
    //     Console.WriteLine($"Is {newGuess} your number?");
    // }
    // else if (response == "l")
    // {
    //     var newGuess = minGuess / 2;
    //     Console.WriteLine($"Is {newGuess} your number?");
    // }
    // else
    // {
    //     Console.WriteLine("Please enter an acceptable response.");
    //     // Console.WriteLine($"Is you number {initialGuess}? If not, please tell me if your number is higher or lower.");
    //     // var response = Console.ReadLine();
    // }

}
// Console.WriteLine("Bet you couldn't do that as quickly.");
//         }
//     }
// }


