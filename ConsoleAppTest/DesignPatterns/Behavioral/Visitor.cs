using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public interface IShapeVisitor
    {
        void Visit(VisitorCircle circle);
        void Visit(VisitorRectangle rectangle);
    }

    public interface IVisitableShape
    {
        void Accept(IShapeVisitor visitor);
    }

    public class VisitorCircle : Circle, IVisitableShape
    {
        public VisitorCircle(double radius) : base(radius) { }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class VisitorRectangle : Rectangle, IVisitableShape
    {
        public VisitorRectangle(double width, double height) : base(width, height) { }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class AreaCalculatorVisitor : IShapeVisitor
    {
        public void Visit(VisitorCircle circle)
        {
            Console.WriteLine($"圆形的面积是：{circle.GetArea():F2}");
        }

        public void Visit(VisitorRectangle rectangle)
        {
            Console.WriteLine($"矩形的面积是：{rectangle.GetArea():F2}");
        }
    }

    public class PerimeterCalculatorVisitor : IShapeVisitor
    {
        public void Visit(VisitorCircle circle)
        {
            Console.WriteLine($"圆形的周长是：{circle.GetPerimeter():F2}");
        }

        public void Visit(VisitorRectangle rectangle)
        {
            Console.WriteLine($"矩形的周长是：{rectangle.GetPerimeter():F2}");
        }
    }
}
