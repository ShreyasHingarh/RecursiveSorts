using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveSorts
{
    class LomutoQuickSort <T> where T : IComparable<T>
    {
        T pivot;
        int wall = -1;

        public void SortQuickly(T[] nums, int startindex,int stopindex)
        {
            wall = startindex - 1;
            
            if (nums.Length <= 1 || startindex == stopindex)
            {
                return;
            }
            pivot = nums[stopindex ];
            T temp;
            for (int i = startindex ;i < stopindex-1;i++)
            {
                
                if (nums[i].CompareTo(pivot) <= 0 && i != 0 )
                {
                    wall++;
                    temp = nums[wall];
                   
                    nums[wall] = nums[i];
                    nums[i] = temp;
                    
                }
            }
            temp = nums[wall + 1];
            nums[wall + 1] = pivot;
            nums[stopindex ] = temp;
            SortQuickly(nums, startindex , wall );
            SortQuickly(nums, wall + 1, stopindex );
        }
    }
}
