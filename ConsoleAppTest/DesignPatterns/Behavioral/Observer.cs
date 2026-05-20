using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public interface IObserver
    {
        void Update(string message);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class ShapeSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }

    public class ShapeDisplay : IObserver
    {
        private string _name;

        public ShapeDisplay(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} 收到通知：{message}");
        }
    }
}
