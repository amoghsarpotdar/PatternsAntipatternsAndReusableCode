using System;

namespace SortingAlgos
{
    class CArray
    {
        private int[] arr;
        private int upper;
        private int _numElements;

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            _numElements = 0;
        }

        public void Insert(int item)
        {
            arr[_numElements] = item;
            _numElements++;
        }

        public void DisplayElements()
        {
            Console.WriteLine("--------");
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("--------");
        }

        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            _numElements = 0;
        }
        
        public void BubbleSort()
        {
            int temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                DisplayElements();
            }
        }
    }
}
