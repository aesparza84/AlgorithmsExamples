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

        public static void FisherShuffle(this object[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                //swapPositions(array, i, newRandom(i));

                int j = newRandom(i);
                array.swapPositions(i, j);
            }


            //I made an extension method so that any array can print out
            //its elements. I have it so Shuffle does it all instead of in Program.cs

            array.PrintArray();
        }
        private static int newRandom(int n)
        {
            return rng.Next(0, n + 1);
        }

        private static int swapPositions(int n)
        {
            return rng.Next(n + 1);
        }

        private static void swapPositions(this object[] array, int i, int j)
        {
            object tempObject = array[i];
            array[i] = array[j];
            array[j] = tempObject;
        }
    }
}
