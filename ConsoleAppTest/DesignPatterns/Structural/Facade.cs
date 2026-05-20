using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    public class ShapeRenderer
    {
        public void RenderShape(Shape shape)
        {
            Console.WriteLine("渲染器开始工作...");
            shape.Draw();
        }
    }

    public class ColorApplier
    {
        public void ApplyColor(Color color)
        {
            Console.WriteLine("颜色应用器开始工作...");
            color.Fill();
        }
    }

    public class ShapeSaver
    {
        public void SaveShape()
        {
            Console.WriteLine("形状保存器开始工作...");
            Console.WriteLine("形状已保存");
        }
    }

    public class ShapeFacade
    {
        private ShapeRenderer _renderer;
        private ColorApplier _applier;
        private ShapeSaver _saver;

        public ShapeFacade()
        {
            _renderer = new ShapeRenderer();
            _applier = new ColorApplier();
            _saver = new ShapeSaver();
        }

        public void ProcessColoredShape(Shape shape, Color color)
        {
            Console.WriteLine("=== 外观模式开始处理 ===");
            _renderer.RenderShape(shape);
            _applier.ApplyColor(color);
            _saver.SaveShape();
            Console.WriteLine("=== 外观模式处理完成 ===");
        }
    }
}
