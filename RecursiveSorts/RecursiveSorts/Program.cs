﻿using System;

namespace RecursiveSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            HoareCanQuicklySort<int> sort = new HoareCanQuicklySort<int>();
            int[] nums = new int[] { 10, 19, 8, 7, 6, 4, 9, 1, 16, 13 }; //new int[]{ 10, 19, 8, 7, 6, 4, 9, 1 , 16, 13 };
            sort.HoareSort(nums);
            for(int i = 0;i < nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
