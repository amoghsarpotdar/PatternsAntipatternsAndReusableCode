namespace Bridge.AbstractAndBaseImplementation
{
    class Abstraction
    {
        protected Implementor OperationImplementor;

        public Implementor TheImplementor
        {
            set { OperationImplementor = value; }
        }

        public virtual void Operation()
        {
            OperationImplementor.Operation();
        }
    }
}
