using System;

namespace demoClasses
{
    public class Person
    {
        public string LastName;
        public string FirstName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }
}
