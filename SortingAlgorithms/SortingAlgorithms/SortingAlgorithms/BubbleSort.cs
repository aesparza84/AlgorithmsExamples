using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort : ScoreSorting, ISortable
    {
        //private int[] scores;
        private int k, p;
        bool swapOccured;
        int[] nums;
        public BubbleSort()
        {
            GetScoresFromFile();
            nums = new int[] { 7, 2, 1, 6, 8, 5, 3, 9, 4 };
        }

        public void Sort()
        {
            startTimer();

            #region Old Inputs
            //int tempSpot = 0;

            //for (int i = 0; i < scores.Length-1; i++)
            //{
            //    swapOccured= false;
            //    for (int j = 0; j < scores.Length-1; j++)
            //    {
            //        if (scores[j] > scores[j + 1])
            //        {
            //            k = scores[j]; //The bigger number
            //            p = scores[j + 1]; //The smaller number

            //            //Swaps current index for next index
            //            tempSpot = k;
            //            scores[j] = p;
            //            scores[j+1] = tempSpot;
                        
            //            swapOccured= true;
            //        }
            //    }

            //    if (!swapOccured)
            //    {
            //        break;
            //    }                
            //}
            #endregion

            BubbleSorting(scores);

            PrintArray(scores);


            stopTimer();
            var elapsedTime = myStopWatch.ElapsedMilliseconds;
            Console.WriteLine($"Bubble took | {elapsedTime}ms ");
        }

        /// <summary>
        /// For bubble sort, we use the fact that 
        ///  'if an array is unsorted then there must be adjacent elements
        ///   that are out of order.'
        ///  
        /// We loop through the array and swap adjacent elements that are out of 
        /// order until there are no more out of order elements.
        /// 
        /// Runtime
        /// Best case:  O( n^2 )
        /// Worst case: O( n^2 )
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// 

        /*Pseudocode, from Essentials Algorithms 
         * 
         * Bubblesort(Data: values[])
            // Repeat until the array is sorted.

            Boolean: not_sorted = True
            While (not_sorted)

                // Assume we won't find a pair to swap.
                not_sorted = False

                // Search the array for adjacent items that are out of order.
                For i = 0 To <length of values> - 1


                    // See if items i and i - 1 are out of order.
                    If (values[i] < values[i - 1]) Then

                        // Swap them.
                        Data: temp = values[i]
                        values[i] = values[i - 1]
                        values[i - 1] = temp
 
                        // The array isn't sorted after all.
                        not_sorted = True

                    End If
                Next i
            End While
        End Bubblesort  
         */
        private void BubbleSorting(int[] array)
        {
            int tempSpot = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                swapOccured = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        k = array[j]; //The bigger number
                        p = array[j + 1]; //The smaller number

                        //Swaps current index for next index
                        tempSpot = k;
                        array[j] = p;
                        array[j + 1] = tempSpot;

                        swapOccured = true;
                    }
                }

                if (!swapOccured)
                {
                    break;
                }

            }
        }

    }
}
