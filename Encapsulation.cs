using System;

namespace OOP_Example
{
    class Car
    {
        public int mileage = 60;
        public string color = "orange";
        private string formula = "a * b";

        public int GetMileage()
        {
            return mileage;
        }
        public string GetColor()
        {
            return color;
        }
        private string GetFormula()
        {
            return formula;
        }
    }
    class Encapsulation
    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine("Car Mileage is:" + c.GetMileage());
            Console.WriteLine("Car Color is:" + c.GetColor());
        }
    }
}