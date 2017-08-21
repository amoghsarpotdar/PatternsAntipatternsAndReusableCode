﻿using System;
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

        public void LoopingWithoutLinq()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                Console.WriteLine("Index " + Convert.ToString(i) + " Value " + Convert.ToString(_numbers[i]));
            }
        }

        /// <summary>
        /// This function replaces code above in LoopingWithoutLinq function to reduce the looping
        /// construct to fewer lines. 
        /// </summary>
        public void LoopingWithLinq()
        {
            foreach(var n in _numbers)
                Console.WriteLine("Value " + Convert.ToString(n));
        }

        public void ConditionalLoopingWithLinq()
        {
            var selectedNumbers = Enumerable.Range(0,_numbers.Length).Where(n=>n > 300).
            ToList();
            foreach (var selectedNumber in selectedNumbers)
            {
                Console.WriteLine("Value > 490 " + Convert.ToString(selectedNumber));
            }
        }

        public void ConditionalFilteringWithLinq()
        {
            bool isAny = _numbers.Any(n => n >= 300);
            Console.WriteLine("Are any of the variables beyond 300? Answer is : " + Convert.ToString(isAny));
        }
    }
}
