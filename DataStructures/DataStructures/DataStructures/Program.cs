using System.Collections;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Hash table class, go into class to see more.
            ///     Better suited for LARGER data sets (efficiency when looking up)
            ///     Weak for smaller data sets. 
            ///     
            ///Comment out to not create table.
                //HashTableExample newTable = new HashTableExample();

            ///The StackExample class demonstrates how a stack:
            ///takes in elements, outputs its elements.
            ///Go into class to see more.
            ///
            ///The stack property of LIFO (Last In First Out) is shown
            ///Comment out to not create stack.
                //StackExample newStack = new StackExample();

            ///The QueueExample class demonstrates properties of the Queue.
            ///This demonostrates the Queues's FIFO property of handling data.
            ///Go into class to see more.
            ///
            ///Comment out to not create Queue
                //QueueExample newQueue = new QueueExample();

            //ArrayExample newArray = new ArrayExample(); 

            int[] arrA = { 1, 2, 3, 4, 5, 6 };

            bool checkConsecutive(int[] passedArray)
            {
                bool doneChecking = false;
                int index = 0;
                while (!doneChecking)
                {
                    for (int i = 0; i < passedArray.Length; i++)
                    {
                        index = i;
                        if (i != passedArray.Length-1)
                        {
                            if (MathF.Abs(passedArray[i] - passedArray[i + 1]) == 1)
                            {

                            }
                            else 
                            {
                                doneChecking = true;
                            }
                        }
                        else
                        { doneChecking = true; }
                    }
                }

                if (index + 1 == arrA.Length)
                {
                    return true;
                }
                else { return false; }
                
                
            }

            checkConsecutive(arrA);
        }
    }
}