using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Pattern.Components;

namespace Decorator.Pattern.Decorators
{
    public class Sugar : CondimentDecorator
    {
        public Sugar(IDrink drink) : base(drink)
        {
        }
        public override float cost()
        {
            return base.cost()+4;
        }
        public override string Description {
            get { return base.Description + ",Sugar"; }
        }
    }
}
