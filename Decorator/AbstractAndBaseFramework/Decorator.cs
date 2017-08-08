namespace Decorator.AbstractAndBaseFramework
{
    abstract class Decorator : Component
    {
        protected Component TheComponent;

        public void SetComponent(Component comp)
        {
            TheComponent = comp;
        }

        public override void Operation()
        {
            if (TheComponent != null)
            {
                TheComponent.Operation();
            }
        }
    }
}
