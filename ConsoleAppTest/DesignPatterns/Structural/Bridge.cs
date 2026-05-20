using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    public abstract class ShapeAbstraction
    {
        protected IColorImplementor _colorImplementor;

        public ShapeAbstraction(IColorImplementor colorImplementor)
        {
            _colorImplementor = colorImplementor;
        }

        public abstract void Draw();
    }

    public interface IColorImplementor
    {
        void ApplyColor();
    }

    public class RedImplementor : IColorImplementor
    {
        public void ApplyColor()
        {
            Console.WriteLine("应用红色");
        }
    }

    public class BlueImplementor : IColorImplementor
    {
        public void ApplyColor()
        {
            Console.WriteLine("应用蓝色");
        }
    }

    public class CircleAbstraction : ShapeAbstraction
    {
        private double _radius;

        public CircleAbstraction(double radius, IColorImplementor colorImplementor) : base(colorImplementor)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"绘制半径为{_radius}的圆形，");
            _colorImplementor.ApplyColor();
        }
    }

    public class RectangleAbstraction : ShapeAbstraction
    {
        private double _width;
        private double _height;

        public RectangleAbstraction(double width, double height, IColorImplementor colorImplementor) : base(colorImplementor)
        {
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"绘制宽{_width}高{_height}的矩形，");
            _colorImplementor.ApplyColor();
        }
    }
}
