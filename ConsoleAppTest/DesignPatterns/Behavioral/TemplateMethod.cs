using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public abstract class ShapeProcessor
    {
        public void Process()
        {
            Initialize();
            CreateShape();
            Customize();
            Finalize();
        }

        protected virtual void Initialize()
        {
            Console.WriteLine("初始化形状处理器");
        }

        protected abstract void CreateShape();

        protected virtual void Customize()
        {
            Console.WriteLine("对形状进行自定义（默认实现）");
        }

        protected virtual void Finalize()
        {
            Console.WriteLine("完成形状处理");
        }
    }

    public class CircleProcessor : ShapeProcessor
    {
        protected override void CreateShape()
        {
            Console.WriteLine("创建圆形");
        }

        protected override void Customize()
        {
            Console.WriteLine("设置圆形的半径为5");
        }
    }

    public class RectangleProcessor : ShapeProcessor
    {
        protected override void CreateShape()
        {
            Console.WriteLine("创建矩形");
        }
    }
}
