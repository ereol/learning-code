using System;
using System.Linq;

namespace ImThinkingOfANumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Hello Mum\n");

            Console.Write("Please enter a whole number from 1-100: ");

            //int number = Convert.ToInt32(Console.ReadLine());

            int number;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    while (number >= 101)
                    {
                        Console.WriteLine("Invalid Number.\nPlease enter a whole number from 1-100: ");
                        while (true)
                            if (int.TryParse(Console.ReadLine(), out number))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter a proper whole number: ");
                            }
                    }
                    break;
                }
                else
                {
                    Console.Write("\nPlease enter a proper whole number: ");
                }
            }
            double computerNumber = rnd.Next(1, 100);

            Console.WriteLine("");

            if (computerNumber == number)
            {
                Console.WriteLine("You are Correct");
            }

            else if (computerNumber < number)
            {
                Console.WriteLine("You are too high");
            }

            else if (computerNumber > number)
            {
                Console.WriteLine("You are too low");
            }
            else if (number < 100 || number > 0)
            {
                Console.WriteLine("Invalid Response");
            }
            else
            {
                Console.WriteLine("Invalid Response");
            }
            Console.Write("\nIt was " + computerNumber + "\nPress Enter to continue: ");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            { }

            Console.Clear();

            //Trying to learn Binary Search

            Console.WriteLine("Now lets have the computer guess your code in 7 tries.\nPlease enter a number: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    while(number >= 101)
                    {
                     Console.WriteLine("Invalid Number.\nPlease enter a whole number from 1-100: ");
                        while(true)
                         if(int.TryParse(Console.ReadLine(), out number))
                            {
                                break;
                            }
                         else
                            {
                                Console.WriteLine("\nPlease enter a proper whole number: ");
                            }
                    }
                    break;
                }
                else
                {
                    Console.Write("\nPlease enter a proper whole number: ");
                }
            }

            //computerNumber = Convert.ToInt32(rnd.Next(1, 100));
            int tries = 0;
            double max = 100;
            double min = 1;
            string triesNumber = "try";

            computerNumber = (min + max) / 2;
            computerNumber = Math.Floor(computerNumber);
            do
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
                    //computerNumber = ((1 + (computerNumber - 1) / 2));
                    // computerNumber = Math.Floor(computerNumber);
                    max = computerNumber - 1.0;
                    computerNumber = (min + max) / 2;
                    computerNumber = Math.Floor(computerNumber);

                    tries++;
                }

                else if (computerNumber < number)
                {
                    Console.WriteLine("The computer guessed too low");
                    Console.WriteLine(computerNumber);
                    // int max = computerNumber;
                    // computerNumber = computerNumber + 1;
                    // computerNumber = Math.Floor(computerNumber);
                    min = computerNumber+1;
                    computerNumber = (min + max) / 2;
                    computerNumber = Math.Floor(computerNumber);
                    tries++;
                }
                else if (number < 100 || number > 0)
                {
                    Console.Write("\nInvalid Response.\nPlease Re-enter a number between 1-100 again: ");
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("\nPlease enter a proper whole number: ");
                        }
                    }
                }
                else
                {
                    Console.Write("\nInvalid Response.\nPlease Re-enter a number betwenn 1-100 again: ");
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("\nPlease enter a proper whole number: ");
                        }
                    }
                }
            }
            while (computerNumber != number);

            if(tries >= 2)
            {
                triesNumber = " tries.";
            }
            else
            {
                triesNumber = " try.";
            }
            Console.WriteLine("\nThe computer found your number.\nIt was " + computerNumber +"\nIt took "+ tries + triesNumber + "\n\nThanks for playing!\nPress Enter to continue: ");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            { }

        }
    }
}
