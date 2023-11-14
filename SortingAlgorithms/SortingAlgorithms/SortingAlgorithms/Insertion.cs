using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingAlgorithms
{
    public class Insertion: ScoreSorting, ISortable
    {
        private int[] array;

        //private StreamReader reader;
        //string filePath = "..\\..\\..\\File\\scores.txt";
        //private string text;
        //private int[] scores;
        //private string[] stringScores;

        private int[] nums;
        public Insertion() 
        {
            GetScoresFromFile();

           nums = new int[] { 5,2,76,3,11,98,9,7,21,6};
        }

        public void Sort()
        {
            ///Given an int array, we want to check
            ///if current index is LESS than previous index.
            ///IF so, then iterate through previous indexes
            ///until it is greater than previous index. Repeat until sorted.
            ///


            //We iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                ///We store the current index-value and previous index-location
                ///as the starting point to checking previou sorted section
                int currentInt = nums[i];
                int jIndex = i - 1;

                ///We iterate through the numbers we already sorted
                ///to check where to insert this new index.
                /// 
                ///If the previous index is greater than the current, we swap
                ///until the current index > previous index. Then we know its sorted
                while (jIndex >= 0 && (nums[jIndex] > currentInt))
                {
                    nums[jIndex + 1] = nums[jIndex];
                    nums[jIndex] = currentInt;
                    jIndex--;
                }


                #region Sorts by greatest
                //SKips first idnex, already sorted
                //if (i>0)
                //{
                //    for (int j = 0; j <= i; j++)
                //    {
                //        //If current 'j' index is greater than previous, Swap
                //        if (nums[j] < nums[i])
                //        {
                //            previous = nums[i];

                //            tempSpot = nums[j];
                //            nums[j] = previous;
                //            nums[i] = tempSpot;


                //        }
                //    }
                //}
                //Console.WriteLine($"Iteration {i + 1}");
                //for (int k = 0; k < nums.Length; k++)
                //{
                //    Console.WriteLine(nums[k]);
                //}
                #endregion
            }
            Console.WriteLine("Start| Insertion Sort");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        /*
          //If current index is greater than previous, Swap
                        if (nums[j] < nums[j - 1])
                        {
                            previous = nums[j - 1];

                            tempSpot = nums[i];
                            nums[j] = previous;
                            nums[j - 1] = tempSpot;
                        }
          */
    }
}
