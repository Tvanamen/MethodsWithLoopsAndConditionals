using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PositiveToNegative();
            MultiOfThree();
            Console.WriteLine(IsEqual());
            Console.WriteLine(isEvenOrOdd());
            Console.WriteLine(positiveOrNegitive());
            Console.WriteLine(votingAge());
            Console.WriteLine(inRange());
            timesTable();
        }

        public static void PositiveToNegative()
        {
            for (int i = 1000; i > -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void MultiOfThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static bool IsEqual()
        {
            Console.WriteLine("Please enter 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var equal = (a == b) ? true : false;
            Console.WriteLine("Are your two numbers equal to each other?");
            return equal;
            // {
            // Console.WriteLine($"{a} is equal to {b}");
            // }
            //Console.WriteLine($"{a} is not equal to {b}");
        }
        public static bool isEvenOrOdd()
        {
            Console.WriteLine("Please enter a number");
            int firstInput = int.Parse(Console.ReadLine());
            var even = (firstInput % 2 == 0) ? true : false;
            Console.WriteLine("Is your number even?");
            return even;
            //{
            //Console.WriteLine($"{firstInput} is even");
            //} while (firstInput % 2 == 1) ;
            //Console.WriteLine($"{firstInput} is odd");
        }
        public static bool positiveOrNegitive()
        {
            Console.WriteLine("Please enter a number");
            int userInput = int.Parse(Console.ReadLine());
            var positive = (userInput >= 0) ? true : false;
            Console.WriteLine("Is your number positive?");
            return positive;
            //{
            //Console.WriteLine($"{userInput} is positive");
            //} while (userInput < 0) ;
            //Console.WriteLine($"{userInput} is negitive");

        }
        public static bool votingAge()
        {
            Console.WriteLine("Please enter your age");
            int userInput = int.Parse(Console.ReadLine());
            var votingAge = (userInput >= 21) ? true : false;
            Console.WriteLine("Are you old enough to vote?");
            return votingAge;
            //{
            //Console.WriteLine("Sweet you're old enough to vote!");
            //} while (userInput < 21) ;
            //Console.WriteLine("Sorry you are not old enough to vote come back when your 21");
        }
        public static bool inRange()
        {
            Console.WriteLine("Please enter a number");
            int userInput = int.Parse(Console.ReadLine());
            var inRange = (userInput < 10 && userInput > -10) ? true : false;
            Console.WriteLine("Is your number inbetween 10 and -10?");
            return inRange;
        }
        public static void timesTable()
        {
            Console.WriteLine("Enter a number you would like the times table for");
          //var mult = 0;
            int userInput = int.Parse(Console.ReadLine());
            int table = 0;
            for (int mult = 0; mult <= 12; mult++)
            {
                table = userInput * mult;
                Console.WriteLine(table);
            }

          //do
          //{
              //userInput* mult;
              //mult++;
          //} while (mult <= 12);

        }
    }
}