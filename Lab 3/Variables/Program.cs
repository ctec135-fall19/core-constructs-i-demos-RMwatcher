using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations p. 68
            int myInt;
            long myLong = 0;
            double myDouble = 0.0; //64 bit
            string myStr = "some text";
            #endregion

            #region printing p. 63-67
            // building errors and wranings
            // Console.WriteLine("My Int: {0}", myInt);

            Console.WriteLine("myLong: {0}", myLong);
            Console.WriteLine("myLong: {0:c}", myLong); // c in {0:c} is for currency
            Console.WriteLine("myLong: {0:d}", myLong);
            Console.WriteLine("myLong: {0:d6}", myLong);
            Console.WriteLine("myLong: {0:X}", 31); // X in {0:X} mean convert to hexidecimal
            Console.WriteLine();


            #endregion

            #region casting p. 88-90
            byte myByte = 255;
            // won't work -> byte myByte2 = myByte + 1;
            byte myByte2 = (byte)(myByte + 1);
            Console.WriteLine("myByte: {0} + 1 = {1}", myByte, myByte2);
            // byte has a limited about of space: 255. If you add 255 with 1 (in C#) you would get 0 instead.
            #endregion

            #region strings p. 79-88
            string hello = "hello";
            string world = "world";
            string str;

            Console.WriteLine("length of hello: {0}", hello.Length);
            Console.WriteLine("test ==: {0}", hello == "hello2");
            Console.WriteLine("test ==: {0}", hello == "hello");

            // Equals() works on strings
            Console.WriteLine("test ==: {0}", hello.Equals("hello"));
            Console.WriteLine("test ==: {0}", hello.Equals("Hello"));

            // CompareTo() works on strings
            Console.WriteLine("test ==: {0}", hello.CompareTo(world));
            Console.WriteLine("test ==: {0}", hello.CompareTo(hello));

            // concatentation
            str = hello + " " + world;
            Console.WriteLine(str);

            // verbatim
            str = @"c:\MyApp\bin\debug";
            string str2 = "c:\\MyApp\\bin\\debug";

            Console.WriteLine(str);
            Console.WriteLine(str2);
            #endregion
        }
    }
}
