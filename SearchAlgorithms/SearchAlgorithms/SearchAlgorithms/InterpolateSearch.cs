using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public static class InterpolateSearch
    {
        public static string search(int[] array, int Low, int Max, int target)
        {
            //Formula for getting index to search
            int searchIndex = Low + (Max - Low) * (target - array[Low]) / (array[Max] - array[Low]);

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
