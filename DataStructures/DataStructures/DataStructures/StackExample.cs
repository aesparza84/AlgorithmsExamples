using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures
{
    public class StackExample
    {
        private Stack<string> animalStack;
        private List<string> poppedItems;

        //For getting data
        StreamReader reader;
        string data;
        string[] fileData;
        public StackExample() 
        {
            animalStack= new Stack<string>();
            poppedItems= new List<string>();

            reader = new StreamReader("Animals.txt");
            data = reader.ReadToEnd();
            fileData = data.Split(',');
            reader.Close();



            ///For stacks, when we want to add items we call
            ///the 'stack.Push(x)' method. This adds items to
            ///the bottom of our stack.
            ///
            ///Stacks are used for their LIFO property: Last In First Out.
            ///It can be thought of as stacking plates in a sink, where the 
            ///plate on top will be the first to get washed.

            Console.WriteLine("Stack Incoming order");
            for (int i = 0; i < fileData.Length; i++)
            {
                Console.WriteLine($"{i+1}.) {fileData[i]}");
                animalStack.Push(fileData[i]);
            }
            Console.WriteLine();

            while (animalStack.Count > 0)
            {
                poppedItems.Add(animalStack.Pop());
            }

            ///Since we popped all the items in our animalStack, the last item
            ///from the stack was the FIRST item to get added to our list.
            ///This list shows the order of how the items were taken out (Popped).
            ///
            ///As we can see, the FIRST item in animal stack was the LAST item to
            ///get added to this list.
            Console.WriteLine("Stack Output order");
            for (int i = 0; i < poppedItems.Count; i++)
            {
                Console.WriteLine($"{i+1}.) {poppedItems[i]}");
            }
        }
    }
}
