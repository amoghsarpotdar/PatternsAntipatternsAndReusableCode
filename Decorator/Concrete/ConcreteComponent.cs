using System;
using Decorator.AbstractAndBaseFramework;

namespace Decorator.Concrete
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
