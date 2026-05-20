using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    public class ShapeDirector
    {
        private IShapeBuilder _builder;

        public ShapeDirector(IShapeBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildShape();
            _builder.BuildColor();
        }

        public ColoredShape GetResult()
        {
            return _builder.GetColoredShape();
        }
    }

    public interface IShapeBuilder
    {
        void BuildShape();
        void BuildColor();
        ColoredShape GetColoredShape();
    }

    public class RedCircleBuilder : IShapeBuilder
    {
        private ColoredShape _coloredShape = new ColoredShape();
        private double _radius;

        public RedCircleBuilder(double radius)
        {
            _radius = radius;
        }

        public void BuildShape()
        {
            _coloredShape.Shape = new Circle(_radius);
        }

        public void BuildColor()
        {
            _coloredShape.Color = new Red();
        }

        public ColoredShape GetColoredShape()
        {
            return _coloredShape;
        }
    }

    public class ColoredShape
    {
        public Shape Shape { get; set; }
        public Color Color { get; set; }

        public void Show()
        {
            Shape.Draw();
            Color.Fill();
        }
    }
}
