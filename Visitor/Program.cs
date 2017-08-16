using System;
using Visitor.Concrete;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            ObjectStructure obj = new ObjectStructure();
            obj.Attach(new ConcreteElementA());
            obj.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            obj.Accept(v1);
            obj.Accept(v2);

            Console.ReadKey();
        }
    }
}
