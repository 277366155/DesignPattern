using System;

namespace ConsoleAppTest.DesignPatterns
{

    public abstract class Food
    {
        public abstract void Show();
    }

    /// <summary>
    /// 装饰器模式
    /// </summary>
    public class Decorator : Food
    {
        protected Food _food;
        public void Decorate(Food food)
        {
            _food = food;
        }
        public override void Show()
        {
            if (_food != null)
            {
                _food.Show();
            }
        }
    }

    public class Chicken : Decorator
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("鸡肉。");            
        }
    }
    public class Apple : Decorator
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("苹果。");            
        }
    }
    public class Rice : Decorator
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("大米。");           
        }
    }
}
