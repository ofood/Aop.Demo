using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;
namespace Aop.Autofac.Demo
{
    [Intercept(typeof(CallLogger))]
    public class Circle1
    {
        public virtual void Area()
        {
            int a = 10;
            int b = 3;
            int c = a % b;
            Console.WriteLine($"你正在调用圆求面积的方法类{c}");
        }
    }
}
