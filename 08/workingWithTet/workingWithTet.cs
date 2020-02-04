using System;
using System.Collections.Generic;

namespace workingWithTet08
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Hayden Bryant ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var inde = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, inde);
            var lastName = fullName.Substring(inde + 1);
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            Console.WriteLine(fullName.Replace("Hayden", "Hayde"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

            //summarie text
            var sentence = "This is going to be a really really really really really long text.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}