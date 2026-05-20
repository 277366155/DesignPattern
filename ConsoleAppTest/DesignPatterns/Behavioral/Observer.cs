using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    /// <summary>
    /// 观察者接口
    /// 观察者模式的观察者角色
    /// 定义接收更新通知的接口
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 更新通知方法
        /// 当主题状态变化时调用此方法
        /// </summary>
        /// <param name="message">更新的消息内容</param>
        void Update(string message);
    }

    /// <summary>
    /// 主题接口
    /// 观察者模式的主题角色
    /// 定义管理观察者和通知观察者的接口
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 注册观察者方法
        /// 将观察者添加到订阅列表中
        /// </summary>
        /// <param name="observer">要注册的观察者对象</param>
        void Attach(IObserver observer);

        /// <summary>
        /// 取消注册观察者方法
        /// 将观察者从订阅列表中移除
        /// </summary>
        /// <param name="observer">要取消注册的观察者对象</param>
        void Detach(IObserver observer);

        /// <summary>
        /// 通知所有观察者方法
        /// 当主题状态变化时调用此方法通知所有注册的观察者
        /// </summary>
        void Notify();
    }

    /// <summary>
    /// 形状主题类
    /// 观察者模式的具体主题角色
    /// 管理形状状态变化并通知观察者
    /// </summary>
    public class ShapeSubject : ISubject
    {
        /// <summary>
        /// 观察者列表
        /// 存储所有已注册的观察者对象
        /// </summary>
        private List<IObserver> _observers = new List<IObserver>();

        /// <summary>
        /// 主题状态
        /// 当此状态变化时，会通知所有观察者
        /// </summary>
        private string _state;

        /// <summary>
        /// 主题状态属性
        /// 设置状态时自动通知所有观察者
        /// </summary>
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify();
            }
        }

        /// <summary>
        /// 注册观察者方法
        /// 将观察者添加到订阅列表中
        /// </summary>
        /// <param name="observer">要注册的观察者对象</param>
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// 取消注册观察者方法
        /// 将观察者从订阅列表中移除
        /// </summary>
        /// <param name="observer">要取消注册的观察者对象</param>
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// 通知所有观察者方法
        /// 遍历观察者列表，逐个调用 Update 方法
        /// </summary>
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }

    /// <summary>
    /// 形状显示类
    /// 观察者模式的具体观察者角色
    /// 用于显示形状状态变化的通知
    /// </summary>
    public class ShapeDisplay : IObserver
    {
        /// <summary>
        /// 显示对象的名称
        /// 用于标识不同的观察者
        /// </summary>
        private string _name;

        /// <summary>
        /// 形状显示构造函数
        /// </summary>
        /// <param name="name">显示对象的名称</param>
        public ShapeDisplay(string name)
        {
            _name = name;
        }

        /// <summary>
        /// 更新通知方法
        /// 接收并显示主题状态变化的通知
        /// </summary>
        /// <param name="message">更新的消息内容</param>
        public void Update(string message)
        {
            Console.WriteLine($"{_name} 收到通知：{message}");
        }
    }
}
