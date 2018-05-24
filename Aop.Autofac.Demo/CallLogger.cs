using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using System.IO;
using log4net;
using System.Reflection;

namespace Aop.Autofac.Demo
{
    public class CallLogger : IInterceptor
    {
        TextWriter _output;
        ILog log = LogManager.GetLogger("testApp.Logging");
        
        public CallLogger(TextWriter output)
        {
            _output = output;
        }
        /// <summary>
        /// 拦截方法
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {
            _output.WriteLine($"你正在调用方法{invocation.Method.Name},参数是{string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString())).ToArray()}...");

            //在被拦截的方法执行完毕后 继续执行
            try
            {
                invocation.Proceed();
            }
            catch(Exception ex)
            {
                log.Error(ex.ToString());
            }

            _output.WriteLine("方法执行完毕，返回结果：{0}", invocation.ReturnValue);

        }
    }
}
