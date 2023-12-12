using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public static class BinarySearch
    {
        /// <summary>
        /// The Binary search algorithm requires it to have an already sorted
        /// data set. It checks the middle index of the array/sub-array to see
        /// if it is the 'target' value.
        /// 
        /// Initially, we check the middle index of the whole array. If the element
        /// at the middle index is greater than the target, we check the left half 
        /// of the array and find the middle index of that half, and recursively do so
        /// until we have found the target.  - Same for right half if element is initially less than target.
        /// 
        /// Time Complexity
        /// Best Case: O(1)
        /// Worst Case: O(log n)
        /// 
        /// </summary>

        /*Pseudocode
         * function binarySearch(array, Low, Hi, target):
                while left <= right:
                    mid = (left + right) // 2
                    if list[mid] == target:
                        return mid
                    elif list[mid] < target:
                        Low = mid + 1
                    else:
                        Hi = mid - 1
                return -1
         */

        private static int MiddleIndex;
        public static string search(int[] array, int low, int max, int target)
        {
            MiddleIndex= 0;

            //We get the middle of the index
            MiddleIndex = (max+low) / 2;
            Console.WriteLine($"Checking index {MiddleIndex}");

            if (MiddleIndex > array.Length-1)
            {
                //This tells us that the target is not in the array,
                //would throw out of bounds
                return "Could not find target";
            }

            //When the low and max match, we have found target
            if (array[MiddleIndex] == target)
            {
                return $"Target {target} at index {MiddleIndex}";
            }

            if (array[MiddleIndex] < target)
            {
                //Search from the next index to max.
                //Low: Middle + 1
                //Max: same
               return search(array, MiddleIndex+1, max, target);
            }

            if (array[MiddleIndex] > target)
            {
                //Search from low to Middle-1
                //Low: same
                //Max: Middle - 1
               return search(array, low, MiddleIndex-1, target);
            }


            else 
            { 
                return "Could not find target"; 
            }
        }
    }
}
