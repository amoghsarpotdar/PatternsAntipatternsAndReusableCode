using System;
using Interpreter.AbstractAndBaseImplementation;

namespace Interpreter.Concrete
{
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }
}
