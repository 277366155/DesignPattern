using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns
{
    /// <summary>
    /// 策略模式
    /// </summary>
    public class Strategy
    {
        Animal _animail;
        /// <summary>
        /// 策略模式实现
        /// </summary>
        /// <param name="animal"></param>
        public Strategy(Animal animal)
        {
            this._animail = animal;
        }

        /// <summary>
        /// 策略模式+工厂模式实现
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="animal"></param>
        public Strategy(string name,int age,AnimalEnum animal)
        {
            switch (animal)
            {
                case AnimalEnum.Cat:
                    _animail = new Cat(name,age);
                    break;
                case AnimalEnum.Dog:
                    _animail = new Dog(name,age);
                    break;
            }
        }

        public void AnimalShout()
        {
            //TODO:其他业务处理
            _animail.Shout();
        }
    }
}
