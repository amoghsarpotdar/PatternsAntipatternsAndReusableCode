using AbstractFactory.AbstractAndBaseFramework;

namespace AbstractFactory.Factories
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
