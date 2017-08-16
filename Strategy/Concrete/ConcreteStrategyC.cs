using System;

namespace Strategy.Concrete
{
    class ConcreteStrategyC : AbstractAndBaseFramework.Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface");
        }
    }
}
