using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYtsShuffle
{
    public static class Swapper
    {
        public static void swapPositions(this object[] array, int i, int j)
        {
            object tempObject = array[i];
            array[i] = array[j];
            array[j] = tempObject;
        }
    }
}
