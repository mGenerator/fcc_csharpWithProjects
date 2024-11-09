using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Same as following
            //int x = 10;
            //int y = 20;
            //int z = 30;

            int x = 10, y = 20, z = 30;

            //Same as above
            //int x = 10, 
            //    y = 20, 
            //    z = 30;

            //declaration and initialization
            int age = -23; 

            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue + " for integer max");
            Console.WriteLine(int.MinValue + " for integer min");

            long bigNumber = -900000000L;
            Console.WriteLine(long.MaxValue + " for long max");
            Console.WriteLine(long.MinValue + " for long min");
            Console.WriteLine(bigNumber);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue + " for double max");
            Console.WriteLine(double.MinValue + " for double min");

            float precision = 5.00000F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue + " for float max");
            Console.WriteLine(float.MinValue + " for float min");

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue + " for decimal max");
            Console.WriteLine(decimal.MinValue + " for decimal min");

            //Just an assignment
            age = 50;

            Console.ReadLine();
        }
    }
}
