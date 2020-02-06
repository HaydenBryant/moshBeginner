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
        public static bool IsConsecutive(List<int> numbersList)
        {
            var numbers = new List<int>();
            numbers = numbersList;

            numbers.Sort();

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[0] + i)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public static bool ContainsDuplicates(List<int> numbersList)
        {
            var numbers = new List<int>();
            numbers = numbersList;
            numbers.Sort();

            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public static bool IsValidTime(string timeString)
        {
            if (String.IsNullOrWhiteSpace(timeString))
                return false;

            DateTime value;

            if (!DateTime.TryParse(timeString, out value))
            {
                return false;
            }
                return true;
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        public static string CreatePascalCase(string userInput)
        {
            if (String.IsNullOrWhiteSpace(userInput))
                return "";

            var variableName = "";

            variableName += char.ToUpper(userInput[0]);
            for (var i = 1; i < userInput.Length; i++)
            {
                if (char.IsWhiteSpace(userInput[i - 1]))
                {
                    variableName += char.ToUpper(userInput[i]);
                }
                else if (char.IsLetterOrDigit(userInput[i]))
                {
                    variableName += char.ToLower(userInput[i]);
                }
            }

            return variableName;
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


        }

        public static int VowelCounter(string userInput)
        {
            var vowelCount = 0;
            var vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };

            for (var i = 0; i < userInput.Length; i++)
            {
                if (vowels.Contains(char.ToLower(userInput[i])))
                    vowelCount++;
            }
            return vowelCount;
        }

        static void Main(string[] args)
        {
            /*
            //IsConsecutive
            var consecList = new List<int>() { 1, 2, 3, 4, 5 };
            var notConsecList = new List<int> { 1, 2, 4, 5, 6 };
            Console.WriteLine(stringEercises08.Program.IsConsecutive(notConsecList));

            //ContainsDuplicates
            var duplicates = new List<int>() { 1, 2, 3, 2, 4 };
            var noDuplicates = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(stringEercises08.Program.ContainsDuplicates(noDuplicates));

            //IsValidTime
            var validTime = "12:54";
            var invalidTime = "25:00";
            var invalidTime2 = "23567";
            Console.WriteLine(stringEercises08.Program.IsValidTime(invalidTime2));

            //CreatePascalCase
            var emptyString = "";
            var noCapString = "pascal case string";
            var allCapString = "PASCAL CASE STRING";
            var someCapString = "PaScAl cAse STrinG";
            Console.WriteLine(stringEercises08.Program.CreatePascalCase(someCapString));
            
            //VowelCounter
            var word = "Inadequate";
            var word1 = "inadequate";
            var word2 = "INADEQUATE";
            Console.WriteLine(stringEercises08.Program.VowelCounter(word2));
            */
        }
    }
}
