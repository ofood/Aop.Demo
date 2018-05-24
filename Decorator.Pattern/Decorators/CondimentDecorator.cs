using Decorator.Pattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Decorator.Pattern.Decorators
{
    /// <summary>
    /// 抽象装饰类（Decorator）：内含指向抽象组件的引用及装饰者共有的方法
    /// </summary>
    public abstract class CondimentDecorator:IDrink
    {
        private IDrink _drink;
        public CondimentDecorator(IDrink drink)
        {
            this._drink = drink;
        }
        public virtual string Description { get { return _drink.Description; } }
        public virtual float cost()
        {
            return _drink.cost();
        }
    }
}
