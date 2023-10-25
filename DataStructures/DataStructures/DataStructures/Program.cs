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
            ///Comment out to not create Hash Table.
            ///
            HashTableExample newTable = new HashTableExample();


            ///The StackExample class demonstrates how a stack:
            ///takes in elements, outputs its elements.
            ///Go into class to see more.
            ///
            ///The stack property of LIFO (Last In First Out) is shown
            ///Comment out to not create Stack.
            ///
            //StackExample newStack = new StackExample();


            ///The QueueExample class demonstrates properties of the Queue.
            ///This shows the Queues's FIFO property of handling data.
            ///Go into class to see more.
            ///
            ///Comment out to not create Queue
            ///
            //QueueExample newQueue = new QueueExample();


            ///The ArrayExample class demonstrates the use of an array to store elements.
            ///This shows how an array takes in data and how it iterates through its elements.
            ///Go into class to see more.
            ///
            ///Comment out to not create Array
            ///
            //ArrayExample newArray = new ArrayExample(); 



            //---Key notes about the data structures---//

            ///HASH TABLES
            ///
            ///PRO: They better suited for larger data sets as inserting, lookup and delete
            ///take on average O(1) to compute, worst case O(n).
            ///
            ///CON: When two keys lead to the same bucket (a collision) linked lists are used to search 
            ///for the desired items, which is not ideal for large data sets.
            ///

            ///ARRAY
            ///
            ///PRO: Arrays are great for small data sets. Initializing an array keeps all the elements near
            ///eachother in memory which allows for quick and efficient lookup. 
            ///Insert takes O(1), lookup and delete takes O(n).
            ///
            ///CONS: The lookup taking O(n) makes arrays not ideal for large data sets, whereas Hash points you 
            ///directly to the data location.
            ///

            ///STACK
            ///
            ///PRO: All operations take O(1) to perform.
            ///
            ///Stacks have a LIFO proerty (Last In First Out), where the LAST item to enter the stack
            ///is the FIRST item to leave the stack. 
            /// 
            ///Stacks can be used for tracking data through a process. An example can be
            ///the 'Undo' command in a lot of software. You can 'Pop' off the last command 
            ///and return to the previous iteration.
            ///
            ///CONS: If you need to access something at the bottom of the stack, it would take O(n) time
            ///and would be inefficient.
            ///

            ///QUEUE
            ///
            ///PRO: Very similar to Stacks, all operations take O(1) time to perform.
            ///
            ///Queues, unlike stacks, follow the FIFO method (First In First Out).
            ///The First item to enter the list is the First item to be output.
            ///
            ///An example use could be handling web requests, where you would want to handle them in the order
            ///that they were recieved.
            ///
            ///CONS: There is no random access, so searching for where an item is or if it contains an item
            ///is not ideal with Queues as you would need to convert to an array.
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