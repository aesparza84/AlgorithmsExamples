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
        public SelectionSort() 
        {
            GetScoresFromFile();

            //scores = new int[] { 5, 2, 76, 3, 11, 98, 9, 7, 21, 6 };
        }

        /// <summary>
        /// For selection sort, we want to sort the array in ascending order.
        /// We take the first item in the array as the 'minimum' value. 
        /// We then iterate to the end and see if there is a lower minimum. If so then swap.
        /// We repeat, but starting with index i+1 each time
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
        public void Sort()
        {
            minimumBound = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                minimumBound = scores[i];

                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < minimumBound)
                    {
                        minimumBound = scores[j];
                        swapIndex = j;
                    }
                }

                tempSpot = scores[i];
                scores[i] = scores[swapIndex];
                scores[swapIndex] = tempSpot;

            }

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}
