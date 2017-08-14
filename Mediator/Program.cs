using System;
using Mediator.Concrete;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague2 = colleague2;
            mediator.Colleague1 = colleague1;
            colleague1.Send("How are you?");
            colleague2.Send("Fine, thanks!!");

            Console.ReadKey();
        }
    }
}
