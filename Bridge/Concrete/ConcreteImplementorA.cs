using System;
using Bridge.AbstractAndBaseImplementation;

namespace Bridge.Concrete
{
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
