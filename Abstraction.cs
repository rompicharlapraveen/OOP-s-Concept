using System;

namespace OOP_Example
{
    class Bike
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
        public string DisplayFormula()
        {
            return GetFormula();
        }
    }
    class Abstraction
    {
       public static void Main(string[] args)
        {
            Bike b = new Bike();
            Console.WriteLine("Bike Mileage is:" +b.GetMileage());
            Console.WriteLine("Bike Color is:" +b.GetColor());
            Console.WriteLine("Bike Formula is:" + b.DisplayFormula());
        }
    }
}
