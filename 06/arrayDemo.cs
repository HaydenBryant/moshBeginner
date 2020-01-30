using System;

namespace arrayDemo06
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //inde of
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            //clear()
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
                Console.WriteLine(n);

            //sort
            Array.Sort(another);
            foreach (var n in numbers)
                Console.WriteLine(n);

            //reverse
            Array.Reverse(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
