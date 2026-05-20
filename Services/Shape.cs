using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public abstract class Shape
    {
        protected string shapeName;

        public Shape()
        {
            SetShapeName();
        }

        protected virtual void SetShapeName()
        {
            this.shapeName = this.GetType().Name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public virtual void Draw()
        {
            Console.WriteLine($"绘制{shapeName}，面积：{GetArea():F2}，周长：{GetPerimeter():F2}");
        }
    }
}
