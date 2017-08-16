using State.AbstractAndBaseFramework;

namespace State.Concrete
{
    class ConcreteStateA : AbstractAndBaseFramework.State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
