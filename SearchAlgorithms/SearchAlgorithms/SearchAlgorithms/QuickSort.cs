using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace SearchAlgorithms
{
    public static class QuickSort
    {
        public static int partitionIndex;
        public static int Pivot;
        public static int currentIndex;
        public static int swapIndex;
        public static int tempSpot;
        public static int prevSwap;
        public static int[] Sort(int[] array)
        {
            partitionIndex = 0;
            currentIndex = 0;
            currentIndex = 0;
            swapIndex = 0;
            tempSpot = 0;
            prevSwap = 0;

            Pivot = array.Length - 1;

            quickSort(array, 0, Pivot);

            return array;

        }
        private static void quickSort(int[] array, int LowIndex, int HighIndex)
        {
            if (LowIndex < HighIndex)
            {
                int partitionIndex = PartitionAndGetIndex(array, LowIndex, HighIndex);
                quickSort(array, LowIndex, partitionIndex - 1);
                quickSort(array, partitionIndex + 1, HighIndex);
            }
        }

        private static int PartitionAndGetIndex(int[] array, int LowIndex, int HighIndex)
        {
             currentIndex = LowIndex;
             swapIndex = -1;

            for (int i = 0; i < HighIndex + 1; i++)
            {
                currentIndex = i;
                prevSwap = swapIndex;


                if (array[currentIndex] <= array[HighIndex])
                {
                    if (swapIndex < 0)
                    {
                        swapIndex = 0;
                    }
                    else { swapIndex++; }

                }

                if (swapIndex != prevSwap && currentIndex > swapIndex)
                {
                    int tempSpot = array[currentIndex];
                    array[currentIndex] = array[swapIndex];
                    array[swapIndex] = tempSpot;

                    if (currentIndex == array.Length - 1)
                    {
                        partitionIndex = swapIndex;
                    }
                }
            }

            return swapIndex;
        }
    }
}
