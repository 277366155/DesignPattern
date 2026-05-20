using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.DesignPatterns.Structural
{
    public interface IShapeService
    {
        void DrawShape(Shape shape);
    }

    public class RealShapeService : IShapeService
    {
        public void DrawShape(Shape shape)
        {
            Console.WriteLine("真实服务执行绘制操作...");
            shape.Draw();
        }
    }

    public class ShapeServiceProxy : IShapeService
    {
        private RealShapeService _realService;
        private bool _hasPermission;

        public ShapeServiceProxy(bool hasPermission)
        {
            _hasPermission = hasPermission;
        }

        public void DrawShape(Shape shape)
        {
            Console.WriteLine("代理开始工作...");
            if (_hasPermission)
            {
                if (_realService == null)
                {
                    _realService = new RealShapeService();
                }
                Console.WriteLine("权限验证通过");
                _realService.DrawShape(shape);
                Console.WriteLine("代理记录操作日志");
            }
            else
            {
                Console.WriteLine("权限验证失败，拒绝访问");
            }
        }
    }
}
