using Decorator.Pattern.Components;
using Decorator.Pattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrink drink = new Coffee() ;
            //点一杯咖啡
            //Console.WriteLine($"{drink.Description}:{drink.cost()}");
            drink = new Milk(drink);
            //Console.WriteLine($"{drink.Description}:{drink.cost()}");
            drink = new Sugar(drink);
            Console.WriteLine($"{drink.Description}:{drink.cost()}");
            Console.WriteLine("测试git");
            Console.ReadKey();
            
        }
    }
}
