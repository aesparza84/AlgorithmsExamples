using System;
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


            #region consecutive checking
            //int[] arrA = { 1, 2, 3, 4, 5, 6 };
            //int[] arrB = { 6,3,4,3,2,1};

            //bool checkConsecutive(int[] passedArray)
            //{
            //    bool isConsectuive = false;
            //    int index = 0;

            //    //sorts the array
            //    passedArray = sortArray(passedArray);


            //    //iterate thorugh array
            //    for (int i = 0; i < passedArray.Length-1; i++)
            //    {
            //        //check if next numubers difference is 1
            //        if (MathF.Abs(passedArray[i] - passedArray[i + 1]) != 1)
            //        {
            //            isConsectuive = false; break;
            //        }

            //        isConsectuive = true;
            //        //if 1, go to next index, still consecutive
            //        //else, break out of loop
                   
            //    }
                

            //    if (isConsectuive)
            //    {
            //        Console.WriteLine("Consective");
            //        return true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not COnsectuive");
            //        return false;
            //    }
                
                
            //}

            //int[] sortArray(int[] passedArray)
            //{
            //    for (int i = 0; i < passedArray.Length; i++)
            //    {
            //        bool doneSort = false;

            //        //While not done sorting
            //        while (!doneSort)
            //        {
            //            if (i <= 0)
            //            {
            //                doneSort = true;
            //            }
            //            else if (passedArray[i] < passedArray[i - 1]) //If current element < previous element
            //            {
            //                for (int n = 0; n < i; n++) //Sort through elemetns up to previous element
            //                {
            //                    if (passedArray[i] < passedArray[n])   //If element to sort is less than sorting element 
            //                    {
            //                        int j = passedArray[i];       //Swap elements
            //                        int a = passedArray[n];
            //                        passedArray[i] = a;
            //                        passedArray[n] = j;
            //                    }
            //                }
            //            }
            //            doneSort = true;
            //        }
            //    }
            //    return passedArray;
            //}

            //checkConsecutive(arrB);
            #endregion
        }
    }
}