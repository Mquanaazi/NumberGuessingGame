namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            bool GameOver = false;
            bool validInput = false;
            string PlayAgain = string.Empty;
            string difficulty = string.Empty; 

            while (!GameOver)

            Console.WriteLine("input a number ");
            difficulty = Console.ReadLine();
            while (validInput)
            
                if ((difficulty == "E") || (difficulty == "M") || (difficulty == "H"))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }
            
            if (difficulty == "E")
            {
                maximum = 10;
            }
            else if (difficulty == "M")
            {
                maximum = 100;
            }
            else if (difficulty == "H")
            {
                maximum = 1000;
            }
            NumberGuessing numberGuessing = new NumberGuessing(1, maximum);
            {
                Console.WriteLine("Please enter a number between 1 and " + maximum + ":");
                string guess = Console.ReadLine();

            }
            /* {
                 Console.WriteLine("Invalid input. Please enter E, M, or H.");
                 return;
             }*/
            while (!validInput)
            { 
            Console.WriteLine("Do you want to play again ?(Y) or (N)");
            PlayAgain = Console.ReadLine();
            PlayAgain = PlayAgain.ToUpper();
                
                if (PlayAgain == "Y" || PlayAgain == "N")
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }

            }

                if (PlayAgain == "Y")
                {
                GameOver = false;
                    }
                else
                {
                GameOver = true;
                }
        }
    }
}
