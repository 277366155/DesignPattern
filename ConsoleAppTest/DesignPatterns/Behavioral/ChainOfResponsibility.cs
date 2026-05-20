using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public abstract class ShapeHandler
    {
        protected ShapeHandler _nextHandler;

        public void SetNext(ShapeHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void HandleRequest(string request);
    }

    public class CircleHandler : ShapeHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Circle")
            {
                Console.WriteLine("圆形处理器处理请求");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

    public class RectangleHandler : ShapeHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Rectangle")
            {
                Console.WriteLine("矩形处理器处理请求");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

    public class TriangleHandler : ShapeHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Triangle")
            {
                Console.WriteLine("三角形处理器处理请求");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
