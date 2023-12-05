using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public static class BinarySearch
    {
        private static int MiddleIndex;
        public static string search(int[] array, int low, int max, int target)
        {
            MiddleIndex= 0;

            //We get the middle of the index
            MiddleIndex = (max+low) / 2;

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
