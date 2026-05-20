using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns
{
    /// <summary>
    /// 策略模式上下文类
    /// 策略模式的上下文角色
    /// 维护对策略对象的引用，并提供使用策略的接口
    /// </summary>
    public class Strategy
    {
        /// <summary>
        /// 策略对象（动物对象）
        /// 策略模式的抽象策略角色实例
        /// </summary>
        Animal _animail;

        /// <summary>
        /// 策略模式构造函数 - 直接传入策略对象
        /// </summary>
        /// <param name="animal">动物策略对象</param>
        public Strategy(Animal animal)
        {
            this._animail = animal;
        }

        /// <summary>
        /// 策略模式+工厂模式构造函数
        /// 通过枚举类型，使用简单工厂模式创建具体的策略对象
        /// </summary>
        /// <param name="name">动物名称</param>
        /// <param name="age">动物年龄</param>
        /// <param name="animal">动物类型枚举</param>
        public Strategy(string name, int age, AnimalEnum animal)
        {
            // 使用简单工厂模式根据枚举创建对应的动物对象
            switch (animal)
            {
                case AnimalEnum.Cat:
                    _animail = new Cat(name, age);
                    break;
                case AnimalEnum.Dog:
                    _animail = new Dog(name, age);
                    break;
            }
        }

        /// <summary>
        /// 执行动物叫声的方法
        /// 上下文类的业务方法，委托给具体策略对象执行
        /// </summary>
        public void AnimalShout()
        {
            // TODO: 其他业务处理（可在此处添加上下文相关的逻辑）
            _animail.Shout();
        }
    }
}
