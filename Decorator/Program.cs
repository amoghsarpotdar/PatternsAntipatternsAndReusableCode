using System;
using Decorator.Concrete;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            ConcreteComponent cmp = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(cmp);
            d2.SetComponent(cmp);

            d1.Operation();
            d2.Operation();

            Console.ReadKey();
        }
    }
}
