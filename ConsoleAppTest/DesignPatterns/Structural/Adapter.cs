using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    public interface IGeometricShape
    {
        void DisplayInfo();
    }

    public class ShapeAdapter : IGeometricShape
    {
        private Shape _adaptee;

        public ShapeAdapter(Shape shape)
        {
            _adaptee = shape;
        }

        public void DisplayInfo()
        {
            _adaptee.Draw();
        }
    }

    public class LegacyShape
    {
        public void ShowDetails()
        {
            Console.WriteLine("这是一个旧版形状对象");
        }
    }

    public class LegacyShapeAdapter : IGeometricShape
    {
        private LegacyShape _legacyShape;

        public LegacyShapeAdapter(LegacyShape legacyShape)
        {
            _legacyShape = legacyShape;
        }

        public void DisplayInfo()
        {
            _legacyShape.ShowDetails();
        }
    }
}
