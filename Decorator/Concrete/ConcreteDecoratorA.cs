using System;

namespace Decorator.Concrete
{
    class ConcreteDecoratorA : AbstractAndBaseFramework.Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
