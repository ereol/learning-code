using System;
using Math;

namespace main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Hello Mum\n");
            Console.Write("Please enter a whole number from 1-100: ");

            int number = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("\nIt was " + computerNumber);
            



        }
    }
}
