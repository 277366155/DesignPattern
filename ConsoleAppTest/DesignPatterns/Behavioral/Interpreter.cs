using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Behavioral
{
    public interface IExpression
    {
        void Interpret(Context context);
    }

    public class Context
    {
        public string Input { get; set; }
        public Shape Output { get; set; }
    }

    public class CircleExpression : IExpression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Contains("Circle"))
            {
                context.Output = new Circle(5);
                Console.WriteLine("解释器创建了一个圆形");
            }
        }
    }

    public class RectangleExpression : IExpression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Contains("Rectangle"))
            {
                context.Output = new Rectangle(4, 6);
                Console.WriteLine("解释器创建了一个矩形");
            }
        }
    }

    public class ExpressionParser
    {
        private List<IExpression> _expressions = new List<IExpression>();

        public ExpressionParser()
        {
            _expressions.Add(new CircleExpression());
            _expressions.Add(new RectangleExpression());
        }

        public Shape Parse(string input)
        {
            Context context = new Context { Input = input };
            foreach (var expression in _expressions)
            {
                expression.Interpret(context);
                if (context.Output != null)
                {
                    return context.Output;
                }
            }
            return null;
        }
    }
}
