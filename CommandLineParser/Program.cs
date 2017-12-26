using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var arguments = (from argument in args
                select new Argument(argument)).ToArray();
            Console.WriteLine("Command line: ");
            foreach (Argument a in arguments)
            {
                Console.WriteLine($"{a.Original}");
            }
            Console.WriteLine("");

            ArgumentSemanticAnalyzer analyzer = new ArgumentSemanticAnalyzer();
            analyzer.AddArgumentVerifier(
                new ArgumentDefinition("output", "/output:[path to output]", 
                "Specifies the location of the output file.", 
                x=>x.IsCompoundSwitch));
            analyzer.AddArgumentVerifier(
                new ArgumentDefinition("trialMode", "/trialmode",
                    "If this is specified, it puts product in trial mode", 
                    x => x.IsSimpleSwitch));
            analyzer.AddArgumentVerifier(
                new ArgumentDefinition("DEBUGOUTPUT", "/debugoutput:[value1];[value2];[value3]",
                "A listing of files the debug output information will be written to", 
                x=>x.IsComplexSwitch));
            analyzer.AddArgumentVerifier(
                new ArgumentDefinition("","[literal value",
                "A literal value",
                x=>x.IsSimple));

            if (!analyzer.VerifyArguments(arguments))
            {
                string invalidArguments = analyzer.InvalidArgumentDisplay();
                Console.WriteLine(invalidArguments);
                ShowUsage(analyzer);
                return;
            }

            //Set up holders for command line parsing results
            // ReSharper disable once NotAccessedVariable
            string output = string.Empty;
#pragma warning disable 219
            bool trialmode;
#pragma warning restore 219
            IEnumerable<string> debugOutput = null;
            // ReSharper disable once CollectionNeverQueried.Local
            List<string> literals = new List<string>();

            //For each parsed argument, we want to apply an action,
            //so add them to analyzer.
            analyzer.AddArgumentAction("OUTPUT",x=> { output = x.SubArguments[0]; });
            analyzer.AddArgumentAction("ACTION", x=> { trialmode = true; });
            analyzer.AddArgumentAction("DEBUGOUTPUT", x=> { debugOutput = x.SubArguments; });
            analyzer.AddArgumentAction("", x=> {literals.Add(x.Original);});

            //Check the arguments and run the actions
            analyzer.EvaluateArguments(arguments);

            //Display the results
            Console.WriteLine("");
            Console.WriteLine("TRIALMODE: {trialmode}");
            if(debugOutput != null)
            {
                foreach (string item in debugOutput)
                {
                    Console.WriteLine($"DEBUGOUTPUT : {item}");
                }
            }
        }

        public static void ShowUsage(ArgumentSemanticAnalyzer analyzer)
        {
            Console.WriteLine("Program.exe allows the following arguments:");
            foreach (ArgumentDefinition definition in analyzer.ArgumentDefinitions)
            {
                Console.WriteLine($"\t{definition.ArgumentSwitch}:(" +
                                  $"{definition.Description}){Environment.NewLine} " +
                                  $"\tSyntax: {definition.Syntax}");
            }
        }
    }
}
