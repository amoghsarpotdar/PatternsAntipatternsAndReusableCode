namespace Mixin
{
    class MixinClient
    {
        public MixinClient(ITargetInterface target)
        {
            _target = target;
        }

        public void Run()
        {
            _target.DoSomeWork();
            _target.FirstExtensionMethod();
            _target.SecondExtensionMethod();
        }
        
        private readonly ITargetInterface _target;
    }
}
