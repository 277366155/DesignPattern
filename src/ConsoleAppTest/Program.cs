using ConsoleAppTest.DesignPatterns;
using System;
using static ConsoleAppTest.DesignPatterns.Template;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {

            TemplateTest();
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

        static void TemplateTest()
        {
            Car car = new Car1();
            car.CarRun();
            car = new Car2();
            car.CarRun();
        }
    }
}
