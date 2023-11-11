using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    public class ConstantAglorithmExample : IAlgorithm
    {
        private int[] Array;

        public ConstantAglorithmExample(int N)
        {
            ///We create an array of 'N' length using
            ///the constructor. We fill the array with 5's.

            Array= new int[N];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = 5;
            }
        }
        public void DoAlgorithm()
        {
            Console.WriteLine("Constant");

            ///No matter the size of the array, the method
            ///will always return the length of the array in one step.

            int arrLength = Array.Length;
            Console.WriteLine("Length of array: "+arrLength);
            Console.WriteLine("-------------------------------------------");

        }
    }
}
