using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    public class ConstantAglorithmExample : IAlgorithm
    {
        private int ArraySize;
        private int[] Array;

        public ConstantAglorithmExample(int N)
        {
            ArraySize = N;
            Array= new int[ArraySize];
        }
        public void DoAlgorithm()
        {
            for (int i = 0; i < Array.Length; i++)
            {

            }

        }
    }
}
