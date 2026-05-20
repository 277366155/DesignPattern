using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    /// <summary>
    /// 几何形状接口
    /// 适配器模式的目标接口
    /// 定义客户端期望的形状信息显示接口
    /// </summary>
    public interface IGeometricShape
    {
        /// <summary>
        /// 显示形状信息的方法
        /// 客户端通过此方法与系统交互
        /// </summary>
        void DisplayInfo();
    }

    /// <summary>
    /// 形状适配器类
    /// 对象适配器模式的适配器角色
    /// 将 Shape 类适配到 IGeometricShape 接口
    /// </summary>
    public class ShapeAdapter : IGeometricShape
    {
        /// <summary>
        /// 被适配的形状对象
        /// 适配器模式的适配者角色
        /// </summary>
        private Shape _adaptee;

        /// <summary>
        /// 形状适配器构造函数
        /// </summary>
        /// <param name="shape">要适配的 Shape 对象</param>
        public ShapeAdapter(Shape shape)
        {
            _adaptee = shape;
        }

        /// <summary>
        /// 显示形状信息的方法
        /// 通过委托给被适配者的 Draw 方法实现
        /// </summary>
        public void DisplayInfo()
        {
            _adaptee.Draw();
        }
    }

    /// <summary>
    /// 旧版形状类
    /// 适配器模式的另一个适配者角色示例
    /// 代表现有的、接口不兼容的类
    /// </summary>
    public class LegacyShape
    {
        /// <summary>
        /// 显示旧版形状详情的方法
        /// 旧系统中的方法，接口与 IGeometricShape 不兼容
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("这是一个旧版形状对象");
        }
    }

    /// <summary>
    /// 旧版形状适配器类
    /// 适配器模式的适配器角色
    /// 将 LegacyShape 类适配到 IGeometricShape 接口
    /// </summary>
    public class LegacyShapeAdapter : IGeometricShape
    {
        /// <summary>
        /// 被适配的旧版形状对象
        /// </summary>
        private LegacyShape _legacyShape;

        /// <summary>
        /// 旧版形状适配器构造函数
        /// </summary>
        /// <param name="legacyShape">要适配的 LegacyShape 对象</param>
        public LegacyShapeAdapter(LegacyShape legacyShape)
        {
            _legacyShape = legacyShape;
        }

        /// <summary>
        /// 显示形状信息的方法
        /// 通过委托给被适配者的 ShowDetails 方法实现
        /// </summary>
        public void DisplayInfo()
        {
            _legacyShape.ShowDetails();
        }
    }
}
