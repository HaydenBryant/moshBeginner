using System;

namespace loopExercises
{
    class Program
    {
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        public void Exercise1()
        {
            var count = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or type 'ok' to eit");
                var userInput = Console.ReadLine();

                if (userInput == "ok")
                    break;

                sum += Convert.ToInt32(userInput);
            }
            Console.WriteLine(sum);
        }

        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        public void Exercise3()
        {
            Console.WriteLine("Please enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var sum = 0;
            for (var i = 0; i <= number; i++)
                sum *= i;

            Console.WriteLine("{0}! = {1}", number, sum);
        }

        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won". Otherwise, display “You lost".
        public void Exercise4()
        {
            var randomNumber = new Random().Next(1, 10);
            //randomNumber.Next(1, 10);

            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if(guess == randomNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lose");
        }

        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        public void Exercise5()
        {
            Console.WriteLine("Enter comma seperated numbers: ");
            var userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var number in numbers)
            {
                var numberInt = Convert.ToInt32(number);
                if(numberInt > max)
                {
                    max = numberInt;
                }
            }
            Console.WriteLine(max);
        }
    }
}