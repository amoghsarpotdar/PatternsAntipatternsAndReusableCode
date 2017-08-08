using AbstractFactory.AbstractAndBaseFramework;

namespace AbstractFactory
{
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(Factories.AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
