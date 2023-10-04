using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYtsShuffle
{
    public static class FYatesShuffler
    {
        private static Random rng= new Random();

        public static void FisherShuffle(this object[] array)
        {
            for (int i = array.Length-1; i > 0 ; i--)
            {
                //swapPositions(array, i, newRandom(i));

                int j = GetRandomNumberBtwnZeroAndI(i);
                array.swapPositions(i, j);
            }


            //I made an extension method so that any array can print out
            //its elements. I have it so Shuffle does it all instead of in Program.cs

                array.PrintArray();
        }


        public static void FisherShuffleAlternative(this object[] array)
        {
            for (int i = 0; i < array.Length-2; i++)
            {
                //swapPositions(array, i, newRandom(i));

                int j = GetRandomNumberBtwnZeroAndI((array.Length-1) - i);
                array.swapPositions(i, i+j);
            }


            //I made an extension method so that any array can print out
            //its elements. I have it so Shuffle does it all instead of in Program.cs

            array.PrintArray();
        }
        private static int newRandom(int n)
        { 

            return rng.Next(n+1);
            //I changed the random so that we can set it to start FROM zero
            //I prefer it like this
             
                //return rng.Next(0, n);
        }

        private static int GetRandomNumberBtwnZeroAndI(int n)
        {
            return rng.Next(n+1);    
        }
    }
}
