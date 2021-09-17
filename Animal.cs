using System;

namespace AbstractClass
{
    public abstract class Animal
    {
        string _name;

        public void SetName(string name)
        {
            _name = name;
        }
        
        public void GetName()
        {
            Console.WriteLine(_name);
        }

        public abstract void Eat();
    }
}