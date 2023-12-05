using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public static class InterpolateSearch
    {
        /// <summary>
        /// 
        /// The Interpolate search algorithm works best on sorted data sets 
        /// that are mostly uniform. Interpolate search uses a formula based off 
        /// the target value and array size to estimate where the target value's index
        /// might be located.
        /// 
        /// The formula goes: LowIndex + (MaxIndex - LowIndex) * (targetValue - array[Lowindex]) / (array[MaxIndex] - array[Lowindex]);
        /// 
        /// Time Complexity
        /// Best Case: O (log log n)
        /// Worst Case: O(n)
        /// 
        /// </summary>
        /// 

        /*Pseudocode
         Interpolate(array, Low, Max, target)
        
            int searchIndex = Low + (Max - Low) * (target - array[Low]) / (array[Max] - array[Low]);

            if array[searchIndex] = target
                return index;

            if array[searchIndex] > target
                return search(array, Low, searchIndex - 1, target);

            if array[searchIndex] < target
                return search(array, searchIndex - 1, Max, target);
          
         */
        public static string search(int[] array, int Low, int Max, int target)
        {
            //Formula for getting index to search
            int searchIndex = Low + (Max - Low) * (target - array[Low]) / (array[Max] - array[Low]);
            Console.WriteLine($"Checking index {searchIndex}");

            if (array[searchIndex] == target)
            {
                return $"Target {target} at index {searchIndex}";
            }

            if (array[searchIndex] > target)
            {
                return search(array, Low, searchIndex-1, target);
            }
            if (array[searchIndex] < target)
            {
                return search(array, searchIndex+1, Max, target);
            }

            return "";
        }
    }
}
