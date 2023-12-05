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

            scoresOne = QuickSort.Sort(scoresOne);

            Console.WriteLine(LinearSearch.search(scoresOne, 66));
        }

        public static int[] GetAndSort()
        {
            FileStuff file = new FileStuff();
            int[] n = file.GetScoresFromFile();

            return n;
        }
        
    }
}