using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public static class LinearSearch
    {
        public static string search(int[] array, int target)
        {
            Console.WriteLine("Linear Search");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return $"Target {target} at index {i}";
                }
            }

            return "No target found";
        }
    }
}
