using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// 矩形类，继承自 Shape 抽象基类
    /// 实现了矩形特定的面积和周长计算
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// 矩形的宽度
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// 矩形的高度
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// 矩形构造函数
        /// </summary>
        /// <param name="width">矩形的宽度，必须大于0</param>
        /// <param name="height">矩形的高度，必须大于0</param>
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// 计算矩形面积
        /// 使用公式：面积 = 宽度 × 高度
        /// </summary>
        /// <returns>返回矩形的面积</returns>
        public override double GetArea()
        {
            return Width * Height;
        }

        /// <summary>
        /// 计算矩形周长
        /// 使用公式：周长 = 2 × (宽度 + 高度)
        /// </summary>
        /// <returns>返回矩形的周长</returns>
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
