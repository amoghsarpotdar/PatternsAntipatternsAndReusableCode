using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLineParser
{
    public sealed class ArgumentDefinition
    {
        public string ArgumentSwitch { get; }
        public string Syntax { get; }
        public string Description { get; }
        public Func<Argument,bool> Verifer { get; }

        public ArgumentDefinition(string argumentSwitch,
            string syntax, string description, Func<Argument, bool> verifier)
        {
            ArgumentSwitch = argumentSwitch.ToUpper();
            Syntax = syntax;
            Description = description;
            Verifer = verifier;
        }

        public bool Verify(Argument arg) => Verifer(arg);
    }
}
