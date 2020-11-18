using System;

namespace ConsoleAppTest.DesignPatterns
{
    /// <summary>
    /// 模板模式（即，子类重写父类方法的实现）
    /// </summary>
    public class Template
    {
        public abstract class Car
        {
            public abstract void CarRun();
        }

        public class Car1 : Car
        {
            public override void CarRun()
            {
                Console.WriteLine("Car1 is running.");
            }
        }

        public class Car2 : Car
        {
            public override void CarRun()
            {
                Console.WriteLine("Car2 is running.");
            }
        }

    }
}
