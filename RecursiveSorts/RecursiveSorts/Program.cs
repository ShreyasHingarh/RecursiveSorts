using System;

namespace RecursiveSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            LomutoQuickSort<int> sort = new LomutoQuickSort<int>();
            int[] nums = new int[]{ 10, 19, 8, 7, 6, 4, 9, 13, 16, 1 };
            sort.SortQuickly(nums,0, nums.Length);
            for(int i = 0;i < nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
