using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    /// <summary>
    /// 形状指导者类
    /// 建造者模式的指导者角色
    /// 负责调用建造者的方法，按特定顺序构建产品
    /// </summary>
    public class ShapeDirector
    {
        /// <summary>
        /// 建造者对象
        /// 建造者模式的抽象建造者角色实例
        /// </summary>
        private IShapeBuilder _builder;

        /// <summary>
        /// 形状指导者构造函数
        /// </summary>
        /// <param name="builder">具体的建造者对象</param>
        public ShapeDirector(IShapeBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// 构建产品的方法
        /// 定义构建产品的步骤顺序
        /// 先构建形状，再构建颜色
        /// </summary>
        public void Construct()
        {
            _builder.BuildShape();
            _builder.BuildColor();
        }

        /// <summary>
        /// 获取构建结果的方法
        /// </summary>
        /// <returns>返回构建完成的 ColoredShape 对象</returns>
        public ColoredShape GetResult()
        {
            return _builder.GetColoredShape();
        }
    }

    /// <summary>
    /// 形状建造者接口
    /// 建造者模式的抽象建造者角色
    /// 定义创建产品各个部件的抽象方法
    /// </summary>
    public interface IShapeBuilder
    {
        /// <summary>
        /// 构建形状部件的方法
        /// </summary>
        void BuildShape();

        /// <summary>
        /// 构建颜色部件的方法
        /// </summary>
        void BuildColor();

        /// <summary>
        /// 获取构建完成的产品的方法
        /// </summary>
        /// <returns>返回构建完成的 ColoredShape 对象</returns>
        ColoredShape GetColoredShape();
    }

    /// <summary>
    /// 红色圆形建造者类
    /// 建造者模式的具体建造者角色
    /// 实现 IShapeBuilder 接口，构建红色圆形产品
    /// </summary>
    public class RedCircleBuilder : IShapeBuilder
    {
        /// <summary>
        /// 正在构建的产品对象
        /// 建造者模式的产品角色
        /// </summary>
        private ColoredShape _coloredShape = new ColoredShape();

        /// <summary>
        /// 圆形的半径
        /// </summary>
        private double _radius;

        /// <summary>
        /// 红色圆形建造者构造函数
        /// </summary>
        /// <param name="radius">圆形的半径</param>
        public RedCircleBuilder(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// 构建形状部件的具体方法
        /// 创建圆形对象并设置到产品中
        /// </summary>
        public void BuildShape()
        {
            _coloredShape.Shape = new Circle(_radius);
        }

        /// <summary>
        /// 构建颜色部件的具体方法
        /// 创建红色对象并设置到产品中
        /// </summary>
        public void BuildColor()
        {
            _coloredShape.Color = new Red();
        }

        /// <summary>
        /// 获取构建完成的产品的方法
        /// </summary>
        /// <returns>返回构建完成的 ColoredShape 对象</returns>
        public ColoredShape GetColoredShape()
        {
            return _coloredShape;
        }
    }

    /// <summary>
    /// 彩色形状类
    /// 建造者模式的产品角色
    /// 由形状和颜色两个部件组成的复杂产品
    /// </summary>
    public class ColoredShape
    {
        /// <summary>
        /// 形状部件
        /// </summary>
        public Shape Shape { get; set; }

        /// <summary>
        /// 颜色部件
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// 显示产品的方法
        /// 组合使用形状和颜色部件的功能
        /// </summary>
        public void Show()
        {
            Shape.Draw();
            Color.Fill();
        }
    }
}
