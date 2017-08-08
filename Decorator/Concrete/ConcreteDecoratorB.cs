using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    class ConcreteDecoratorB:AbstractAndBaseFramework.Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecorator.Operation()");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB::AddedBehavior");
        }
    }
}
