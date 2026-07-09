namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            Console.WriteLine("input a number ");
            string difficulty = Console.ReadLine();
            if (difficulty == "E")
            {
                maximum = 10;
            }
            else if (difficulty == "M")
            {
                maximum = 100;
            }
            else  
            {
                maximum = 1000;
            }
            NumberGuessing numberGuessing = new NumberGuessing(1 ,maximum);
            {
                Console.WriteLine("Please enter a number between 1 and " + maximum + ":");
                string guess = Console.ReadLine();

            }
           /* {
                Console.WriteLine("Invalid input. Please enter E, M, or H.");
                return;
            }*/

            
        }
    }
}
