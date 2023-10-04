using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileToFisherYatesShuffle
{
    public static class FisherYatesShuffler
    {
        private static Random rng = new Random();


        /// <summary>
        /// This method here follows the Fisher Yates Shuffle procedure (specifically the 1st way).
        /// We take an array and start iterating in reverse.
        /// 
        /// Starting from the last element, we make a random number, j, between 0 and our current index i. If we get
        /// any number thats NOT i, we swap the values at i and j. 
        /// 
        /// The loop continues (i decrements) except now we are working with the last index - 1.
        /// We repeat the process until i = 0;
        /// 
        /// </summary>
        /// <param name="Fisher Shuffle"></param>
        public static void FisherShuffle(this object[] array)
        {
            Console.WriteLine($"Before Shuffle: ");
            array.PrintArray();


            for (int i = array.Length - 1; i > 0; i--)
            {     
                int j = newRandom(i);
                array.swapPositions(i, j);
            }


            //When we are done shuffling, we print out array
            Console.WriteLine($"After Shuffle: ");
            array.PrintArray();
        }
        private static int newRandom(int n)
        {
            return rng.Next(0, n + 1); //We get a random number FROM 0 up to the current index.
        }

        private static void swapPositions(this object[] array, int i, int j)
        {
            object tempObject = array[i]; //store current index value.
            array[i] = array[j];          //reassign current index value.
            array[j] = tempObject;        //assign the index we swapped with.
        }
    }
}
