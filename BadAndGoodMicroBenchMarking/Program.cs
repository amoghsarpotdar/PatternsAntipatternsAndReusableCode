using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BadAndGoodMicroBenchMarking.TestTarget;

namespace BadAndGoodMicroBenchMarking
{
    class Program
    {
        static void Main(string[] args)
        {
            //First approach:
            //A rudimentary benchmarking test might go like this.
            Console.WriteLine("Benchmarking with approach 1");
            Object obj = new LogicContainer();
            Stopwatch sw = Stopwatch.StartNew();
            for (int tempCount = 0; tempCount < 500; tempCount++)
            {
                ExecLogic1(obj);
            }
            Console.WriteLine(sw.ElapsedTicks);
            sw = Stopwatch.StartNew();
            for(int tempCount=0; tempCount<500; tempCount++)
            {
                ExecLogic2(obj);
            }
            Console.WriteLine(sw.ElapsedTicks);
            /*
             * The one above is not a convincing benchmarking test. Results of test may be consistent
             * however approach is not correct....
             * 1. 500 loops are insufficient to reach to construtive conclusion.
             * 2. The 'background magic' of compiler has not been taken into consideration.
             * 3. Instead of measuring cost of 'is' or 'as' operator in isolation, code is 
             * calling methods which convolutes test results.
            */

            //Second approach:
            Console.WriteLine("Benchmarking with approach 2");
            const int OUTER_ITERATIONS = 10;
            const int INNER_ITERATIONS = 100000000;
            Object obj2 = new LogicContainer2();
            //Outer loop is repeated many times to ensure we get reliable results
            for (int nTemp1 = 0; nTemp1 < OUTER_ITERATIONS; nTemp1++)
            {
                Stopwatch sw2 = Stopwatch.StartNew();
                for (int nTemp2 = 0; nTemp2 < INNER_ITERATIONS; nTemp2++)
                {
                    LogicContainer2 container2 = obj2 as LogicContainer2;
                    if(container2 != null)
                        container2.ExecuteLogic();
                }
                Console.WriteLine("As - {0}ms", sw2.ElapsedMilliseconds);
            }
            for (int nTemp3 = 0; nTemp3 < OUTER_ITERATIONS; nTemp3++)
            {
                Stopwatch sw3 = Stopwatch.StartNew();
                for (int nTemp4 = 0; nTemp4 < INNER_ITERATIONS; nTemp4++)
                {
                    if (obj2 is LogicContainer2)
                    {
                        LogicContainer2 lc2 = obj2 as LogicContainer2;
                        lc2.ExecuteLogic();
                    }
                }
                Console.WriteLine("Is Then As - {0}ms", sw3.ElapsedMilliseconds);
            }
            Console.ReadKey();
            /*
             * If you remove the comments around 'virtual' keyword in LogicContainer and LogicContainer2
             * class definitions, you will observe that performance readings have change drastically.
             * With virtual keyword present, there is no need of explicitly checking for a NULL reference
             * on either of these objects, compiler is smart enough to understand that if execution
             * has reached to a function call it is through a correctly typed object instance.
             * After adding the virtual keyword to the methods, compiler generates exactly same
             * code for both loops.
             */
        }

        static void ExecLogic1(Object obj)
        {
            LogicContainer c1 = obj as LogicContainer;
            if (c1 != null)
                c1.ExecuteLogic();
        }

        static void ExecLogic2(Object obj)
        {
            if (obj is LogicContainer)
            {
                LogicContainer lc = obj as LogicContainer;
                lc.ExecuteLogic();
            }
        }
    }
}
