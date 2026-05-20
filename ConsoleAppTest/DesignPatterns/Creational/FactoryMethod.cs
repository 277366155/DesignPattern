using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    /// <summary>
    /// 形状工厂抽象基类
    /// 工厂方法模式的核心抽象工厂角色
    /// 定义创建形状对象的工厂方法接口
    /// </summary>
    public abstract class ShapeFactory
    {
        /// <summary>
        /// 创建形状的抽象工厂方法
        /// 子类必须实现此方法以创建具体的形状对象
        /// </summary>
        /// <returns>返回创建的 Shape 对象</returns>
        public abstract Shape CreateShape();
    }

    /// <summary>
    /// 圆形工厂类
    /// 专门用于创建圆形对象的具体工厂
    /// </summary>
    public class CircleFactory : ShapeFactory
    {
        /// <summary>
        /// 要创建的圆形的半径
        /// </summary>
        private double _radius;

        /// <summary>
        /// 圆形工厂构造函数
        /// </summary>
        /// <param name="radius">要创建的圆形的半径</param>
        public CircleFactory(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// 创建圆形对象的具体工厂方法
        /// 实现 ShapeFactory 抽象类的 CreateShape 方法
        /// </summary>
        /// <returns>返回创建的 Circle 对象</returns>
        public override Shape CreateShape()
        {
            return new Circle(_radius);
        }
    }

    /// <summary>
    /// 矩形工厂类
    /// 专门用于创建矩形对象的具体工厂
    /// </summary>
    public class RectangleFactory : ShapeFactory
    {
        /// <summary>
        /// 要创建的矩形的宽度
        /// </summary>
        private double _width;

        /// <summary>
        /// 要创建的矩形的高度
        /// </summary>
        private double _height;

        /// <summary>
        /// 矩形工厂构造函数
        /// </summary>
        /// <param name="width">要创建的矩形的宽度</param>
        /// <param name="height">要创建的矩形的高度</param>
        public RectangleFactory(double width, double height)
        {
            _width = width;
            _height = height;
        }

        /// <summary>
        /// 创建矩形对象的具体工厂方法
        /// 实现 ShapeFactory 抽象类的 CreateShape 方法
        /// </summary>
        /// <returns>返回创建的 Rectangle 对象</returns>
        public override Shape CreateShape()
        {
            return new Rectangle(_width, _height);
        }
    }
}
