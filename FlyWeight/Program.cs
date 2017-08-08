using System;
using FlyWeight.AbstractAndBaseFramework;
using FlyWeight.Concrete;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;

            FlyWeightFactory factory = new FlyWeightFactory();
            Flyweight fx = factory.GetFlyWeight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyWeight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyWeight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);

            Console.ReadKey();
        }
    }
}
