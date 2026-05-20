using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    public abstract class AbstractFactory
    {
        public abstract Shape CreateShape();
        public abstract Color CreateColor();
    }

    public class RedCircleFactory : AbstractFactory
    {
        private double _radius;

        public RedCircleFactory(double radius)
        {
            _radius = radius;
        }

        public override Shape CreateShape()
        {
            return new Circle(_radius);
        }

        public override Color CreateColor()
        {
            return new Red();
        }
    }

    public class BlueRectangleFactory : AbstractFactory
    {
        private double _width;
        private double _height;

        public BlueRectangleFactory(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override Shape CreateShape()
        {
            return new Rectangle(_width, _height);
        }

        public override Color CreateColor()
        {
            return new Blue();
        }
    }
}
