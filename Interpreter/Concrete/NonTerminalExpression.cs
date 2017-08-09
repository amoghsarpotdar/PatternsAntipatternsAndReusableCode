using System;
using Interpreter.AbstractAndBaseImplementation;

namespace Interpreter.Concrete
{
    class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called NonTerminal.Interpret()");
        }
    }
}
