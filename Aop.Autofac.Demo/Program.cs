using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy;
namespace Aop.Autofac.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            ContainerBuilder builder = new ContainerBuilder();
            #region 类代理
            //动态注入拦截器CallLogger,启用代理拦截
            builder.RegisterType<Circle1>().EnableClassInterceptors();
            #endregion

            #region 接口代理
            builder.RegisterType<Circle>().As<IShap>().InterceptedBy(typeof(CallLogger)).EnableInterfaceInterceptors();
            #endregion

            //注入拦截器到容器
            //1. 命名注入
            //builder.Register(c => new CallLogger(Console.Out)).Named<IInterceptor>("log-calls");
            //2. 类型注入
            builder.Register(c => new CallLogger(Console.Out));
            //创建容器
            var container = builder.Build();
            //从容器获取类型
            var circle1=container.Resolve<Circle1>();
            var circle = container.Resolve<IShap>();
            circle.Area();

            circle1.Area();
            Console.ReadKey();
        }
    }
}
