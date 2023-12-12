namespace TreeStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scoreArray = GetAndSort();

            scoreArray = QuickSort.Sort(scoreArray);

            for (int i = 0; i < scoreArray.Length; i++)
            {
                Console.WriteLine(scoreArray[i]);   
            }
        }
        public static int[] GetAndSort()
        {
            FileStuff file = new FileStuff();
            int[] n = file.GetScoresFromFile();

            return n;
        }
    }
}