using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Components
{
    /// <summary>
    /// 喝的饮料接口
    /// 抽象组件（Component）：需要装饰的抽象对象
    /// </summary>
    public interface IDrink
    {
        float cost();
        string Description { get;  }
    }
}
