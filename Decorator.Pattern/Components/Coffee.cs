using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Components
{
    /// <summary>
    /// 咖啡
    /// 具体组件（ConcreteComponent）：是我们需要装饰的对象
    /// </summary>
    public class Coffee : IDrink
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get { return "coffe"; }
        }
        /// <summary>
        /// 价格
        /// </summary>
        /// <returns></returns>
        public float cost()
        {
            return 10;
        }
    }
}
