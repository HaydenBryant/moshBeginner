using System;
using System.IO;

namespace pathEercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //eercise 1
            var path = @"c:someTextFile.jpg";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);

                var count = 0;

                foreach (var word in content.Split(' '))
                    count++;
            }

            //eercise 2
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);

                var count = 0;
                var maxWord = 0;

                foreach (var word in content.Split(' '))
                {
                    count = 0;
                    foreach (var letter in word.Split())
                    {
                        count++;
                    }
                    if(count > maxWord)
                    {
                        maxWord = count;
                    }
                }
            }
        }
    }
}
