using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// 颜色抽象基类
    /// 定义了所有颜色必须实现的填充功能接口
    /// </summary>
    public abstract class Color
    {
        /// <summary>
        /// 颜色名称
        /// 用于标识具体的颜色类型
        /// </summary>
        protected string colorName;

        /// <summary>
        /// 颜色构造函数
        /// 在实例化时自动设置颜色名称
        /// </summary>
        public Color()
        {
            SetColorName();
        }

        /// <summary>
        /// 设置颜色名称的方法
        /// 默认为类名，子类可以重写此方法来自定义名称
        /// </summary>
        protected virtual void SetColorName()
        {
            this.colorName = this.GetType().Name;
        }

        /// <summary>
        /// 填充颜色的抽象方法
        /// 所有具体颜色类必须实现此方法
        /// </summary>
        public abstract void Fill();
    }
}
