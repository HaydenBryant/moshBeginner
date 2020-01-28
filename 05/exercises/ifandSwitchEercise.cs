using System;

namespace eercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1
            string userInput;
            int num;
            Console.WriteLine("Please enter anumber between 1 and 10");
            userInput = Console.ReadLine();
            num = Convert.ToInt32(userInput);

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            //2
            string userInput;
            int number1, number2;
            Console.WriteLine("Please enter a number");
            userInput = Console.ReadLine();
            number1 = Convert.ToInt32(userInput);
            Console.WriteLine("Please enter another number");
            userInput = Console.ReadLine();
            number2 = Convert.ToInt32(userInput);

            if(number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else if(number2 > number1)
                Console.WriteLine(number2);
            else if(number2 == number1)
                Console.WriteLine("They are equal");

            //3
            string userInput;
            int width, height;
            Console.WriteLine("Please enter the image width");
            userInput = Console.ReadLine();
            width = Convert.ToInt32(userInput);
            Console.WriteLine("Please enter the image height");
            userInput = Console.ReadLine();
            height = Convert.ToInt32(userInput);
            
            if(height < width)
                Console.WriteLine("Landscape");
            else if(height > width)
                Console.WriteLine("Portrait");
            else if(height == width)
                Console.WriteLine("Cube");*/

            //4
            string userInput;
            int speedLimit, carSpeed;
            Console.WriteLine("Please enter the speed limit");
            userInput = Console.ReadLine();
            speedLimit= Convert.ToInt32(userInput);
            Console.WriteLine("Please enter the cars speed");
            userInput = Console.ReadLine();
            carSpeed = Convert.ToInt32(userInput);

            if(carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else if(carSpeed > speedLimit)
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                if(demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                {
                    switch (demeritPoints)
                    {
                        case 1:
                            Console.WriteLine("1 demerit");
                            break;
                        case 2:
                            Console.WriteLine("2 demerits");
                            break;
                        case 3:
                            Console.WriteLine("3 demerits");
                            break;
                        case 4:
                            Console.WriteLine("4 demerits");
                            break;
                        case 5:
                            Console.WriteLine("5 demerits");
                            break;
                        case 6:
                            Console.WriteLine("6 demerits");
                            break;
                        case 7:
                            Console.WriteLine("7 demerits");
                            break;
                        case 8:
                            Console.WriteLine("8 demerits");
                            break;
                        case 9:
                            Console.WriteLine("9 demerits");
                            break;
                        case 10:
                            Console.WriteLine("10 demerits");
                            break;
                        case 11:
                            Console.WriteLine("11 demerits");
                            break;
                        case 12:
                            Console.WriteLine("12 demerits");
                            break;
                        default:
                            Console.WriteLine("Demerits cant be determined");
                            break;
                    }
                }
            }
        }
    }
}
