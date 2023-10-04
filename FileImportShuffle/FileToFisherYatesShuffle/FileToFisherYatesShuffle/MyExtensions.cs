using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileToFisherYatesShuffle
{
    public static class MyExtensions
    {
        public static void PrintArray(this object[] passedArray)
        {
            for (int i = 0; i < passedArray.Length; i++)
            {
                Console.Write($"{passedArray[i]} ");
            }
        }
    }
}
