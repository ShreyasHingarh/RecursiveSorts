using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveSorts
{
    class LomutoQuickSort <T> where T : IComparable<T>
    {
        //Sort, just takes in array -> void
        //Sort, takes in array, left, right -> void
        //Partition, array, left, right -> int

   
        
        public void Sort(T[] nums)
        {
            Sort(nums, 0, nums.Length -1);
        }
        private void Sort(T[] nums,int startIndex, int stopIndex)
        {
            if (nums.Length <= 1 || startIndex >= stopIndex)
            {
                return;
            }
            int Wall = GetWall(nums, startIndex, stopIndex);
            Sort(nums, startIndex, Wall - 1 );
            Sort(nums, Wall + 1, stopIndex);
        }
        static int GetWall(T[] nums, int startIndex, int stopIndex)
        {
            int wall = startIndex;
         
            T pivot = nums[stopIndex];

            T temp;
            for (int i = startIndex; i < stopIndex; i++)
            {

                if (nums[i].CompareTo(pivot) <= 0 && i != 0)
                {
                    temp = nums[wall];
                    nums[wall] = nums[i];
                    nums[i] = temp;
                    wall++;
                }
            }

            nums[stopIndex] = nums[wall];
            nums[wall] = pivot;
            ;
            return wall;
        }


        //T pivot;
        //int wall;
        //public void SortQuickly(T[] nums, int startindex,int stopindex)
        //{
        //    wall = startindex;

        //    if (nums.Length <= 1 || startindex >= stopindex)
        //    {
        //        return;
        //    }
        //    pivot = nums[stopindex];
            
        //    T temp;
        //    for (int i = startindex ;i < stopindex;i++)
        //    {
                
        //        if (nums[i].CompareTo(pivot) <= 0 && i != 0 )
        //        {
        //            temp = nums[wall];
        //            nums[wall] = nums[i];
        //            nums[i] = temp;
        //            wall++;
        //        }
        //    }
            
        //    nums[stopindex] = nums[wall];
        //    nums[wall] = pivot;
        //    SortQuickly(nums, startindex, wall - 1);
        //    SortQuickly(nums, wall + 1, stopindex);

        //}
    }
}
