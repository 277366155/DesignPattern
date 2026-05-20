using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    public interface IShapeFlyweight
    {
        void Display(int x, int y);
    }

    public class CircleFlyweight : IShapeFlyweight
    {
        private string _color;
        private double _radius;

        public CircleFlyweight(string color, double radius)
        {
            _color = color;
            _radius = radius;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"显示{_color}圆形，半径{_radius}，位置({x}, {y})");
        }
    }

    public class ShapeFlyweightFactory
    {
        private Dictionary<string, IShapeFlyweight> _flyweights = new Dictionary<string, IShapeFlyweight>();

        public IShapeFlyweight GetCircleFlyweight(string color, double radius)
        {
            string key = $"{color}_{radius}";
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new CircleFlyweight(color, radius);
                Console.WriteLine($"创建新的享元对象：{key}");
            }
            return _flyweights[key];
        }

        public int GetFlyweightCount()
        {
            return _flyweights.Count;
        }
    }
}
