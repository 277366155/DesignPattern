using ConsoleAppTest.DesignPatterns;
using Repositorys.TCC;
using System;
using static ConsoleAppTest.DesignPatterns.Template;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {

            DecoratorTest();

            Console.ReadLine();
        }

        /// <summary>
        /// 装饰者模式示例
        /// </summary>
        static void DecoratorTest()
        {
            var decorator = new Decorator();
            //吃鸡肉，米饭，苹果的顺序，可以根据需要进行调整或删减。
            var chicken = new Chicken();
            var rice = new Rice();
            var apple = new Apple();

            rice.Decorate(chicken);            
            apple.Decorate(rice);
            apple.Show();
        }

        /// <summary>
        /// 策略模式调用
        /// </summary>
        static void StrategyTest()
        {
            var animalStrategy = new Strategy("旺财", 3, Services.AnimalEnum.Dog);
            animalStrategy.AnimalShout();
        }

        /// <summary>
        /// 模板模式，即-继承
        /// </summary>
        static void TemplateTest()
        {
            Car car = new Car1();
            car.CarRun();
            car = new Car2();
            car.CarRun();
        }

        static void TCCTest()
        {
            var animalService = new AnimalService();
            animalService.InsertAllDbTCC();
        }
    }
}
