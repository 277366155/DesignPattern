using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// 红色类，继承自 Color 抽象基类
    /// 实现了红色特定的填充功能
    /// </summary>
    public class Red : Color
    {
        /// <summary>
        /// 填充红色的方法
        /// 输出红色填充的提示信息
        /// </summary>
        public override void Fill()
        {
            Console.WriteLine($"填充{colorName}颜色");
        }
    }
}
