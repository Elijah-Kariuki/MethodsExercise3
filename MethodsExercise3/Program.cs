using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        public static void CountToAThousand()
        {
            var numbers = new List<int>();
            var currentNumber = 0;
            while(currentNumber < 1000)
            {
                currentNumber++;
                numbers.Add(currentNumber);
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

        }

        public static void CountByThreeTo1000()
        {
            var numbers = new List<int>();
            var currentNumber = 0;
            while (currentNumber < 1000)
            {
                currentNumber++;
                if (currentNumber % 3 == 0)
                {
                    numbers.Add(currentNumber);
                }
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

        }
        public static void IsEqual()
        {
            Console.WriteLine("This method checks to see if two numbers you provide are the same\nIf the numbers are the same ");
            Console.WriteLine("Please provide the first number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the second number");
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"Yes, {firstNumber} and {secondNumber} are the same");
            }
            else
                Console.WriteLine($"No, {firstNumber} and {secondNumber} are not the same");
             
        }

        public static void IsOdd()
        {
            Console.WriteLine("This method checks to see if an integer you provide is odd");
            Console.WriteLine("Please provide a number");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 1)
            {
                Console.WriteLine($"Yes, {userNumber} is odd");
            }
            else
                Console.WriteLine($"No, {userNumber} is not odd");

        }

        public static void IsPositive()
        {
            Console.WriteLine("This method checks to see if a number you provide is positive or negative");
            Console.WriteLine("Please provide a number");
            double userNumber = int.Parse(Console.ReadLine());
            if (userNumber > 0)
            {
                Console.WriteLine($"Yes, {userNumber} is positive");
            }
            else
                Console.WriteLine($"No, {userNumber} is not positive. The number {userNumber} is negative");

        }

        public static void IsVotingAge()
        {
            Console.WriteLine("This method checks to see if you are old enough to vote");
            Console.WriteLine("Please provide how old you will be on November 8, 2022");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge >= 18 )
            {
                Console.WriteLine($"You will be {userAge} years old on this year's final voting day and will be old enough to vote");
            }
            else
                Console.WriteLine($"You will be {userAge} years old on this year's final voting day and will not be old enough to vote");

        }
        public static void BetweenTenAndNegativeTen()
        {
            Console.WriteLine("This method checks to see if a number you provide is between -10 and 10");
            Console.WriteLine("Please provide a number");
            double userNumber = double.Parse(Console.ReadLine());
            if (userNumber >= -10 && userNumber<= 10)
            {
                Console.WriteLine($"Yes, {userNumber} is between -10 and 10");
            }
            else
                Console.WriteLine($"No, {userNumber} is not between -10 and 10");

        }
        public static void MultiplicationTablesToTwelve()
        {
            var numbers = new List<int>();
            var currentNumber = 0;
            var tableNumber = 0;
            var table = new List<int>();
            Console.WriteLine("This method provides the value of any number you provide multiplied from 1 to 12");
            Console.WriteLine("Please provide a whole number");
            var userNumber = int.Parse(Console.ReadLine());
            while (currentNumber < 12)
            {
                currentNumber++;
                numbers.Add(currentNumber);
            }


            foreach (int item in numbers)
            {
                tableNumber++;
                int multiply = item * userNumber;
                table.Add(multiply);
                Console.WriteLine($"{userNumber} multiplied by {tableNumber} equals {multiply}");
            }
            

        }


        static void Main(string[] args)
        {
            //CountToAThousand();
            //CountByThreeTo1000();
            //IsEqual();
            //IsOdd();
            //IsPositive();
            //IsVotingAge();
            //BetweenTenAndNegativeTen();
            MultiplicationTablesToTwelve();
        }
    }
}
