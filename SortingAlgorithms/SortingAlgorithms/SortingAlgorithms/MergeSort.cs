﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort:ScoreSorting, ISortable
    {
        private int[] nums;
        //private int[] ?halfOne;
        //private int[] ?halfTwo;

        private int midPoint;
        private int remainingIndices;
        public MergeSort() 
        {
            GetScoresFromFile();
            nums = new int[] { 7, 2, 1, 6, 8, 5, 3, 9, 4};

            //scratchArray= new int[scores.Length];
        }

        public void Sort()
        {
            ///For merge sort, we want to split the array into 2 equal halves.
            ///We keep splitting sub arrays equally until they are one element.
            ///At that point we merge them together in a sorted order until it is
            ///back as 1 sorted array.
            ///

            startTimer();

            mergeSort(scores,0, scores.Length-1);

            PrintArray(scores);

            stopTimer();

            var elapsedTime = myStopWatch.ElapsedMilliseconds;
            Console.WriteLine($"Merge took | {elapsedTime}ms ");

        }

        /// <summary>
        /// Merge uses the divide-and-conquer approach to sorting. Unlike quick sort, merge sort is not
        /// in-place sorting, meaning we will need extra memory for the sub arrays.
        /// For the 'divide' aspect, Merge sort calls itself recursively to split the array in half,
        /// which will split the sub arrays in half until they are one element.
        /// 
        /// At that point we can compare elements from the the 'left' and 'right' half arrays,
        /// place those indexes into an array that will be in sorted order, and recursively merge back the 
        /// arrays until we have 1 sorted array.
        /// 
        /// Runtime
        /// Best case:  O(n log n)
        /// Worst case: O(n log n)
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="LowIndex"></param>
        /// <param name="HighIndex"></param>
        /// 

        /*Pseudocode, from Essential Algorithms
         * 
         * Mergesort(Data: values[], Data: scratch[], Integer: start, Integer: end)
         
            // If the array contains only one item, it is already sorted.
            If (start == end) Then Return
 
                // Break the array into left and right halves.
                Integer: midpoint = (start + end) / 2
 
                // Call Mergesort to sort the two halves.
                Mergesort(values, scratch, start, midpoint)
                Mergesort(values, scratch, midpoint + 1, end)
 
                // Merge the two sorted halves.
                Integer: left_index = start
                Integer: right_index = midpoint + 1
                Integer: scratch_index = left_index
                While ((left_index <= midpoint) And (right_index <= end))
                    If (values[left_index] <= values[right_index]) Then
                        scratch[scratch_index] = values[left_index]
                        left_index = left_index + 1
                    Else
                        scratch[scratch_index] = values[right_index]
                        right_index = right_index + 1
                    End If
                        scratch_index = scratch_index + 1   
                End While
 
                // Finish copying whichever half is not empty.
                For i = left_index To midpoint
                    scratch[scratch_index] = values[i]
                    scratch_index = scratch_index + 1
                Next i
                
                For i = right_index To end
                    scratch[scratch_index] = values[i]
                    scratch_index = scratch_index + 1
                Next i

                // Copy the values back into the original values array.
                For i = start To end
                    values[i] = scratch[i]
                Next i
            End Mergesort
         * 
         */
        private void mergeSort(int[] array,int LowIndex, int HighIndex)
        {
            //We check if the passed array is only 1 element
            if (array.Length <= 1)
            {
                return;
            }

            //Breaks array into 2 halves
            midPoint = (array.Length) / 2;
            remainingIndices = array.Length - midPoint; //This is in case we get odd length arrays

            int[] halfOne = new int[midPoint];
            int[] halfTwo = new int[remainingIndices];

            //Fills the left half of array with elementes from '0 -> Midpoint'
            for (int i = 0; i < midPoint; i++)
            {
                halfOne[i] = array[i];
            }

            //Fills the right half of array with elementes from 'Midpoint -> End'
            for (int i = midPoint; i < array.Length; i++)
            {
                halfTwo[i - midPoint] = array[i];
            }


            //Recursively call MergeSort to sort halves
            mergeSort(halfOne, 0, halfOne.Length-1);
            mergeSort(halfTwo, 0, halfTwo.Length-1);

            //Merge the halves
            //MergeHalves(array, scratch, LowIndex, HighIndex);
            MergeArrays(array, halfOne, halfTwo);


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

        private void MergeArrays(int[] array, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int mainIndex = 0;

            while ( (leftIndex < left.Length) && (rightIndex < right.Length))
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    array[mainIndex] = left[leftIndex];
                    leftIndex++;
                }
                else 
                {
                    array[mainIndex] = right[rightIndex];
                    rightIndex++;
                }
                mainIndex++;
            }

            //Finish copying whichever half is not empty

            //In case there are any elements still in Left half (Everything from Right half was sorted)
            while (leftIndex < left.Length)
            {
                array[mainIndex] = left[leftIndex];
                leftIndex++;
                mainIndex++;
            }

            //In case there are any elements still in Right half (Everything from Left half was sorted)
            while (rightIndex < right.Length)
            {
                array[mainIndex] = right[rightIndex];
                rightIndex++;
                mainIndex++;
            }

        }

        private void MergeHalves(int[] array, int[] scratch, int LowIndex, int HighIndex)
        {
            ///From the MergeSort pseudocode

            //int leftIndex = LowIndex;
            //int rightIndex = midPoint + 1;
            //int scratchIndex = leftIndex;

            //while ((leftIndex <= midPoint) && (rightIndex <= HighIndex))
            //{
            //    if (array[leftIndex] <= array[rightIndex])
            //    {
            //        scratch[scratchIndex] = array[leftIndex];
            //        leftIndex++;
            //    }
            //    else
            //    {
            //        scratch[scratchIndex] = array[rightIndex];
            //        rightIndex++;
            //    }
            //}


            ////Finish copying whichever half is not empty
            //for (int i = leftIndex; i < midPoint; i++)
            //{
            //    scratch[scratchIndex] = array[i];
            //    scratchIndex++;
            //}
            //for (int i = rightIndex; i < HighIndex; i++)
            //{
            //    scratch[scratchIndex] = array[i];
            //    scratchIndex++;
            //}
            //for (int i = LowIndex; i < HighIndex; i++)
            //{
            //    array[i] = scratch[i];
            //}
        }
    }
}

