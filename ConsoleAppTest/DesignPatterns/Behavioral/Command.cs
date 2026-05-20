using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class ShapeInvoker
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commands.Add(command);
        }

        public void UndoLastCommand()
        {
            if (_commands.Count > 0)
            {
                var command = _commands[_commands.Count - 1];
                command.Undo();
                _commands.RemoveAt(_commands.Count - 1);
            }
        }
    }

    public class DrawShapeCommand : ICommand
    {
        private Shape _shape;

        public DrawShapeCommand(Shape shape)
        {
            _shape = shape;
        }

        public void Execute()
        {
            Console.WriteLine("执行绘制命令");
            _shape.Draw();
        }

        public void Undo()
        {
            Console.WriteLine("撤销绘制命令");
        }
    }
}
