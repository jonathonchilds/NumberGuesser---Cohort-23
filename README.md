# NumberGuesserExplorerMode

# NumberGuesser

---

NOTE: Homework is assigned with varying degrees of difficulty, from "Explorer" -> "Epic".

---

Explorer Mode

    Once the program starts, you should display a greeting to the user describing the challenge.
    Ask the user to think of a number between 1 and 1024.
    Do NOT prompt the user for their number. Your program will guess the number IN THEIR MIND
    Prompt the user with your guess and allow them to tell you if their number is higher, lower, or correct.
    Keep refining your guess until you have the correct answer.
    Use methods to organize your code. Here are some suggestions for methods you might use:
        ShowGreeting
        ComputeNewLowIfTooLow
        ComputeNewHighIfTooHigh
        BragWhenCorrect
    Use at least one or two methods

Adventure Mode

    Allow the user to choose the maximum number for their range.
    Tell them the most number of guesses your code will need!
    Prompt the user to play again at the end of the game.

Epic Mode

    Keep track of how many guesses each game has taken and show the average number of guesses your code has used. For instance, if you've played three games and took 4, 6, and 2 guesses, your average would be 4.

---

                                                                      PEDAC

11/27

After re-writing my algorithm on paper in excruciating detail (probably closer to what we've been taught), here we go again.

---

PROBLEM:

- create a greeting and describe the challenge to the user
- the program will have bounds or parameters and will use integers
- these parameters begin with a low of 0 and a high of 1024
- the program will be guessing a number of the user's choice, between 1 - 1024
- ask user if their number is higher or lower than a certain program-generated-number
- refine parameters, based on that response, to eventually hone in on the user's number

EXAMPLES:

(User chooses 617)

Program starts with a maximum value of 1024 and a minimum value of 0.
Maximum = 1024
Minimum = 0
Programs Guess = Maximum (1024) + minimum (0) / 2 = 512
Programs Guess = 512

Is your number {guess}? Please answer "y" if so, otherwise please input "h" for higher or "l" for lower.

User inputs: HIGHER (h)

    The MAX remains the same (1024) but the previous GUESS becomes the new MIN.
        Maximum = 1024
        Minimum = 512
        Programs guess = max + min / 2
        Programs guess = 768

    Is your number {guess}? Please answer "y" if so, otherwise please input "h" for higher or "l" for lower.

User inputs: LOWER (l)

      The MAX is now the previous GUESS but the MIN remains the same
          max = {guess}
          min = {min}
          guess = (max + min)/2

    Is your number {guess}? Please answer "y" if so, otherwise please input "h" for higher or "l" for lower.
    var guess = Console.ReadLine(); ("y", "h", or "l")

    for (string )

DATA STRUCTURE:

- integers
- inequalities
- basic mathematics
- logarithm formula for max guesses

  Special Cases:

  - What about all whole numbers (i.e., including zero)
  - What about integers? (i.e., including negative numbers)
  - What about rational numbers (or even irrational numbers?!)

ALGORITHM:

        Explorer Mode: (Started here but quickly realized that I wanted to pursue adventure mode.)
        Display greeting to user and explain the purpose of this program.
        "Hello! My goal is to guess a number that you have chosen in your mind."+
        "Please, decide upon a number between 1 to 1024 and simply type "ready" when you're ready.")

              - Use a method to display the greeting.
              - The method will need to read the user's input and return a {guess}

Adventure Mode:

- The {guess} will be dynamic throughout the program and will change depending on the users response to the following:
  (the following will be looped)  
   Is your number {guess}? Type Y if so, otherwise, type "h" for higher or "l" for lower.

  {Guess} is equal to the {range} (minimum + the maximum divided by 2.)

  Greeting ();
  "Hello! My goal is to guess a number that you have chosen in your mind."+
  "You may pick any natural number you'd like (a number greater than 0). I will first let you know the maximum number of guesses I will require before determining your number!"+
  "Please first provide me a with a maximum (a number higher than your choice. i.e., if your number is 13450 the maximum"+
  "might be 15000, or 20000, or even 100000. NOTE: Do not enter your number!";
  var max = console.readLine();
  var min = 1
  maxGuesses = log2(Max - Min +1)

From https://docs.microsoft.com/en-us/dotnet/api/system.math.log?view=net-6.0

public static double Log (double a, double newBase); <----- so this is a method? Should I define the method below, to include the formula?
thus..
public static double Log (double a, double 2);
will need to insert the range into the log formula for "double 'a'"
public static double Log (double {maxGuesses}, double 2);

// The following is my initial algorithm (without any further revisions), written before I conducted any research into best practices for implementing a binary search in C#.

Say, user's number is 512.

Sample run-through:

starting parameter:
min = 0
Max = 1024

starting guessFormula = min + max / 2
Guess: 512

    METHODS:

            response == "Y" or "y" or "yes"
              Console.WriteLine("Well that was easy.")

            response == h (higher)
              set new minimum equal to guess (512)
                newGuess = (Max (1024) + newMinimum (512) / 2)
                newGuess = (768)
                Return to line 69 and ask with newGuess

            response == l (lower)
              set new maximum equal to guess (512)
                newGuess = (Max (512) + newMinimum (0) / 2)
                newGuess = (256)
                Return to line 69 and ask with newGuess






//var negativeUserResponse = new List<string>() { "n", "N", "no", "NO", "No", "Nope", "nope", "Nerp", "nerp" };
//_____________________________________________________________________________________________________________________

// for (userResponse = "h"; userResponse != "l"; var newGuess = (numberRangeMaximum + numberRangeMinimum) / 2)
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


