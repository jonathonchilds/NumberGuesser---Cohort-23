using System;
using System.Collections.Generic;

namespace NumberGuesserExplorerMode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var affirmativeUserResponse = new List<string>() { "y", "Y", "Yes", "yes", "YES", "yasss", "YAS", "YUS", "yup", "yuppp", "yep", "Yeah", "Yep" };
            // var negativeUserResponse = new List<string>() { "n", "N", "no", "NO", "No", "Nope", "nope", "Nerp", "nerp" };
            // var lowerGuess = new List<string>() { "l", "L", "Lower", "lower", "LOWER" };
            // var ListOfPossibleResponsesForGuessHigher = new[] { "h", "H", "higher", "Higher", "HIGHER" };

            // var guessHigher = PossibleResponsesForGuessHigher(); //can i pass the string through? I gave this method a variable because it wouldn't allow me 
            // to pass the method directly through the NumberIsHigherLoop method.


            var rangeMax = int.Parse(Greeting());
            var rangeMin = 0;
            var systemGuess = (rangeMax + rangeMin) / 2;

            Console.WriteLine($@"Is you number {systemGuess}? Please type ""y"" if so, otherwise, type ""h"" if your number is higher or ""l"" if your number is lower.");
            var userResponse = Console.ReadLine();


            while (userResponse != "y")
            {
                while (userResponse == "h")
                {
                    rangeMin = systemGuess;
                    systemGuess = (rangeMax + rangeMin) / 2;
                    Console.WriteLine($@"Is you number {systemGuess}? Please type ""y"" if so, otherwise, type ""h"" if your number is higher or ""l"" if your number is lower.");
                    userResponse = Console.ReadLine();
                }
                while (userResponse == "l")
                {
                    rangeMax = systemGuess;
                    systemGuess = (rangeMax + rangeMin) / 2;
                    Console.WriteLine($@"Is you number {systemGuess}? Please type ""y"" if so, otherwise, type ""h"" if your number is higher or ""l"" if your number is lower.");
                    userResponse = Console.ReadLine();
                }
                if (userResponse == "y")
                {
                    Console.WriteLine("I'm sure you could do this too, but likely not as fast. ☺️");
                }
            }

            //_____________________________________________________________________________________________________________________

            // for (userResponse = "h"; userResponse != "l"; var newGuess = (rangeMax + rangeMin) / 2)
            // {
            //     Console.WriteLine($@"Is you number {newGuess}?");

            //     guess = max + min / 2
            //     Programs guess = 768
            // }
            // User inputs: HIGHER(h)

            //     The MAX remains the same(1024) but the previous GUESS becomes the new MIN.
            //        Maximum = 1024
            //         Minimum = 512
            //         Programs guess = max + min / 2
            //         Programs guess = 768


            //     Is your number { guess}? Please answer "y" if so, otherwise please input "h" for higher or "l" for lower.


            // while (response != "y")
            // {
            //     if (response == "h")
            //     {
            //         var newGuess = (MaxValue + guess) / 2;
            //         Console.WriteLine($"Is your number {newGuess}?");

            //         response = Console.ReadLine();
            //     }
            //     else if (response == "l")
            //     {
            //         var newGuess = (0 + guess) / 2;
            //         Console.WriteLine($"Is your number {newGuess}?");
            //         response = Console.ReadLine();
            //     }
            //     else
            //     {
            //         Console.WriteLine("Well that was easy.");
            //     }
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
    }
}



// if (affirmativeUserResponse.Contains(response));
// {
//     Console.WriteLine("Well that was easy.");
// }
//     else if (possibleResponsesForGuessHigher.Contains(response))
// {
//     var newGuess = (passingMaxValue + guess) / 2;
//     Console.WriteLine($"Is your number {newGuess}?");
//     var r = Console.ReadLine();
// }


// var guess = NumberGuess(passingMaxValue);

// var response = IsYourNumber(guess);

// if (guessHigher.Contains(response))
// {
//     NumberIsHigherLoop(passingMaxValue, guess, List[ListOfPossibleResponsesForGuessHigher]); //how to pass the string? I changed 
// }
// else if (lowerGuess.Contains(response)) ;
// {
//     NumberIsLowerLoop(guess);
// }

// ClosingStatement();


// static System.Collections.Generic.List<string> PossibleResponsesForGuessHigher()
// {
//     var ListOfPossibleResponsesForGuessHigher = new List<string>() { "h", "H", "higher", "Higher", "HIGHER" };
//     return ListOfPossibleResponsesForGuessHigher;
// }


// static string NumberIsHigherLoop(int passingMaxValue, int guess, string guessHigher)
// {
//     var newGuess = (passingMaxValue + guess) / 2;
//     Console.WriteLine($"Is your number {newGuess}?");
//     var response = Console.ReadLine();
//     return response;
// }
// static string NumberIsLowerLoop(int guess)
// {
//     var newGuess = (0 + guess) / 2;
//     Console.WriteLine($"Is your number {newGuess}?");
//     var response = Console.ReadLine();
//     return response;
// }
// static string ClosingStatement()
// {
//     var closingStatement = ("Well that was easy.");
//     return closingStatement;
// }


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

// }
// // Console.WriteLine("Bet you couldn't do that as quickly.");
// //         }
// //     }
// // }


