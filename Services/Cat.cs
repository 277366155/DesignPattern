using System;

namespace Services
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {         
        }

        public override string GetBark()
        {
            return "喵";
        }
    }
}
