using FactoryMethod.AbstractAndBaseFramework;

namespace FactoryMethod.Factories
{
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
