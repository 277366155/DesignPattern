using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public interface IShapeState
    {
        void Handle(ShapeContext context);
    }

    public class ShapeContext
    {
        public IShapeState State { get; set; }

        public ShapeContext(IShapeState state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }

    public class DraftState : IShapeState
    {
        public void Handle(ShapeContext context)
        {
            Console.WriteLine("当前状态：草稿状态");
            context.State = new ReviewState();
        }
    }

    public class ReviewState : IShapeState
    {
        public void Handle(ShapeContext context)
        {
            Console.WriteLine("当前状态：审核状态");
            context.State = new PublishedState();
        }
    }

    public class PublishedState : IShapeState
    {
        public void Handle(ShapeContext context)
        {
            Console.WriteLine("当前状态：发布状态");
        }
    }
}
