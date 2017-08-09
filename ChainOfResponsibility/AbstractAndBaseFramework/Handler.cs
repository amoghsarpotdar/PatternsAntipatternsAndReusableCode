namespace ChainOfResponsibility.AbstractAndBaseFramework
{
    abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successorhandler)
        {
            Successor = successorhandler;
        }

        public abstract void HandleRequest(int request);
    }
}
