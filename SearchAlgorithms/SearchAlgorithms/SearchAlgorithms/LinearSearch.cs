using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public static class LinearSearch
    {
        /// <summary>
        /// 
        /// The algorithm Linear search is fairly simple, it iterates
        /// through the entire array until it finds the index with target value.
        /// This works fine with smaller arrays but not ideal for larger data sets.
        /// 
        /// Time Complexity
        /// Best Case: O(1)
        /// Worst Case: O(n/2)
        /// 
        /// </summary>
        /// 

        /*Pseudocode
         * 
         * for i = array length - 1
         *  if array[i] = target
         *      return index
         *  else
         *      next i;
         */
        public static string search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Checking index {i}");
                if (array[i] == target)
                {
                    return $"Target {target} at index {i}";
                }
            }

            return "No target found";
        }
    }
}
