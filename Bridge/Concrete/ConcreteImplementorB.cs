using System;
using Bridge.AbstractAndBaseImplementation;

namespace Bridge.Concrete
{
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
