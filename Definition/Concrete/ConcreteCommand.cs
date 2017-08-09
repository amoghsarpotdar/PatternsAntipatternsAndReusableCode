using System;
using Definition.AbstractAndBaseFramework;

namespace Definition.Concrete
{
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver ReceiverParam) : base(ReceiverParam)
        {
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }
}
