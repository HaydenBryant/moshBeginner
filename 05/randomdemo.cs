using System;

namespace loopDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //    Console.WriteLine(random.Next(1, 10));

            var random = new Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}