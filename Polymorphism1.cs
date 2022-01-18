// Method Overriding
using System;

namespace OOP_Example
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("This is parent class");
        }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dogs bark");
        }
    }
    class Polymorphism1
    {
       public static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Sound();
        }
    }
}
