using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.PortableExecutable;

namespace SearchAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Grabs the file from 'File' and sorts
            int[] scoresOne = GetAndSort();
            int[] scoresTwo = GetAndSort();
            int[] scoresThree = GetAndSort();

            #region Test Arrays, mainly for interpolate
            //int[] asd = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18};
            //int[] asd = new int[] {1, 2, 4, 6, 10, 12, 14, 16,18, 22, 24, 26, 28};
            //int[] asd = new int[] {13, 16, 19, 22, 30, 33, 36};
            //int[] asd = new int[] {1,2,4,8,16,32,64,128,256,512,1024};
            #endregion
            scoresOne = QuickSort.Sort(scoresOne);
            Console.WriteLine("Linear Search");
            Console.WriteLine(LinearSearch.search(scoresOne, 66)+"\n");

            scoresTwo = QuickSort.Sort(scoresTwo);
            Console.WriteLine("Binary Search");
            Console.WriteLine(BinarySearch.search(scoresTwo, 0, scoresTwo.Length - 1, 54) + "\n");

            scoresThree = QuickSort.Sort(scoresThree);
            Console.WriteLine("Interpolate search");
            Console.WriteLine(InterpolateSearch.search(scoresThree, 0, scoresThree.Length-1, 22) + "\n");

        }

        public static int[] GetAndSort()
        {
            FileStuff file = new FileStuff();
            int[] n = file.GetScoresFromFile();

            return n;
        }
        
    }
}