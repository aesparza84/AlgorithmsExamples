using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort:ScoreSorting, ISortable
    {
        private int[] nums;
        private int[] ?halfOne;
        private int[] ?halfTwo;
        private int[] scratchArray;

        private int midPoint;
        private int remainingIndices;
        public MergeSort() 
        {
            GetScoresFromFile();
            nums = new int[] { 7, 2, 1, 6, 8, 5, 3, 9, 4};

            scratchArray= new int[nums.Length];
            //scratchArray= new int[scores.Length];
        }

        public void Sort()
        {
            ///For merge sort, we want to split the array into 2 equal halves.
            ///We keep splitting sub arrays equally until they are one element.
            ///At that point we merge them together in a sorted order until it is
            ///back as 1 sorted array.
            ///

            mergeSort(nums, scratchArray, 0, nums.Length-1);
            //mergeSort(nums, scratchArray, 0, scores.Length-1);

        }

        private void mergeSort(int[] array, int[] scratch, int LowIndex, int HighIndex)
        {
            if (LowIndex == HighIndex)
            {
                return;
            }

            //Breaks array into 2 halves
            midPoint = (LowIndex+HighIndex) / 2;

            //Recursively call MergeSort to sort halves
            mergeSort(array, scratch, LowIndex, midPoint);
            mergeSort(array, scratch, midPoint+1, HighIndex);

            //Merge the halves
            int leftIndex = LowIndex;
            int rightIndex = midPoint+1;
            int scratchIndex = leftIndex;

            while ( (leftIndex <= midPoint) && (rightIndex <= HighIndex) ) 
            {
                if (array[leftIndex] <= array[rightIndex])
                {
                    scratch[scratchIndex] = array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    scratch[scratchIndex] = array[rightIndex];
                    rightIndex++;
                }
            }

            //Finish copying whichever half is not empty
            for (int i = leftIndex; i < midPoint; i++)
            {
                scratch[scratchIndex] = array[i];
                scratchIndex++;
            }

            for (int i = rightIndex; i < HighIndex; i++)
            {

            }


            #region Old inputs
            /*
            remainingIndices = array.Length - midPoint;

            halfOne= new int[midPoint];
            halfTwo= new int[remainingIndices];

            for (int i = 0; i < midPoint; i++)
            {
                halfOne[i] = array[i];
            }

            for (int i = 0; i < array.Length-midPoint; i++)
            {
                halfTwo[i] = array[midPoint+ i];
            }

            Console.WriteLine($"1 Array");
            PrintArray(halfOne);

            Console.WriteLine($"2 Array");
            PrintArray(halfTwo);
            */
            #endregion
        }

        public static void PrintArray(int[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine($"{array[k]} ");
            }
            Console.WriteLine();
        }
    }
}

