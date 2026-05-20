using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    /// <summary>
    /// 形状装饰器抽象基类
    /// 装饰器模式的抽象装饰器角色
    /// 继承自 Shape 类，同时持有 Shape 对象的引用
    /// </summary>
    public abstract class ShapeDecorator : Shape
    {
        /// <summary>
        /// 被装饰的形状对象
        /// 装饰器模式的组件角色实例
        /// </summary>
        protected Shape _decoratedShape;

        /// <summary>
        /// 形状装饰器构造函数
        /// </summary>
        /// <param name="decoratedShape">要被装饰的 Shape 对象</param>
        public ShapeDecorator(Shape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        /// <summary>
        /// 获取面积的方法
        /// 委托给被装饰的形状对象
        /// </summary>
        /// <returns>返回形状的面积</returns>
        public override double GetArea()
        {
            return _decoratedShape.GetArea();
        }

        /// <summary>
        /// 获取周长的方法
        /// 委托给被装饰的形状对象
        /// </summary>
        /// <returns>返回形状的周长</returns>
        public override double GetPerimeter()
        {
            return _decoratedShape.GetPerimeter();
        }

        /// <summary>
        /// 绘制形状的方法
        /// 委托给被装饰的形状对象
        /// 具体装饰器可以重写此方法添加额外功能
        /// </summary>
        public override void Draw()
        {
            _decoratedShape.Draw();
        }
    }

    /// <summary>
    /// 边框形状装饰器类
    /// 装饰器模式的具体装饰器角色
    /// 为形状添加边框装饰功能
    /// </summary>
    public class BorderShapeDecorator : ShapeDecorator
    {
        /// <summary>
        /// 边框形状装饰器构造函数
        /// </summary>
        /// <param name="decoratedShape">要被装饰的 Shape 对象</param>
        public BorderShapeDecorator(Shape decoratedShape) : base(decoratedShape) { }

        /// <summary>
        /// 绘制形状的方法
        /// 重写基类方法，在原有的绘制功能基础上添加边框装饰
        /// </summary>
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("添加边框装饰");
        }
    }

    /// <summary>
    /// 阴影形状装饰器类
    /// 装饰器模式的具体装饰器角色
    /// 为形状添加阴影装饰功能
    /// </summary>
    public class ShadowShapeDecorator : ShapeDecorator
    {
        /// <summary>
        /// 阴影形状装饰器构造函数
        /// </summary>
        /// <param name="decoratedShape">要被装饰的 Shape 对象</param>
        public ShadowShapeDecorator(Shape decoratedShape) : base(decoratedShape) { }

        /// <summary>
        /// 绘制形状的方法
        /// 重写基类方法，在原有的绘制功能基础上添加阴影装饰
        /// </summary>
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("添加阴影装饰");
        }
    }
}
