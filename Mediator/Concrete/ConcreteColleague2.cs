using System;
using Mediator.AbstractAndBaseImplementation;

namespace Mediator.Concrete
{
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(AbstractAndBaseImplementation.Mediator mediator) : base(mediator)
        {
            
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("ConcreteColleague2 gets message: " + message);
        }
    }
}
