using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BadAndGoodMicroBenchMarking.TestTarget
{
    class LogicContainer2
    {
        /// <summary>
        /// NoInlining ensures JIT compiler does not inline this method.
        /// This means two subsequent calls from separate objects will involve
        /// exactly same amount of effort in terms of JITing.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public virtual void ExecuteLogic() { }
    }
}
