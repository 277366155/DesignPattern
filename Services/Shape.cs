using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// 形状抽象基类
    /// 定义了所有形状必须实现的核心功能接口
    /// 包括获取面积、周长和绘制形状的能力
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// 形状名称
        /// 用于标识具体的形状类型
        /// </summary>
        protected string shapeName;

        /// <summary>
        /// 形状构造函数
        /// 在实例化时自动设置形状名称
        /// </summary>
        public Shape()
        {
            SetShapeName();
        }

        /// <summary>
        /// 设置形状名称的方法
        /// 默认为类名，子类可以重写此方法来自定义名称
        /// </summary>
        protected virtual void SetShapeName()
        {
            this.shapeName = this.GetType().Name;
        }

        /// <summary>
        /// 计算形状面积的抽象方法
        /// 所有具体形状类必须实现此方法
        /// </summary>
        /// <returns>返回形状的面积，单位为平方单位</returns>
        public abstract double GetArea();

        /// <summary>
        /// 计算形状周长的抽象方法
        /// 所有具体形状类必须实现此方法
        /// </summary>
        /// <returns>返回形状的周长，单位为长度单位</returns>
        public abstract double GetPerimeter();

        /// <summary>
        /// 绘制形状的虚方法
        /// 默认实现为输出形状的基本信息
        /// 子类可以重写此方法提供更复杂的绘制逻辑
        /// </summary>
        public virtual void Draw()
        {
            Console.WriteLine($"绘制{shapeName}，面积：{GetArea():F2}，周长：{GetPerimeter():F2}");
        }
    }
}
