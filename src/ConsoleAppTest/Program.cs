using ConsoleAppTest.DesignPatterns;
using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.ReadLine();
        }

        /// <summary>
        /// 策略模式调用
        /// </summary>
        static void StrategyTest()
        {
            var animalStrategy = new Strategy("旺财", 3, Services.AnimalEnum.Dog);
            animalStrategy.AnimalShout();
        }
    }
}
