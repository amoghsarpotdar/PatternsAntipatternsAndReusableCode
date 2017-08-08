namespace Prototype.Concrete
{
    class ConcretePrototype1 : AbstractAndBaseFramework.Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {
        }

        public override AbstractAndBaseFramework.Prototype Clone()
        {
            return (AbstractAndBaseFramework.Prototype) this.MemberwiseClone();
        }
    }
}
