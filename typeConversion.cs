using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //    byte b = 1;
            //    int i = b;
            //    Console.WriteLine(i);

            //    int i = 1;
            //    byte b = (byte) i;
            //    Console.WriteLine(i);

            //    var number = "1234";
            //    int i = Convert.ToInt32(number);
            //    Console.WriteLine(i);

            try
            {
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("This number ould not be converted to byte");
            }
        }
    }
}
