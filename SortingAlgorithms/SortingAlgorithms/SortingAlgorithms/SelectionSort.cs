using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort : ScoreSorting, ISortable
    {

        int minimumBound;
        int swapIndex;
        int tempSpot;

        int[] nums;
        public SelectionSort() 
        {
            GetScoresFromFile();
            nums = new int[] { 7, 2, 1, 6, 8, 5, 3, 9, 4 };
            //scores = new int[] { 5, 2, 76, 3, 11, 98, 9, 7, 21, 6 };
        }

        
        public void Sort()
        {
            startTimer();

            #region Old inputs
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    minimumBound = scores[i];

            //    for (int j = i; j < scores.Length; j++)
            //    {
            //        if (scores[j] < minimumBound)
            //        {
            //            minimumBound = scores[j];
            //            swapIndex = j;
            //        }
            //    }

            //    tempSpot = scores[i];
            //    scores[i] = scores[swapIndex];
            //    scores[swapIndex] = tempSpot;

            //}
                #endregion

            SelectSort(nums);

            PrintArray(nums);

            stopTimer();

            var elapsedTime = myStopWatch.ElapsedMilliseconds;
            Console.WriteLine($"Selection took | {elapsedTime}ms ");
        }

        /// <summary>
        /// For selection sort, we want to sort the array in ascending order.
        /// We take the first item in the array as the 'minimum' value. 
        /// We then iterate to the end and see if there is a lower minimum. If so then swap.
        /// 
        ///  We repeat, but starting with index i+1 each time until we reach the end of the array.
        /// 
        ///  Runtime
        ///  Best case: O(n)
        ///  Worst case: O( n^2 ) 
        /// </summary>
        /// 

        ///Pseudocode
        ///.
        /// For i=0, i < A.Length
        ///,  Minimum = A[i];
        ///  
        ///    For j=i, j<A.Length
        ///,     if A[j] < minimum
        ///,        Minimum = A[j]
        ///         next j;
        ///,   
        ///     swap current index with new Minimum index
        ///  
        /// next i;

        private void SelectSort(int[] array)
        {
            bool needSwap = false;
            for (int i = 0; i < array.Length; i++)
            {
                minimumBound = array[i];
                needSwap = false;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < minimumBound)
                    {
                        needSwap= true;

                        minimumBound = array[j];
                        swapIndex = j;
                    }
                }

                if (needSwap) { Swap(array, i, swapIndex); }
                

            }
        }
    }
}
