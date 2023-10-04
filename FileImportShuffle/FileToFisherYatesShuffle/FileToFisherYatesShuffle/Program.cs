namespace FileToFisherYatesShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadingFile rf= new ReadingFile();

            rf.letters.FisherShuffle();
            Console.ReadLine();
        }
    }
}