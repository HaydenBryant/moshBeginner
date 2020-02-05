using System;
using System.Collections.Generic;
using System.Text;


namespace stringEercises08
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public static void Exercise1()
        {
            Console.WriteLine("Please enter a list of hyphen seperated numbers: ");
            var userInput = Console.ReadLine();

            var numbers = new List<int>();

            foreach(var number in userInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var isConsecutive = false;
            numbers.Sort();

            for(var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[0] + i)
                {
                    isConsecutive = true;
                    continue;
                }
                else
                {
                    isConsecutive = false;
                    break;
                }
            }

            if(isConsecutive == true)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public static void Exercise2()
        {
            Console.WriteLine("Please enter a list of hyphen seperate numbers");
            var userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
                return;

            var numbers = new List<int>();
            foreach (var number in userInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();

            for(var i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] == numbers[i - 1])
                {
                    Console.WriteLine("Duplicates");
                    break;
                }
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public static void Exercise3()
        {
            Console.WriteLine("Please enter a time value in the 24 hour format (eg. 19:00): ");
            var userInput = Console.ReadLine();

            if(String.IsNullOrEmpty(userInput))
                Console.WriteLine();

            DateTime value;

            if (!DateTime.TryParse(userInput, out value))
            {
                Console.WriteLine("Invalid Time");
            }
            else
                Console.WriteLine("OK");
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        public static void Exercise4()
        {
            Console.WriteLine("Please enter a few space seperate words: ");
            var userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";

            variableName += char.ToUpper(userInput[0]);
            for(var i = 1; i < userInput.Length; i++)
            {
                if(char.IsWhiteSpace(userInput[i - 1]))
                {
                    variableName += char.ToUpper(userInput[i]);
                }
                else if(char.IsLetterOrDigit(userInput[i]))
                {
                    variableName += char.ToLower(userInput[i]);
                }
            }

            Console.WriteLine(variableName);
        }


        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>
        public static void Exercise5()
        {
            Console.WriteLine("Please enter an english word: ");
            var userInput = Console.ReadLine().ToLower();

            var vowelCount = 0;
            var vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };

            for(var i = 0; i < userInput.Length; i++)
            {
                if (vowels.Contains(userInput[i]))
                    vowelCount++;
            }
            Console.WriteLine(vowelCount);
        }
        static void Main(string[] args)
        {
            //stringEercises08.Program.Exercise1();
            //stringEercises08.Program.Exercise2();
            //stringEercises08.Program.Exercise3();
            //stringEercises08.Program.Exercise4();
            //stringEercises08.Program.Exercise5();
        }
    }
}
