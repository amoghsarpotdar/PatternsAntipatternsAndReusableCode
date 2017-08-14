using System;
using Mediator.AbstractAndBaseImplementation;

namespace Mediator.Concrete
{
    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(AbstractAndBaseImplementation.Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague gets message: " + message);
        }
    }
}
