using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Creational
{
    /// <summary>
    /// 单例模式类
    /// 确保一个类只有一个实例，并提供一个全局访问点
    /// 采用双重检查锁定机制实现线程安全
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 单例模式的唯一实例
        /// 使用 volatile 关键字确保多线程环境下的正确初始化
        /// </summary>
        private static Singleton _instance;

        /// <summary>
        /// 用于线程安全的锁对象
        /// 确保在多线程环境下只有一个线程能够创建实例
        /// </summary>
        private static readonly object _lock = new object();

        /// <summary>
        /// 私有构造函数
        /// 防止外部直接实例化，确保单例特性
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("单例模式实例被创建");
        }

        /// <summary>
        /// 获取单例实例的静态方法
        /// 使用双重检查锁定实现线程安全的单例创建
        /// </summary>
        /// <returns>返回唯一的 Singleton 实例</returns>
        public static Singleton GetInstance()
        {
            // 第一次检查：如果实例已存在，直接返回，避免不必要的锁操作
            if (_instance == null)
            {
                // 获取锁，确保只有一个线程可以进入临界区
                lock (_lock)
                {
                    // 第二次检查：防止多个线程同时通过第一次检查后重复创建实例
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// 单例模式的业务方法
        /// 演示单例对象的功能
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine("单例模式执行操作");
        }
    }
}
