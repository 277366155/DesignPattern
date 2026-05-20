using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    public abstract class Graphic
    {
        protected string name;

        public Graphic(string name)
        {
            this.name = name;
        }

        public abstract void Draw();
        public abstract void Add(Graphic graphic);
        public abstract void Remove(Graphic graphic);
        public abstract Graphic GetChild(int index);
    }

    public class LeafGraphic : Graphic
    {
        public LeafGraphic(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"绘制叶子图形：{name}");
        }

        public override void Add(Graphic graphic)
        {
            Console.WriteLine("叶子节点不能添加子节点");
        }

        public override void Remove(Graphic graphic)
        {
            Console.WriteLine("叶子节点不能移除子节点");
        }

        public override Graphic GetChild(int index)
        {
            Console.WriteLine("叶子节点没有子节点");
            return null;
        }
    }

    public class CompositeGraphic : Graphic
    {
        private List<Graphic> _children = new List<Graphic>();

        public CompositeGraphic(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"绘制组合图形：{name}，包含以下子图形：");
            foreach (var child in _children)
            {
                child.Draw();
            }
        }

        public override void Add(Graphic graphic)
        {
            _children.Add(graphic);
        }

        public override void Remove(Graphic graphic)
        {
            _children.Remove(graphic);
        }

        public override Graphic GetChild(int index)
        {
            return _children[index];
        }
    }
}
