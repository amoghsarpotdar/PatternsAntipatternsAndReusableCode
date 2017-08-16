using System;

namespace Strategy.Concrete
{
    class ConcreteStrategyB : AbstractAndBaseFramework.Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface");
        }
    }
}
