namespace FisherYtsShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] myArray = {"A","B","C","D", "E"};
            //myArray.FisherShuffle();
            myArray.FisherShuffleAlternative();

            ///I prefer the initial version of the Fisher-Yates Shuffle
            ///since iterating from highest to lowest element takes less steps 
            ///and each element still can be shuffled


            Console.ReadLine();
        }
    }
}