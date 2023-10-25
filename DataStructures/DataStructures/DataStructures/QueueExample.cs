using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures
{
    public class QueueExample
    {
        private Queue<string> animalQueue;
        private List<string> dequeuedItems;

        //For getting data
        StreamReader reader;
        string data;
        string[] fileData;
        public QueueExample() 
        {
            animalQueue = new Queue<string>();
            dequeuedItems = new List<string>();

            reader = new StreamReader("Animals.txt");
            data = reader.ReadToEnd();
            fileData = data.Split(',');
            reader.Close();



            ///For Queues, to add items we call the Queue.Enqueue() method.
            ///This method puts the FIRST item at the 'head' of the index.
            ///Items added after are added to the 'tail' of the index.
            ///
            ///The more you add to the queue, the array behind the queue resizes.
            ///
            ///

            Console.WriteLine("Queue Incoming order");
            for (int i = 0; i < fileData.Length; i++)
            {
                Console.WriteLine($"{i + 1}.) {fileData[i]}");
                animalQueue.Enqueue(fileData[i]);
            }
            Console.WriteLine();

            while (animalQueue.Count > 0)
            {
                dequeuedItems.Add(animalQueue.Dequeue());
            }

            ///When we want to remove items from a Queue, we use the Queue.Dequeue() method.
            ///
            ///Since the Queue has the FIFO property (First In First Out), Dequeing items
            ///removes the items in the order that they were added:
            ///First item added is first to get removed, last item added is last to leave the queue.
            ///
            ///You can think of it as 'getting in line' and waiting your turn.

            Console.WriteLine("Queue Output order");
            for (int i = 0; i < dequeuedItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}.) {dequeuedItems[i]}");
            }
        }
    }
}
