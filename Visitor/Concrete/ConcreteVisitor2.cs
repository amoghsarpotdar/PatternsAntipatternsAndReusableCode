using System;

namespace Visitor.Concrete
{
    class ConcreteVisitor2 : AbstractAndBaseFramework.Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1} ", concreteElementA.GetType().Name, GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1} ", concreteElementB.GetType().Name, GetType().Name);
        }
    }
}
