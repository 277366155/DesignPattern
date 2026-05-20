using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// 三角形类，继承自 Shape 抽象基类
    /// 实现了三角形特定的面积和周长计算
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// 三角形的第一条边
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// 三角形的第二条边
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// 三角形的第三条边
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// 三角形构造函数
        /// </summary>
        /// <param name="sideA">第一条边的长度</param>
        /// <param name="sideB">第二条边的长度</param>
        /// <param name="sideC">第三条边的长度</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// 计算三角形面积
        /// 使用海伦公式：面积 = √[p(p-a)(p-b)(p-c)]
        /// 其中 p 为半周长
        /// </summary>
        /// <returns>返回三角形的面积</returns>
        public override double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// 计算三角形周长
        /// 使用公式：周长 = a + b + c
        /// </summary>
        /// <returns>返回三角形的周长</returns>
        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
