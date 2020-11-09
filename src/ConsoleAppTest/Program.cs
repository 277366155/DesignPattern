using ConsoleAppTest.DesignPatterns;
using Repositorys.TCC;
using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {

            TCCTest();
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

        static void TCCTest()
        {
            var animalService = new AnimalService();
            animalService.InsertAllDbTCC();
        }
    }
}
