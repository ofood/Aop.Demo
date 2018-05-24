using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aop.Autofac.Demo
{
    
    public class Circle : IShap
    {
        /// <summary>
        /// 重写父类抽象方法
        /// </summary>
        public void Area()
        {
            Console.WriteLine("你正在调用圆求面积的方法");
        }
    }
}
