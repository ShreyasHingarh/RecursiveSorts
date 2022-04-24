using System;

namespace RecursiveSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            LomutoQuickSort<int> sort = new LomutoQuickSort<int>();
            int[] nums = new int[] { 7, 4, 3, 6, 2, 1, 5 }; //new int[]{ 10, 19, 8, 7, 6, 4, 9, 1 , 16, 13 };
            sort.Sort(nums);
            for(int i = 0;i < nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
