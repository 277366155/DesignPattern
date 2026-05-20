using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }

    public class ShapeAggregate : IAggregate<Shape>
    {
        private List<Shape> _shapes = new List<Shape>();

        public void Add(Shape shape)
        {
            _shapes.Add(shape);
        }

        public Shape Get(int index)
        {
            return _shapes[index];
        }

        public int Count
        {
            get { return _shapes.Count; }
        }

        public IIterator<Shape> CreateIterator()
        {
            return new ShapeIterator(this);
        }
    }

    public class ShapeIterator : IIterator<Shape>
    {
        private ShapeAggregate _aggregate;
        private int _current = 0;

        public ShapeIterator(ShapeAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public bool HasNext()
        {
            return _current < _aggregate.Count;
        }

        public Shape Next()
        {
            return _aggregate.Get(_current++);
        }
    }
}
