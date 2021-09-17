using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();

            Console.WriteLine("What is your dog's name?");
            dog.SetName(Console.ReadLine());
            dog.GetName();
            dog.Eat();
        }
    }
}