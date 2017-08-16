using Visitor.AbstractAndBaseFramework;

namespace Visitor.Concrete
{
    class ConcreteElementB : Element
    {
        public override void Accept(AbstractAndBaseFramework.Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
            
        }
    }
}
