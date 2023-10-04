namespace FileToFisherYatesShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A simple class that takes a text file, reads it, and stores the information into an Array
            ReadingFile rf= new ReadingFile();


            rf.letters.FisherShuffle();

            Console.ReadLine();
        }
    }
}