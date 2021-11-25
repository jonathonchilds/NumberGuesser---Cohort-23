using System;

namespace NumberGuesserExplorerMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();

            Console.WriteLine($"Is you number 512? Please type Y if so; otherwise type h " +
                              "if your number is higher or type l if your number is lower.");

            GuessingLoop();

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
            var response = Console.ReadLine();

            if (response == "y")
            {
                Console.WriteLine("Well that was easy! Only 1 guess!");
            }
            else if (response == "h")
            {
                var newGuess = 1024 / 2;
                return newGuess;
            }
            else if (response == "l")
            {
                var newGuess = 512 / 2;
                return newGuess;
            }
        }
    }
}

