namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Bubble --
            ///Insertion --
            ///Selection --
            ///
            ///Heap
            ///Quick --
            ///Merge
            ///

            ///This demonstrates the 'Bubble Sort' method
            ///Very inefficient
            BubbleSort bubble = new BubbleSort();
            //bubble.Sort();

            Insertion insertionSort = new Insertion();
            //insertionSort.Sort();

            SelectionSort select = new SelectionSort();
            //select.Sort();

            QuickSort quick = new QuickSort();
            //quick.Sort();

            MergeSort merge= new MergeSort();
            merge.Sort();
        }
    }
}