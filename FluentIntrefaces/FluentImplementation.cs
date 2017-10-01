using System;

namespace FluentIntrefaces
{
    class FluentImplementation : IFluentInterface
    {
        public IFluentInterface DoSomething()
        {
            Console.WriteLine("FluentImplementation::DoSomething called.....");
            return this;
        }

        public IFluentInterface DoSomethingElse()
        {
            Console.WriteLine("FluentImplementation::DoSomethingElse called....");
            return this;
        }

        public void ThisMethodIsNotFluent()
        {
            Console.WriteLine("FluentImplementation::ThisMethodIsNotFluent called....");
        }
    }
}
