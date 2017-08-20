using System;

namespace SortingAlgos
{
    class Program
    {
        static void Main()
        {
            CArray nums = new CArray(12);
            Random rnd = new Random(11);

            for (int i = 0; i <= 10; i++)
            {
                nums.Insert((int)(rnd.NextDouble()*100));
            }
            Console.WriteLine("Beffore sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During sorting: ");
            nums.BubbleSort();
            Console.WriteLine("After sorting: ");
            nums.DisplayElements();
            Console.ReadKey();
        }
    }
}
