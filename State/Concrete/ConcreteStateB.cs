using State.AbstractAndBaseFramework;

namespace State.Concrete
{
    class ConcreteStateB : AbstractAndBaseFramework.State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
