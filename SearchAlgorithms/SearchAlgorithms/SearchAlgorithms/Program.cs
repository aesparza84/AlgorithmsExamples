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

            int[] asd = new int[] {1,2,3,4,5,6,7,8,9,10,11};

            //scoresOne = QuickSort.Sort(scoresOne);
            //Console.WriteLine(LinearSearch.search(scoresOne, 66));

            scoresTwo= QuickSort.Sort(scoresTwo);

            Console.WriteLine("Binary Search");
            Console.WriteLine(BinarySearch.search(scoresTwo, 0, scoresTwo.Length-1, 54));

        }

        public static int[] GetAndSort()
        {
            FileStuff file = new FileStuff();
            int[] n = file.GetScoresFromFile();

            return n;
        }
        
    }
}