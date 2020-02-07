using System;
using System.IO;

namespace fileDemos09
{
    class Program
    {
        static void Main(string[] args)
        {
            //FILE

            //static method
            //os does security check every call
            //more effective if using small amount of files less times
            var path = @"c:someFIle.jpg";
            File.Copy(@"c:\temp\myFile.jpg", @"d:\temp\myFile.jpg", true);
            File.Delete(path);
            if(File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            //creat object and use instance methods more effective for large use
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //
            }

            //DIRECTORY

            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", ".sln", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
            //file infor class c# MSDN

        }
    }
}
