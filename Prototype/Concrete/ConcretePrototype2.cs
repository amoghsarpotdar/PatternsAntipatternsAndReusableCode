using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.AbstractAndBaseFramework;

namespace Prototype.Concrete
{
    class ConcretePrototype2 : AbstractAndBaseFramework.Prototype
    {
        public ConcretePrototype2(string id) : base(id)
        {
        }

        public override AbstractAndBaseFramework.Prototype Clone()
        {
            return (AbstractAndBaseFramework.Prototype)this.MemberwiseClone();
        }
    }
}
