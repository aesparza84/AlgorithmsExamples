namespace TreeStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scoreArray = GetScores();
            scoreArray = QuickSort.Sort(scoreArray);

            //int[] test = new int[] {9,4,5,11,23,7}; 
            //int[] test = new int[] {1,1,2,3}; 
            int[] test = GetScores();

            //for (int i = 0; i < scoreArray.Length; i++)
            //{
            //    Console.WriteLine(scoreArray[i]);   
            //}

            Tree myTree = new Tree();
            for (int i = 0; i < test.Length; i++)
            {
                myTree.InsertValue(myTree.rootNode, test[i]);
            }

            //myTree.ContainsValue(76);
            Console.WriteLine(myTree.ContainsValue(76));

            int n = 1;
        }
        public static int[] GetScores()
        {
            FileStuff file = new FileStuff();
            int[] n = file.GetScoresFromFile();

            return n;
        }
    }
}