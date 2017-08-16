using Visitor.AbstractAndBaseFramework;

namespace Visitor.Concrete
{
    class ConcreteElementA : Element
    {
        public override void Accept(AbstractAndBaseFramework.Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
            
        }
    }
}
