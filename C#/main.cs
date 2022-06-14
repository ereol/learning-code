using System;
using System.Linq;

namespace csharp_tutorial
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
                    break;
                }
                else
                {
                    Console.Write("\nPlease enter a proper whole number: ");
                }
            }
            int computerNumber = rnd.Next(1, 100);

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

            while (Console.ReadKey().Key != ConsoleKey.Enter);
            { }

            Console.Clear();

            //Trying to learn Binary Search

            Console.WriteLine("Now lets have the computer guess your code in 7 tries.\nPlease enter a number: ");

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

            computerNumber = Convert.ToInt32(rnd.Next(1, 100));
            int tries = 0;
            string triesNumber = "try";
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
                    computerNumber /= 2;
                    tries++;
                }

                else if (computerNumber < number)
                {
                    Console.WriteLine("The computer guessed too low");
                    computerNumber = computerNumber/2 + computerNumber;
                    tries++;
                }
                else if (number < 100 || number > 0)
                {
                    Console.WriteLine("Invalid Response");
                }
                else
                {
                    Console.WriteLine("Invalid Response");
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
            while (Console.ReadKey().Key != ConsoleKey.Enter);
            { }

        }
    }
}
