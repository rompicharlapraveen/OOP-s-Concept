// Method Overloading
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Example
{
    class Polymorphism
    {
        public static void Area(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public static void Area(int x)
        {
            Console.WriteLine(x * x);
        }
        public static void Area(double x, double y)
        {
            Console.WriteLine(x * y);
        }
        public static void Main(string[] args)
        {
            Area(10, 20);
            Area(10);
            Area(5.2, 3.2);
        }
    }
}
