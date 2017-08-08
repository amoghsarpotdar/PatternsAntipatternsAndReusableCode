using Bridge.AbstractAndBaseImplementation;

namespace Bridge.Concrete
{
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            OperationImplementor.Operation();
        }
    }
}
