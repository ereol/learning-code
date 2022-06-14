using System;

namespace TestingBinarySearch
{
    class TestBinary
    {
        public static void Main(string[] args)
        {        
            int number;
            int tries = 0;
            double max = 100;
            double min = 1;
            string triesNumber = "try";
            int overtry = 0;
            double computerNumber = (min + max) / 2;
            computerNumber = Math.Floor(computerNumber);

            for (number = 1; number < 101; number++)
            {
                tries = 0;
                max = 100;
                min = 1;
                computerNumber = (min + max) / 2;
                computerNumber = Math.Floor(computerNumber);
                while (computerNumber != number)
                {
                    if (computerNumber == number)
                    {
                        Console.WriteLine("The computer guessed correct");
                        break;
                    }

                    else if (computerNumber > number)
                    {
                        Console.WriteLine("The computer guessed too high");
                        Console.WriteLine(computerNumber);
                        max = computerNumber - 1.0;
                        computerNumber = (min + max) / 2;
                        computerNumber = Math.Floor(computerNumber);
                        tries++;
                        //Console.ReadKey();
                    }

                    else if (computerNumber < number)
                    {
                        Console.WriteLine("The computer guessed too low");
                        Console.WriteLine(computerNumber);
                        min = computerNumber + 1;
                        computerNumber = (min + max) / 2;
                        computerNumber = Math.Floor(computerNumber);
                        tries++;
                        //Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\nInvalid Response.\nPlease Re-enter a number betwenn 1-100 again: ");
                    }


                }
                if (tries >= 2)
                {
                    triesNumber = " tries.";
                }
                else
                {
                    triesNumber = " try.";
                }

                Console.WriteLine("\nThe computer found your number.\nIt was " + computerNumber + "\nIt took " + tries + triesNumber + "\n\nThanks for playing!\nPress Enter to continue: ");

                if (tries > 7)
                {
                    overtry++;
                }
            }

            Console.WriteLine("There was " + overtry + " guesses past 7 attempts.");
            Console.ReadKey();
        }
    }
}