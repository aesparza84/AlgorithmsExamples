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
            ///Given an int array, we want to check
            ///if current index is greater than next index.
            ///IF so, then swap. Repeat until sorted.
            ///

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

            BubbleSorting(nums);

            PrintArray(nums);


            stopTimer();
            var elapsedTime = myStopWatch.ElapsedMilliseconds;
            Console.WriteLine($"Bubble took | {elapsedTime}ms ");
        }

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
