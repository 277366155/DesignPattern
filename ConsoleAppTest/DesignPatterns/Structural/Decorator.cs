using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape _decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        public override double GetArea()
        {
            return _decoratedShape.GetArea();
        }

        public override double GetPerimeter()
        {
            return _decoratedShape.GetPerimeter();
        }

        public override void Draw()
        {
            _decoratedShape.Draw();
        }
    }

    public class BorderShapeDecorator : ShapeDecorator
    {
        public BorderShapeDecorator(Shape decoratedShape) : base(decoratedShape) { }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("添加边框装饰");
        }
    }

    public class ShadowShapeDecorator : ShapeDecorator
    {
        public ShadowShapeDecorator(Shape decoratedShape) : base(decoratedShape) { }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("添加阴影装饰");
        }
    }
}
