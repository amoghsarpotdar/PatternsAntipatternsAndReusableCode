using System;
using Strategy.AbstractAndBaseFramework;
using Strategy.Concrete;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}
