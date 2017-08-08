using AbstractFactory.AbstractAndBaseFramework;

namespace AbstractFactory.Factories
{
    class ConcreteFactory1 : Factories.AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
