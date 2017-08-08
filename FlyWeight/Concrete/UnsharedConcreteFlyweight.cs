using System;
using FlyWeight.AbstractAndBaseFramework;

namespace FlyWeight.Concrete
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
        }
    }
}
