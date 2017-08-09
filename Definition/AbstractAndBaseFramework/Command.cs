namespace Definition.AbstractAndBaseFramework
{
    abstract class Command
    {
        protected Receiver Receiver;

        public Command(Receiver receiverParam)
        {
            Receiver = receiverParam;
        }

        public abstract void Execute();
    }
}
