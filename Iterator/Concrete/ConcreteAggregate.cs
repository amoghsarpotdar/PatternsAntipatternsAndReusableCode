using System;
using System.Collections;
using Iterator.AbstractAndBaseFramework;

namespace Iterator.Concrete
{
    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();
        public override AbstractAndBaseFramework.Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
