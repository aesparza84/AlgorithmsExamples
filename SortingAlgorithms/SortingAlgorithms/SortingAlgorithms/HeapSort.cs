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
            HeapSorting(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");
            }
        }

        private void HeapSorting(int[] array)
        {
            int tempSpot;
            //This is a max heap, so we know the first element is the greatest
            MakeHeap(array);

            for (int i = 0; i < 8; i++)
            {

            }
            RemoveTopItem(array);
            for (int i = array.Length-1; i > 0; i--)
            {
                tempSpot = array[0];
                array[0] = array[i];
                array[i] = tempSpot;
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

        private int RemoveTopItem(int[] array)
        {
            int count = array.Length - 1;

            ///Save the 'root' element.
            ///Replace the 'root' element with the last element.
            ///By this point, we know the greatest element is at the END of the array and sorted.
            rootValue = array[0];
            array[0] = array[array.Length-1];


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

        private void Swap(int[] arr, int i, int j) 
        {
            swapSpot = arr[i];
            arr[i] = arr[j];
            arr[j] = swapSpot;
        }
    }
}
