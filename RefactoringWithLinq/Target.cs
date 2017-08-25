﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class Target
    {
        private int[] _numbers;

        public void ResetState()
        {
            _numbers = new int[10];
            Random randomNumbers = new Random(10);
            for (int nTemp = 0; nTemp < 10; nTemp++)
            {
                int tempVal = randomNumbers.Next(500);
                Console.WriteLine("Rnd : " + tempVal);
                _numbers[nTemp] = tempVal;
            }
        }

        #region LoopRefactoring

        public void LoopingWithoutLinq()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                Console.WriteLine("Index " + Convert.ToString(i) + " Value " + Convert.ToString(_numbers[i]));
            }
        }

        /// <summary>
        /// This function replaces code above in LoopingWithoutLinq function to reduce the looping
        /// construct to fewer lines. If you decompile this code and view output in a tool like
        /// ILSpy, the code actually ends up being same as the function above. In fact, with my experiments
        /// using ILSpy version 2.4.0.1985 on .Net 4.0 debug mode output code looks like below.
        /// 
        /// Is link faster than raw loops? No, not currently at least.
        /// Go through these - http://www.schnieds.com/2009/03/linq-vs-foreach-vs-for-loop-performance.html
        /// and https://stackoverflow.com/questions/3156059/is-a-linq-statement-faster-than-a-foreach-loop
        /// The only advantage you get is smaller and manageable code. If you are keen about performance
        /// you may be better off using your own logic rather than depending upon linq's magic.
        /// </summary>
        /*Code output generated by C# compiler under .Net 4.0, inspected through ILSpy
         * public void LoopingWithLinq(){
             int[] numbers = this._numbers;
             for (int j = 0; j < numbers.Length; j++)
             {
                 int i = numbers[j];
                 Console.WriteLine("Value " + Convert.ToString(i));
             }
        }*/
        public void LoopingWithLinq()
        {
            foreach(var n in _numbers)
                Console.WriteLine("Value " + Convert.ToString(n));
        }

        /// <summary>
        /// This function demonstrates conditional looping with linq. Notice similarity between
        /// this function and next (ConditionalFilteringWithLinq) but different linq functions
        /// being used.
        /// </summary>
        public void ConditionalLoopingWithLinq()
        {
            var selectedNumbers = Enumerable.Range(0,_numbers.Length).Where(n=>n > 300).
            ToList();
            foreach (var selectedNumber in selectedNumbers)
            {
                Console.WriteLine("Value > 490 " + Convert.ToString(selectedNumber));
            }
        }

        /// <summary>
        /// This function demonstrates filtering on a collection using linq.
        /// Same implementation with for loop requires more lines of code.
        /// </summary>
        public void ConditionalFilteringWithLinq()
        {
            bool isAny = _numbers.Any(n => n >= 300);
            Console.WriteLine("Are any of the variables beyond 300? Answer is : " + Convert.ToString(isAny));
        }


        /// <summary>
        /// This function demonstrates evaluation of aggregate result on a collection
        /// without using linq.
        /// </summary>
        public void CheckAggregateConditionWithForLoop()
        {
            bool bResult = true;
            for (int nTemp = 0; nTemp < _numbers.Length; nTemp++)
            {
                if (_numbers[nTemp] < 150)
                {
                    bResult = false;
                }
            }
            Console.WriteLine("Aggregate result is : " + Convert.ToString(bResult));
        }

        /// <summary>
        /// This function demonstrates evaluation of aggregate code with linq.
        /// </summary>
        public void CheckAggregateConditionWithLinq()
        {
            bool bResult = _numbers.All(n => n < 150);
            Console.WriteLine("Aggregate result is : " + Convert.ToString(bResult));
        }


        /// <summary>
        /// This function demonstrates extraction of first four elements using
        /// raw c# code.
        /// </summary>
        public void ExtractNElementsWithForLoop()
        {
            int [] firstFourElements = new int[4];
            for (int i = 0; i < 4; i++)
            {
                firstFourElements[i] = _numbers[i];
            }
            Console.WriteLine("First four elements with C# loop" + firstFourElements);
        }

        /// <summary>
        /// This function demonstrates extraction of first four elements using
        /// LINQ code.
        /// </summary>
        public void ExtractNElementsWithLinq()
        {
            var firstFourElements = _numbers.Take(4).ToArray();
            Console.WriteLine("First four elements with linq code" + firstFourElements);
        }

        /// <summary>
        /// Gets array intersection using c# for loop.
        /// What is an array intersection? Refer to http://www.codinghelmet.com/?path=exercises/array-intersection
        /// </summary>
        public void GetArrayIntersectionWithForLoop()
        {
            string[] names1 = {"Sam", "David", "Sam", "Eric", "Daniel", "Sam"};
            string[] names2 = {"David", "Eric", "Sam"};

            List<string> commonNames = new List<string>();
            for (int i = 0; i < names1.Length; i++)
            {
                if(Array.FindIndex(names2, m=>m==names1[i]) != -1)
                    commonNames.Add(names1[i]);
            }
            Console.WriteLine("Common names count : " + Convert.ToString(commonNames.Count));
        }

        /// <summary>
        /// Gets array intersection with LINQ
        /// </summary>
        public void GetArrayIntersectionWithLinq()
        {
            string[] names1 = { "Sam", "David", "Sam", "Eric", "Daniel", "Sam" };
            string[] names2 = { "David", "Eric", "Sam" };

            var commonNames = names1.Intersect(names2).ToList();
            Console.WriteLine("Common names count : " + Convert.ToString(commonNames.Count));
        }

        /// <summary>
        /// Concatinates strings in for loop.
        /// </summary>
        public void ContentConcatinationWithForLoop()
        {
            string[] prefixList = {"Prefix1", "Prefix2", "Prefix3", "Prefix4", "Prefix5"};
            string[] postfixList = {"Postfix1", "Postfix2", "Postfix3", "Postfix4", "Postfix5"};

            for (int nTemp = 0; nTemp < prefixList.Length; nTemp++)
            {
                var outputText = prefixList[nTemp] + " - " + postfixList[nTemp];
                Console.WriteLine("Concatinated output : " + outputText);
            }
        }

        /// <summary>
        /// Concatinates strings using linq.
        /// </summary>
        public void ContentConcatinationWithLinq()
        {
            string[] prefixList = { "Prefix1", "Prefix2", "Prefix3", "Prefix4", "Prefix5" };
            string[] postfixList = { "Postfix1", "Postfix2", "Postfix3", "Postfix4", "Postfix5" };

            var combinedOutput = prefixList.Zip(postfixList, (prefix, postfix) => prefix + " - " + postfix);
            foreach (var s in combinedOutput)
            {
                Console.WriteLine("Combined output with linq: " + s);
            }
        }
        #endregion
    }
}
