using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns
{
    /// <summary>
    /// 装饰器模式
    /// </summary>
    public class Decorator
    {
        public void Eat()
        {
            Console.WriteLine("吃饭.");
        }

        public void Drink()
        {
            Console.WriteLine("喝酒.");
        }

        public void DrinkWater()
        {
            Console.WriteLine("喝水.");
        }

        public void Sleep()
        {
            Console.WriteLine("睡觉.");
        }
    }
}
