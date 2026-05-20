using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public interface IMediator
    {
        void Send(string message, ShapeColleague colleague);
    }

    public abstract class ShapeColleague
    {
        protected IMediator _mediator;

        public ShapeColleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Receive(string message);
    }

    public class CircleColleague : ShapeColleague
    {
        public CircleColleague(IMediator mediator) : base(mediator) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"圆形同事收到消息：{message}");
        }
    }

    public class RectangleColleague : ShapeColleague
    {
        public RectangleColleague(IMediator mediator) : base(mediator) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"矩形同事收到消息：{message}");
        }
    }

    public class ShapeMediator : IMediator
    {
        private CircleColleague _circle;
        private RectangleColleague _rectangle;

        public CircleColleague Circle
        {
            set { _circle = value; }
        }

        public RectangleColleague Rectangle
        {
            set { _rectangle = value; }
        }

        public void Send(string message, ShapeColleague colleague)
        {
            if (colleague == _circle)
            {
                _rectangle.Receive(message);
            }
            else
            {
                _circle.Receive(message);
            }
        }
    }
}
