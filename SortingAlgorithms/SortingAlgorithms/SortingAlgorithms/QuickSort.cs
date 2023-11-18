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
        private int partitionIndex;

        private int currentIndex;
        private int swapIndex, prevSwap;
        private int tempSpot;
       
        public QuickSort() 
        {
            GetScoresFromFile();
            //nums = new int[] { 5, 2, 76, 3, 11, 98, 9, 7, 21, 6 };
            nums = new int[] { 7, 2, 1, 6, 8, 5, 3, 9, 4 };
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
            startTimer();

            Pivot = scores.Length-1;
            //PartitionAndGetIndex(nums, 0, Pivot);

            quickSort(scores, 0, Pivot);

            PrintArray(scores);

            stopTimer();

            var elapsedTime = myStopWatch.ElapsedMilliseconds;
            Console.WriteLine($"Quick took | {elapsedTime}ms ");

        }

        private void quickSort(int[] array, int LowIndex, int HighIndex)
        {
            //This lets us know if the sub-array has 1 element. 
            if (LowIndex < HighIndex)
            {
                ///This partitions the array from the passed Pivot.
                /// Everything to the left (of Pivot) < Pivot
                ///,Everything to the right(of Pivot) > Pivot
                ///
                /// Also returns index of the partioning Pivot
                ///
                partitionIndex = PartitionAndGetIndex(array, LowIndex, HighIndex);

                ///Recursively, we call this funtion again to sort
                ///both the left and right side of the partitions
                ///

                //array, from [LowIndex] -> [partitionIndex-1]
                quickSort(array, LowIndex, partitionIndex - 1);

                //array, from [partitionIndex+1] -> [HighIndex]
                quickSort(array, partitionIndex + 1, HighIndex);
            }            
        }

        private int PartitionAndGetIndex(int[] array, int LowIndex, int HighIndex)
        {
            currentIndex= LowIndex;
            swapIndex = -1;

            for (int i = 0; i < HighIndex+1; i++)
            {
                currentIndex = i;
                prevSwap = swapIndex;

                //Checks if 'index value <= pivot value'
                //We don't need to swap if less than Pivot Value.
                if (array[currentIndex] <= array[HighIndex])
                {
                    if (swapIndex < 0)
                    {
                        swapIndex = 0;
                    }
                    else { swapIndex++; }

                }

                //if index is ahead of swap, Swap positions
                if (swapIndex != prevSwap && currentIndex > swapIndex)
                {
                    tempSpot = array[currentIndex];
                    array[currentIndex] = array[swapIndex];
                    array[swapIndex] = tempSpot;

                    if (currentIndex == array.Length - 1)
                    {
                        partitionIndex = swapIndex;
                    }
                }

                //PrintArray(array);
            }

            return swapIndex;
            //Console.WriteLine($"{Pivot} is at {partitionIndex}");
        }
    }
}
