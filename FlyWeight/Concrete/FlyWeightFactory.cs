using System.Collections;
using FlyWeight.AbstractAndBaseFramework;

namespace FlyWeight.Concrete
{
    class FlyWeightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyWeightFactory()
        {
            flyweights.Add("X",new ConcreteFlyweight());
            flyweights.Add("Y",new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyWeight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }
}
