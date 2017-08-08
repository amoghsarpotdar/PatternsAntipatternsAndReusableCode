namespace Singleton.AbstractAndBaseFramework
{
    class Singleton
    {
        private static Singleton _singletonInstance;

        protected Singleton()
        {
            
        }

        public static Singleton Instance()
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = new Singleton();
            }
            return _singletonInstance;
        }
    }
}
