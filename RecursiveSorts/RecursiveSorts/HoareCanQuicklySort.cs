using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveSorts
{
    class HoareCanQuicklySort<T> where T : IComparable<T>
    {
        public void HoareSort(T[] nums)
        {
            HoareSort(nums, 0, nums.Length - 1);
        }
        private void HoareSort(T[] nums, int Left, int Right)
        {
            if (nums.Length <= 1 || )
            {
                return;
            }
            int splitpoint = GetSplitPoint(nums, Left, Right);
            HoareSort(nums, Left, splitpoint);
            HoareSort(nums, splitpoint + 1, Right);
        }
        private int GetSplitPoint(T[] nums, int Left, int Right)
        {
            T pivot = nums[0]; 
            while(Right > Left)
            {
                while(nums[Left].CompareTo(pivot) < 0)
                {
                    Left++;
                }
                while(nums[Right].CompareTo(pivot) > 0)
                {
                    Right--;
                }
                T temp = nums[Right];
                nums[Right] = nums[Left];
                nums[Left] = temp;
            }
            return Right;
        }
    }
}
