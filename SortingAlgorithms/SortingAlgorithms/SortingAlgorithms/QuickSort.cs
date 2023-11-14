using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort: ScoreSorting, ISortable
    {
        private int[] nums;

        private int Pivot;
        private int pivotIndex;
        public QuickSort() 
        {
            nums = new int[] { 5, 2, 76, 3, 11, 98, 9, 7, 21, 6 };
        }

        /// <summary>
        /// The way Quick Sort works is that it recurisively splits an
        /// unsorted array into sub-arrays, sorting each one.
        /// 
        /// Quick Sort chooses an element to act as a 'pivot' where it 
        /// uses the pivot to seperate elements that are greater/less than the pivot.
        /// It recurisvely does this until the entire array is sorted.
        /// </summary>
        public void Sort()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                pivotIndex = nums[nums.Length - 1];
                Pivot = nums[pivotIndex];
            }
        }
    }
}
