using System;

namespace Strategy.Concrete
{
    class ConcreteStrategyA : AbstractAndBaseFramework.Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
