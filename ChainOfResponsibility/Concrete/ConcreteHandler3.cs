using System;
using ChainOfResponsibility.AbstractAndBaseFramework;

namespace ChainOfResponsibility.Concrete
{
    class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if(Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
