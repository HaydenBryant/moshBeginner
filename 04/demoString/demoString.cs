using System;

namespace stringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number;
            var firstName = "Hayden";
            var lastName = "Bryant";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Jonh", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "@Hi John" +
                "Look into the following paths" +
                "c:\\folder1\\folder2";
            Console.WriteLine(text);
        }
    }
}
