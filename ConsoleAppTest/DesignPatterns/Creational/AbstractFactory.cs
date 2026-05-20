using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    /// <summary>
    /// 抽象工厂抽象基类
    /// 抽象工厂模式的核心抽象工厂角色
    /// 定义创建相关产品家族的接口
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 创建形状产品的抽象方法
        /// 子类必须实现此方法以创建具体的形状对象
        /// </summary>
        /// <returns>返回创建的 Shape 对象</returns>
        public abstract Shape CreateShape();

        /// <summary>
        /// 创建颜色产品的抽象方法
        /// 子类必须实现此方法以创建具体的颜色对象
        /// </summary>
        /// <returns>返回创建的 Color 对象</returns>
        public abstract Color CreateColor();
    }

    /// <summary>
    /// 红色圆形工厂类
    /// 具体工厂类，用于创建红色和圆形的产品组合
    /// </summary>
    public class RedCircleFactory : AbstractFactory
    {
        /// <summary>
        /// 要创建的圆形的半径
        /// </summary>
        private double _radius;

        /// <summary>
        /// 红色圆形工厂构造函数
        /// </summary>
        /// <param name="radius">要创建的圆形的半径</param>
        public RedCircleFactory(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// 创建圆形产品的具体方法
        /// </summary>
        /// <returns>返回创建的 Circle 对象</returns>
        public override Shape CreateShape()
        {
            return new Circle(_radius);
        }

        /// <summary>
        /// 创建红色产品的具体方法
        /// </summary>
        /// <returns>返回创建的 Red 对象</returns>
        public override Color CreateColor()
        {
            return new Red();
        }
    }

    /// <summary>
    /// 蓝色矩形工厂类
    /// 具体工厂类，用于创建蓝色和矩形的产品组合
    /// </summary>
    public class BlueRectangleFactory : AbstractFactory
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
        /// 蓝色矩形工厂构造函数
        /// </summary>
        /// <param name="width">要创建的矩形的宽度</param>
        /// <param name="height">要创建的矩形的高度</param>
        public BlueRectangleFactory(double width, double height)
        {
            _width = width;
            _height = height;
        }

        /// <summary>
        /// 创建矩形产品的具体方法
        /// </summary>
        /// <returns>返回创建的 Rectangle 对象</returns>
        public override Shape CreateShape()
        {
            return new Rectangle(_width, _height);
        }

        /// <summary>
        /// 创建蓝色产品的具体方法
        /// </summary>
        /// <returns>返回创建的 Blue 对象</returns>
        public override Color CreateColor()
        {
            return new Blue();
        }
    }
}
