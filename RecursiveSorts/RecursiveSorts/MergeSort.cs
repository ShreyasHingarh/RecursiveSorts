using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveSorts
{
    class MergeSort<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            if (array.Length < 2)
            {
                return;
            }
            (T[] left, T[] right) = Split(array);
            Sort(left);
            Sort(right);
            Merge(array, left, right);
        }

        public (T[] left, T[] right) Split(T[] array)
        {

            T[] left = new T[array.Length / 2];
            T[] right = new T[array.Length - left.Length];
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = array[i + left.Length];
            }
            return (left, right);
        }

        public void Merge(T[] array, T[] left, T[] right)
        {
            int rightIndex = 0;
            int leftIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(leftIndex >= left.Length)
                {
                    Array.Copy(right, rightIndex, array, i, right.Length - rightIndex);
                    return;
                }
                if(rightIndex >= right.Length)
                {
                    Array.Copy(left, leftIndex, array, i, left.Length - leftIndex);
                    return;
                }

                if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    array[i] = left[leftIndex];
                    leftIndex++;
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) >= 0)
                {
                    array[i] = right[rightIndex];
                    rightIndex++;
                }
            }

        }
    }
}
