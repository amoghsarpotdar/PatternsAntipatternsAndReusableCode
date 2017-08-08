using FactoryMethod.AbstractAndBaseFramework;

namespace FactoryMethod.Factories
{
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
