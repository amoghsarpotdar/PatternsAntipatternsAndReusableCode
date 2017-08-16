namespace Strategy.AbstractAndBaseFramework
{
    class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
