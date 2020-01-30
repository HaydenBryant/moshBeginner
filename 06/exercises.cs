using System;
using System.Collections.Generic;

namespace arrayListsExercises
{
    class Program
    {
        /// <summary>
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        public static void Exercise1()
        {
            var friends = new List<string>();

            while(true)
            {
                Console.WriteLine("Please enter a name or hit enter to quit: ");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                    break;

                friends.Add(name);
            }
            if(friends.Count > 2)
                Console.WriteLine("{0}, {1}, and {2} others like your post.", friends[0], friends[1], (friends.Count - 2));
            else if(friends.Count == 2)
                Console.WriteLine("{0} and {1} liked your post.", friends[0], friends[1]);
            else if(friends.Count == 1)
                Console.WriteLine("{0} liked your post.", friends[0]);
            else
                Console.WriteLine();
        }

        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        public static void Exercise2()
        {
            Console.WriteLine("What is your name: ");
            var userName = Console.ReadLine();

            var nameArray = new char[userName.Length];

            for(var i = userName.Length; i > 0; i--)
                nameArray[userName.Length - i] = userName[i - 1];

            var reversedName = new string(nameArray);
            Console.WriteLine("Reversed name: " + reversedName);
        }

        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        /// </summary>
        public static void Exercise3()
        {
            var numbers = new List<int>;

            while(numbers.Count < 5)
            {
                Console.WriteLine("Enter a unique number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("Youve already entered this number. Please enter another");
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            foreach(var number in numbers)
                Console.WriteLine(number);
        }

        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        public void Exercise4()
        {

        }


        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        public void Exercise5()
        {

        }

        static void Main(string[] args)
        {
            arrayListsExercises.Program.Exercise1();
            arrayListsExercises.Program.Exercise2();
            arrayListsExercises.Program.Exercise3();
        }
    }
}
