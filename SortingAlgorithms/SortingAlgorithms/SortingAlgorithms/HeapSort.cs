using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class HeapSort: ScoreSorting, ISortable
    {
        private int[] nums;
        private bool inHeap;

        int swapSpot, rootValue;
        public HeapSort()
        {
            GetScoresFromFile();
            nums = new int[] { 7, 2, 1, 6, 8, 5, 3, 9, 4 };
        }

        public void Sort()
        {
            startTimer();

            HeapSorting(scores); 

            PrintArray(scores);

            stopTimer();

            var elapsedTime = myStopWatch.ElapsedMilliseconds;
            Console.WriteLine($"Heap took | {elapsedTime}ms ");
        }

        /// <summary>
        /// 
        /// Heap is a comparison-based sort-in-place sorting algorithm, that means no extra memory is
        /// required (no extra arrays).
        /// Similar to seleciton sort, heap sort divides the array into a 'sorted' and 'unsorted' sections.
        /// 
        /// Heap sort makes use of the 'binary tree structure' (utilizing the parent-child node structure) as it takes an unsorted array and builds
        /// a 'heap' out of it. This is helpful since the definition of a heap tells us that the parent
        /// nodes must always be greater than or equal to its child elements. SO when we build a heap, we know that 
        /// the first element of the array will be the greatest element in the entire array.
        /// 
        /// When sorting, we swap the FIRST and LAST elements of the heap, 
        /// placing the greatest element at the end of the array and considering it sorted.
        /// Since we know the last element is sorted we DON'T want to iterate through it again, now our max index to iterate through is [array.length-i].
        /// We re-heap the array so that it follows the properties of a heap (the first element may not be > child element)
        /// We repeat this until we are at index 0, where every element will be sorted.
        /// 
        /// Runtime
        /// Best case:  O(n log n)
        /// Worst case: O(n log n)
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// 

        /* Pseudocode, from Essential Algorithms
         * 
         * Heapsort(Data: values)
                
                method: Turn the array into a heap
 
                For i = (values length) - 1 To 0;  Step -1

                    // Swap the root item and the last item.
                    Data: temp = values[0]
                    values[0] = values[i]
                    values[i] = temp
 
                    <Consider the item in position i to be removed from the heap,
                     so the heap now holds i - 1 items. Push the new root value
                     down into the heap to restore the heap property.>
                Next i
            End Heapsort  
         */
        private void HeapSorting(int[] array)
        {
            //This is a max heap, so we know the first element is the greatest
            MakeHeap(array);

            for (int i = array.Length-1; i > 0; i--)
            {
                array[i] = RemoveTopItem(array, i);
            }
        }

        private void MakeHeap(int[] array)
        { 
            int index = 0;
            int tempSpot = 0;
            int parent = 0;

            ///This creates a heap from the passed array.
            ///It follows the rules of priority
            for (int i = 0; i < array.Length; i++)
            {
                index = i;

                while (i != 0)
                {
                    parent = (index - 1) / 2;

                    if (array[index] <= array[parent])
                    {
                        break;
                    }
                    else
                    {
                        tempSpot= array[index];
                        array[index] = array[parent];
                        array[parent] = tempSpot;
                    }

                    index = parent;
                }
            }
        }

        private int RemoveTopItem(int[] array, int count)
        {
            //int count = array.Length - 1;

            ///Save the 'root' element.
            ///Replace the 'root' element with the last element.
            ///By this point, we know the greatest element is at the END of the array and sorted.
            rootValue = array[0];
            array[0] = array[count];


            int index = 0;

            int childOneIndex, childTwoIndex, swapChild;
            inHeap = false;

            //Now we must restore the heap's priority order
            while (!inHeap)
            {
                //Find child indices, not child values
                childOneIndex = (index*2) + 1; 
                childTwoIndex = (index*2) + 2;

                //If the children are at the end of the tree, set them to be the parent index
                if (childOneIndex >= count)
                {
                    childOneIndex = index;
                }
                if (childTwoIndex >= count)
                {
                    childTwoIndex = index;
                }

                //If the heap is 'heap (priority)' then break
                if ((array[index] >= array[childOneIndex]) && (array[index] >= array[childTwoIndex]))
                {
                    break;
                }

                //Get index of child with larger value
                if (array[childOneIndex] > array[childTwoIndex])
                {
                    swapChild = childOneIndex;
                }
                else
                {
                    swapChild = childTwoIndex;
                }

                //Swap with the larger child
                Swap(array, index, swapChild);
                index = swapChild;            
            }

            //Returns the value we took out at the beginning
            return rootValue;
        }

        //private void Swap(int[] arr, int i, int j) 
        //{
        //    swapSpot = arr[i];
        //    arr[i] = arr[j];
        //    arr[j] = swapSpot;
        //}
    }
}
