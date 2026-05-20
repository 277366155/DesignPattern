using ConsoleAppTest.DesignPatterns;
using ConsoleAppTest.DesignPatterns.Behavioral;
using ConsoleAppTest.DesignPatterns.Creational;
using ConsoleAppTest.DesignPatterns.Structural;
using Services;
using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 设计模式演示项目 ===\n");

            Console.WriteLine("--- 1. 策略模式 ---");
            StrategyTest();

            Console.WriteLine("\n--- 2. 创建型模式 ---");
            TestCreationalPatterns();

            Console.WriteLine("\n--- 3. 结构型模式 ---");
            TestStructuralPatterns();

            Console.WriteLine("\n--- 4. 行为型模式 ---");
            TestBehavioralPatterns();

            Console.WriteLine("\n=== 所有设计模式演示完成 ===");
            Console.ReadLine();
        }

        /// <summary>
        /// 策略模式调用
        /// </summary>
        static void StrategyTest()
        {
            var animalStrategy = new Strategy("旺财", 3, Services.AnimalEnum.Dog);
            animalStrategy.AnimalShout();
        }

        /// <summary>
        /// 测试创建型模式
        /// </summary>
        static void TestCreationalPatterns()
        {
            Console.WriteLine("2.1 单例模式：");
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            singleton1.DoSomething();
            Console.WriteLine($"两个实例是否相同：{singleton1 == singleton2}");

            Console.WriteLine("\n2.2 工厂方法模式：");
            ShapeFactory circleFactory = new CircleFactory(5);
            var circle = circleFactory.CreateShape();
            circle.Draw();

            Console.WriteLine("\n2.3 抽象工厂模式：");
            AbstractFactory redCircleFactory = new RedCircleFactory(5);
            var shape = redCircleFactory.CreateShape();
            var color = redCircleFactory.CreateColor();
            shape.Draw();
            color.Fill();

            Console.WriteLine("\n2.4 建造者模式：");
            var builder = new RedCircleBuilder(5);
            var director = new ShapeDirector(builder);
            director.Construct();
            var coloredShape = builder.GetColoredShape();
            coloredShape.Show();

            Console.WriteLine("\n2.5 原型模式：");
            var originalCircle = new PrototypeCircle(5);
            var clonedCircle = originalCircle.Clone();
            originalCircle.Draw();
            clonedCircle.Draw();
        }

        /// <summary>
        /// 测试结构型模式
        /// </summary>
        static void TestStructuralPatterns()
        {
            Console.WriteLine("3.1 适配器模式：");
            var shape = new Circle(5);
            IGeometricShape adapter = new ShapeAdapter(shape);
            adapter.DisplayInfo();

            Console.WriteLine("\n3.2 桥接模式：");
            IColorImplementor redImplementor = new RedImplementor();
            ShapeAbstraction circleAbs = new CircleAbstraction(5, redImplementor);
            circleAbs.Draw();

            Console.WriteLine("\n3.3 组合模式：");
            var composite = new CompositeGraphic("主图形");
            var leaf1 = new LeafGraphic("圆形");
            var leaf2 = new LeafGraphic("矩形");
            composite.Add(leaf1);
            composite.Add(leaf2);
            composite.Draw();

            Console.WriteLine("\n3.4 装饰器模式：");
            var circleToDecorate = new Circle(5);
            var borderDecorator = new BorderShapeDecorator(circleToDecorate);
            var shadowDecorator = new ShadowShapeDecorator(borderDecorator);
            shadowDecorator.Draw();

            Console.WriteLine("\n3.5 外观模式：");
            var facade = new ShapeFacade();
            facade.ProcessColoredShape(new Circle(5), new Red());

            Console.WriteLine("\n3.6 享元模式：");
            var flyweightFactory = new ShapeFlyweightFactory();
            var flyweight1 = flyweightFactory.GetCircleFlyweight("红色", 5);
            var flyweight2 = flyweightFactory.GetCircleFlyweight("红色", 5);
            var flyweight3 = flyweightFactory.GetCircleFlyweight("蓝色", 5);
            flyweight1.Display(10, 20);
            flyweight2.Display(30, 40);
            flyweight3.Display(50, 60);
            Console.WriteLine($"享元对象数量：{flyweightFactory.GetFlyweightCount()}");

            Console.WriteLine("\n3.7 代理模式：");
            var proxyWithPermission = new ShapeServiceProxy(true);
            proxyWithPermission.DrawShape(new Circle(5));
            var proxyWithoutPermission = new ShapeServiceProxy(false);
            proxyWithoutPermission.DrawShape(new Circle(5));
        }

        /// <summary>
        /// 测试行为型模式
        /// </summary>
        static void TestBehavioralPatterns()
        {
            Console.WriteLine("4.1 模板方法模式：");
            ShapeProcessor circleProcessor = new CircleProcessor();
            circleProcessor.Process();

            Console.WriteLine("\n4.2 观察者模式：");
            var subject = new ShapeSubject();
            var display1 = new ShapeDisplay("显示器1");
            var display2 = new ShapeDisplay("显示器2");
            subject.Attach(display1);
            subject.Attach(display2);
            subject.State = "形状已更新";

            Console.WriteLine("\n4.3 迭代器模式：");
            var aggregate = new ShapeAggregate();
            aggregate.Add(new Circle(5));
            aggregate.Add(new Rectangle(4, 6));
            var iterator = aggregate.CreateIterator();
            while (iterator.HasNext())
            {
                var item = iterator.Next();
                item.Draw();
            }

            Console.WriteLine("\n4.4 责任链模式：");
            var circleHandler = new CircleHandler();
            var rectangleHandler = new RectangleHandler();
            var triangleHandler = new TriangleHandler();
            circleHandler.SetNext(rectangleHandler);
            rectangleHandler.SetNext(triangleHandler);
            circleHandler.HandleRequest("Rectangle");

            Console.WriteLine("\n4.5 命令模式：");
            var invoker = new ShapeInvoker();
            var command = new DrawShapeCommand(new Circle(5));
            invoker.ExecuteCommand(command);
            invoker.UndoLastCommand();

            Console.WriteLine("\n4.6 备忘录模式：");
            var originator = new ShapeOriginator();
            var caretaker = new ShapeCaretaker();
            originator.State = "状态1";
            caretaker.AddMemento(originator.CreateMemento());
            originator.State = "状态2";
            caretaker.AddMemento(originator.CreateMemento());
            originator.State = "状态3";
            Console.WriteLine($"当前状态：{originator.State}");
            originator.RestoreFromMemento(caretaker.GetMemento(0));
            Console.WriteLine($"恢复到状态：{originator.State}");

            Console.WriteLine("\n4.7 状态模式：");
            var context = new ShapeContext(new DraftState());
            context.Request();
            context.Request();
            context.Request();

            Console.WriteLine("\n4.8 访问者模式：");
            var visitorCircle = new VisitorCircle(5);
            var visitorRectangle = new VisitorRectangle(4, 6);
            var areaVisitor = new AreaCalculatorVisitor();
            var perimeterVisitor = new PerimeterCalculatorVisitor();
            visitorCircle.Accept(areaVisitor);
            visitorRectangle.Accept(perimeterVisitor);

            Console.WriteLine("\n4.9 中介者模式：");
            var mediator = new ShapeMediator();
            var circleColleague = new CircleColleague(mediator);
            var rectangleColleague = new RectangleColleague(mediator);
            mediator.Circle = circleColleague;
            mediator.Rectangle = rectangleColleague;
            circleColleague.Send("你好，矩形！");
            rectangleColleague.Send("你好，圆形！");

            Console.WriteLine("\n4.10 解释器模式：");
            var parser = new ExpressionParser();
            var parsedShape = parser.Parse("Create a Circle");
            parsedShape?.Draw();
        }
    }
}
