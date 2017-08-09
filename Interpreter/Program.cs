using System;
using System.Collections;
using Interpreter.AbstractAndBaseImplementation;
using Interpreter.Concrete;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            Context context = new Context();
            ArrayList list = new ArrayList();

            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadKey();
        }
    }
}
