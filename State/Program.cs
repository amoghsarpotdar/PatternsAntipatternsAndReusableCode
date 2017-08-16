using System;
using State.AbstractAndBaseFramework;
using State.Concrete;

namespace State
{
    class Program
    {
        static void Main()
        {
            Context ctx = new Context(new ConcreteStateA());

            ctx.Request();
            ctx.Request();
            ctx.Request();
            ctx.Request();

            Console.ReadKey();
        }
    }
}
