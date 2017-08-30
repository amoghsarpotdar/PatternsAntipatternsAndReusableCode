using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadAndGoodMicroBenchMarking.TestTarget
{
    class LogicContainer
    {   
        /// <summary>
        /// This code will be JITed by runtime, i.e. compiled when required. Also,
        /// if subsequent object walks in to make the call on same method but different
        /// instance, 'inlined' version will be referred. This is part of runtime's
        /// optimization process.
        /// </summary>
        public virtual void ExecuteLogic() { }
    }

    
}
