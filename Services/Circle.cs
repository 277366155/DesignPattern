using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// 圆形类，继承自 Shape 抽象基类
    /// 实现了圆形特定的面积和周长计算
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// 圆的半径
        /// 用于计算面积和周长
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// 圆形构造函数
        /// </summary>
        /// <param name="radius">圆的半径，必须大于0</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// 计算圆形面积
        /// 使用公式：面积 = π × r²
        /// </summary>
        /// <returns>返回圆形的面积</returns>
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// 计算圆形周长（圆周长）
        /// 使用公式：周长 = 2 × π × r
        /// </summary>
        /// <returns>返回圆形的周长</returns>
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
