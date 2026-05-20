using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    public interface IPrototype<T>
    {
        T Clone();
    }

    public class PrototypeCircle : Circle, IPrototype<PrototypeCircle>
    {
        public PrototypeCircle(double radius) : base(radius) { }

        public PrototypeCircle Clone()
        {
            return new PrototypeCircle(this.Radius);
        }
    }

    public class PrototypeRectangle : Rectangle, IPrototype<PrototypeRectangle>
    {
        public PrototypeRectangle(double width, double height) : base(width, height) { }

        public PrototypeRectangle Clone()
        {
            return new PrototypeRectangle(this.Width, this.Height);
        }
    }
}
