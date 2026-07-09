using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
        int numberToGuess;
        int minimum;
        int maximum;
      public NumberGuessing(int minimum, int maximum)
        {

            GenerateRandomNumber(minimum,maximum);
        }
        void GenerateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();
            numberToGuess=rand.Next(minimum, maximum);
            this.minimum = minimum;
            this.maximum = maximum;

        }
        
    public  GuessResult MakeGuess(int guess)
        {
            if (guess < minimum)
            {
                return GuessResult.OutOfRange;
            }
            else
                if (guess > maximum)
                {
                    return GuessResult.OutOfRange;
                }

            if (guess == numberToGuess)
            {
                return GuessResult.Correct;
                //GuessResult result = GuessResult.Correct;
                //Console.WriteLine("Congratulations! You guessed the correct number.");
            }
            else if (guess < numberToGuess)
            {
                return GuessResult.TooLow;
                //Console.WriteLine("Your guess is too low. Try again.");
            }
            else
            {
                return GuessResult.TooHigh;
                //Console.WriteLine("Your guess is too high. Try again.");
            }
            /* else
               {
                   return GuessResult.OutOfRange;
                   //Console.WriteLine("Your guess is out of range. Please enter a valid number.");
               }
              */
        }
    }
    
}
