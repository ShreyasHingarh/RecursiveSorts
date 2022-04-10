using System;

namespace RecursiveSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort<int> sort = new MergeSort<int>();
            int[] nums = new int[]{ 10, 19, 8, 7, 6, 4, 9, 13, 16, 1 };
            sort.Sort(nums);
            for(int i = 0;i < nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
