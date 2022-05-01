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
            if (Right <= Left)
            {
                return;
            }
            int splitpoint = GetSplitPoint(nums, Left, Right);
            HoareSort(nums, Left, splitpoint);
            HoareSort(nums, splitpoint + 1, Right);
        }
        private int GetSplitPoint(T[] nums, int Left, int Right)
        {
            int l = Left - 1;
            int r = Right + 1;

            T pivot = nums[Left];
            while (true)
            {
                do
                {
                    l++;
                } while (nums[l].CompareTo(pivot) < 0);
                do
                {
                    r--;
                } while (nums[r].CompareTo(pivot) > 0);

                //Make sure right is still larger than left, if it isn't then return

                if (l >= r) return r;

                T temp = nums[r];
                nums[r] = nums[l];
                nums[l] = temp;
            }
        }
    }
}
