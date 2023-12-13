namespace TreeStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortedScores = GetScores();
            sortedScores = QuickSort.Sort(sortedScores);

            #region Test Arrays
            //int[] test = new int[] {9,4,5,11,23,7}; 
            //int[] test = new int[] {1,1,2,3}; 
            #endregion 
            int[] unsortedScores = GetScores();

            //Hover over me when Debugging
            Tree myTree = new Tree();

            for (int i = 0; i < unsortedScores.Length; i++)
            {
                myTree.InsertValue(myTree.rootNode, unsortedScores[i]);
            }

            //Change my value to see if the score is in the Tree 'myTree'
            Console.WriteLine(myTree.ContainsValue(726));

            //Breakpoint me to view the Tree 'myTree' and its nodes
            byte debuggingByte = 1;
        }
        public static int[] GetScores()
        {
            FileStuff file = new FileStuff();
            int[] n = file.GetScoresFromFile();

            return n;
        }
    }
}