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
        public BubbleSort()
        {
            GetScoresFromFile();
            
        }

        public void Sort()
        {
            ///Given an int array, we want to check
            ///if current index is greater than next index.
            ///IF so, then swap. Repeat until sorted.
            ///

            startTimer(); 
            int tempSpot = 0;

            for (int i = 0; i < scores.Length-1; i++)
            {
                swapOccured= false;
                for (int j = 0; j < scores.Length-1; j++)
                {
                    if (scores[j] > scores[j + 1])
                    {
                        k = scores[j]; //The bigger number
                        p = scores[j + 1]; //The smaller number

                        //Swaps current index for next index
                        tempSpot = k;
                        scores[j] = p;
                        scores[j+1] = tempSpot;
                        
                        swapOccured= true;
                    }
                }

                if (!swapOccured)
                {
                    break;
                }
                
            }

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            PrintArray(scores);


            stopTimer();
            var elapsedTime = myStopWatch.ElapsedMilliseconds;
            Console.WriteLine($"Bubble took | {elapsedTime}ms ");
        }

    }
}
