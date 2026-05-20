using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    public abstract class ShapeFactory
    {
        public abstract Shape CreateShape();
    }

    public class CircleFactory : ShapeFactory
    {
        private double _radius;

        public CircleFactory(double radius)
        {
            _radius = radius;
        }

        public override Shape CreateShape()
        {
            return new Circle(_radius);
        }
    }

    public class RectangleFactory : ShapeFactory
    {
        private double _width;
        private double _height;

        public RectangleFactory(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override Shape CreateShape()
        {
            return new Rectangle(_width, _height);
        }
    }
}
