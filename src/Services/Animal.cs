using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public abstract class Animal
    {
        protected string typeName;
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal()
        {
            SetTypeName();
        }

        public Animal(string name, int age):this()
        {
            Name = name;
            Age = age;
        }

        protected virtual void SetTypeName()
        {
            this.typeName = this.GetType().Name;
        }
        /// <summary>
        /// 获取叫声
        /// </summary>
        /// <returns></returns>
        public abstract string GetBark();        
        public virtual void Shout()
        {
            Console.WriteLine($"我叫{Name}，{Age}岁，是{typeName}。。{GetBark()}~");
        }
    }
}
