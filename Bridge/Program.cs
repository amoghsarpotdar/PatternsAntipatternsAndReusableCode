using System;
using Bridge.AbstractAndBaseImplementation;
using Bridge.Concrete;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            ab.TheImplementor = new ConcreteImplementorA();
            ab.Operation();

            ab.TheImplementor = new ConcreteImplementorB();
            ab.Operation();

            Console.ReadKey();
        }
    }
}
