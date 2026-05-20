using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public class ShapeOriginator
    {
        public string State { get; set; }

        public ShapeMemento CreateMemento()
        {
            return new ShapeMemento(State);
        }

        public void RestoreFromMemento(ShapeMemento memento)
        {
            State = memento.State;
        }
    }

    public class ShapeMemento
    {
        public string State { get; private set; }

        public ShapeMemento(string state)
        {
            State = state;
        }
    }

    public class ShapeCaretaker
    {
        private List<ShapeMemento> _mementos = new List<ShapeMemento>();

        public void AddMemento(ShapeMemento memento)
        {
            _mementos.Add(memento);
        }

        public ShapeMemento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
