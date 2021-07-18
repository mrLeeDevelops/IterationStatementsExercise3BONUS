
  
using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        public static void PrintNums()
        {
            Console.WriteLine("This method will display all numbers 1000 through -1000.");
            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void ByThree()
        {
            Console.WriteLine("This method will display numbers 3 through 999 by 3 each time.");
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualNumbers()
        {
            Console.WriteLine("This method will accept two numbers, compare them, and determine if they are equal or not.");
            Console.WriteLine("Enter the first number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("The numbers ARE equal.");
            }
            else
            {
                Console.WriteLine("The numbers ARE NOT equal.");
            }
        }
        public static void OddOrEven()
        {
            Console.WriteLine("This method will accept a number, and determine whether it is ODD or EVEN.");
            Console.WriteLine("Please enter the number to be evaluated.");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is EVEN.");
            }
            else
            {
                Console.WriteLine("The number is ODD.");
            }
        }

        public static void PosOrNeg()
        {
            int num;
            Console.WriteLine("This method will accept a number, and determine whether it is POSITIVE or NEGATIVE.");
            Console.WriteLine("Please enter the number to be evaluated.");
            num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("The number is POSITIVE.");
            }
            else
            {
                Console.WriteLine("The number is NEGATIVE.");
            }
        }

        public static void OfVotingAge()
        {
            Console.WriteLine("This method will accept a number as an age and inform the user whether or not they can vote.");
            Console.WriteLine($"How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"Yes, you are of voting age");
            }
            else if(age == 17)
            {
                Console.WriteLine("Sorry, you are too young to vote by 1 year. See you next year!");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too young to vote by {18 - age} years");
            }
        }

        public static void InRange()
        {
            int num;
            Console.WriteLine("This method will accept a number and determine if it is in range of -10 to 10.");
            Console.WriteLine("Please enter a number for evaluation.");
            num = int.Parse(Console.ReadLine());
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("The number IS in range.");
            }
            else
            {
                Console.WriteLine("The number is OUT of range.");
            }
        }

        public static void MultiplicationTable()
        {
            int num;
            Console.WriteLine("This method will accept a number and display its multiplication table(from 1 to 12).");
            Console.WriteLine("Please enter a number.");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Thefollowing is a multiplication table from 1 to 12 for the number {num}.");
            Console.WriteLine("");
            Console.WriteLine($"{num} X 1 = {num * 1}."); Console.WriteLine($"{num} X 2 = {num * 2}.");
            Console.WriteLine($"{num} X 3 = {num * 3}."); Console.WriteLine($"{num} X 4 = {num * 4}.");
            Console.WriteLine($"{num} X 5 = {num * 5}."); Console.WriteLine($"{num} X 6 = {num * 6}.");
            Console.WriteLine($"{num} X 7 = {num * 7}."); Console.WriteLine($"{num} X 8 = {num * 8}.");
            Console.WriteLine($"{num} X 9 = {num * 9}."); Console.WriteLine($"{num} X 10 = {num * 10}.");
            Console.WriteLine($"{num} X 11 = {num * 11}."); Console.WriteLine($"{num} X 12 = {num * 12}.");
        }
        public static int[] CreateRandoArray()
        {
            Console.WriteLine($"How many items would you like in your array?");

            var userInput = int.Parse(Console.ReadLine());

            var newArray = new int[userInput];

            for (int i = 0; i < newArray.Length; i++)
            {
                var random = new Random();

                newArray[i] = random.Next(1, 3000);
            }

            return newArray;
        }
        public static void Main(string[] args)
        {
            int[] otherArray = new int[0];
            PrintNums();
            ByThree();
            EqualNumbers();
            OddOrEven();
            PosOrNeg();
            OfVotingAge();
            InRange();
            MultiplicationTable();
            CreateRandoArray();
        }
    }
}          /*
             *  1. Write a method that will print to the console all numbers 1000 through -1000. - DONE
             *  
                2. Write a method that will print to the console numbers 3 through 999 by 3 each time.  - DONE

                3. Write a method to accept two integers as parameters and check whether they are equal or not. - DONE

                4. Write a method to check whether a given number is even or odd. - DONE

                5. Write a method to check whether a given number is positive or negative. - DONE

                6. Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... 
                   or the safer TryParse() for an extra challenge!! - DONE

                7. Write a method to check if an integer (from the user) is in the range -10 to 10. - DONE

                8. Write a method to display the multiplication table(from 1 to 12) of a given integer. - DONE
                
                9. Write a method that takes a number from the user and returns an array with that many indexes. The values shall be random numbers. - DONE
             
             */

        
