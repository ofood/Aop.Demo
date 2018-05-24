using Decorator.Pattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Decorators
{
    public class Milk:CondimentDecorator
    {
        public Milk(IDrink drink):base(drink)
        {

        }
        public override float cost()
        {
            return base.cost() + 2;
        }
        public override string Description
        {
            get { return base.Description + ",milk"; }
        }
    }
}
