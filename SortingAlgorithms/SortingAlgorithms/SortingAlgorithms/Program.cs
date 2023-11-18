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
            ///Merge --
            ///

            ///This demonstrates the 'Bubble Sort' method
            ///Very inefficient
            BubbleSort bubble = new BubbleSort();
            //bubble.Sort();
            Console.WriteLine();

            Insertion insertionSort = new Insertion();
            //insertionSort.Sort();
            Console.WriteLine();

            SelectionSort select = new SelectionSort();
            select.Sort();
            Console.WriteLine();

            QuickSort quick = new QuickSort();
            //quick.Sort();
            Console.WriteLine();

            MergeSort merge = new MergeSort();
            //merge.Sort();
            Console.WriteLine();

            HeapSort heap = new HeapSort();
            //heap.Sort();
        }
    }
}