using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Builder.AbstractAndBaseFramework
{
    abstract class AbstractBuilder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product BuildProduct();
    }
}
