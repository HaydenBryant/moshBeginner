using System;

namespace demoIfElseSwitch
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*int hour = 10;

            if(hour > 0 && hour < 12)
                Console.WriteLine("It's Morning.");
            else if(hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon.");
            else
                Console.WriteLine("It's evening.");

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);*/

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("Weve got promotion");
                    break;
                default:
                    Console.WriteLine("I dont understand this season");
                    break;
            }


        }
    }
}
