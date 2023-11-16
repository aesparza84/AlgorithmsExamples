using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class HeapSort: ScoreSorting, ISortable
    {
        private int[] nums;
        public HeapSort()
        {
            GetScoresFromFile();
            nums = new int[] { 7, 2, 1, 6, 8, 5, 3, 9, 4 };
        }

        public void Sort()
        {
            //This is a max heap, so we know the first element is the greatest
            MakeHeap(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");
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
            int n = array[0];
            array[0] = array[array.Length-1];


            int index = 0;

            int childOne, childTwo, swapChild;

            //Now we must restore the heap's priority order
            while (true)
            {
                //Find child indices, not child values
                childOne = index*2 + 1; 
                childTwo = index*2 + 2;

                //If a child is out of index, set index as parent's index
                if (childOne >= count)
                {
                    childOne = index;
                }

                if (childTwo >= count)
                {
                    childTwo = index;
                }

                //If the heap is 'heap (priority)' then break
                if ((array[index] >= array[childOne]) && (array[index] >= array[childTwo]))
                {
                    break;
                }

                //Get index of child with larger value
                if (array[childOne] > array[childTwo])
                {
                    swapChild = childOne;
                }
                else
                {
                    swapChild = childTwo;
                }

                //Swap with the larger child

            
            }

            return n;
        }
    }
}
