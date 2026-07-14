namespace NumberGuessingGame
{
    //This class is the UI definition for the Number Guessing Game.It will ask the user to select a difficulty level, then ask them to guess a number until they get it correct.  It will then ask if they want to play again.
    internal class Program
    {

        static void Main(string[] args) // The Main method is the entry point of the application. It will run the game loop until the user decides to quit.
        {
            bool gameOver = false;
            bool inputValid = false;

            while (!gameOver)
            {
                int maximum = 0;
                string difficulty = string.Empty;
                inputValid = false;

                while (!inputValid)
                {
                    Console.WriteLine("What Difficulty would you like? (E), (M), (H)");
                    difficulty = Console.ReadLine();

                    if ((difficulty == "E") || (difficulty == "M") || (difficulty == "H"))
                    {
                        inputValid = true;

                    }
                    else
                    {
                        Console.WriteLine("Please type (E), (M) or (H)");
                        inputValid = false;
                    }
                }

                if (difficulty == "E")
                {
                    maximum = 10;
                }
                else if (difficulty == "M")
                {
                    maximum = 50;
                }
                else
                {
                    maximum = 1000;
                }

                NumberGuessing numberGuessing = new NumberGuessing(1, maximum);


                bool guessed = false;

                while (!guessed)
                {
                    Console.WriteLine("Please enter your guess:");

                    string guess = Console.ReadLine();
                    GuessResult result = numberGuessing.MakeGuess(int.Parse(guess));

                    if (result == GuessResult.TooLow)
                    {
                        Console.WriteLine("Your Guess is too LOW!  Please try again.");
                    }
                    else if (result == GuessResult.TooHigh)
                    {
                        Console.WriteLine("Your Guess is too HIGH!  Please try again.");

                    }
                    else if (result == GuessResult.Correct)
                    {
                        Console.WriteLine("Well Done!!!  You are correct.");
                        guessed = true;

                    }
                    else if (result == GuessResult.OutOfRange);
                    {
                        Console.WriteLine("Out of range, are you kidding me?  Please try again.");
                    }

                }

                inputValid = false;
                string playAgain = string.Empty;

                while (!inputValid)
                {
                    Console.WriteLine("Do you want to play again? (Y) or (N)");
                    playAgain = Console.ReadLine();

                    playAgain = playAgain.ToUpper();

                    if ((playAgain == "Y") || (playAgain == "N"))
                    {
                        inputValid = true;

                    }
                    else
                    {
                        Console.WriteLine("Please type (Y) or (N)");
                        inputValid = false;
                    }

                }

                if (playAgain == "N")
                {
                    gameOver = true;
                }
                else if (playAgain == "Y")
                {
                    gameOver = false;
                }

            }
        }
    }
}