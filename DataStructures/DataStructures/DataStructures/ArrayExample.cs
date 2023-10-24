using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures
{
    public class ArrayExample
    {
        private string[] animalArray;

        //For getting data
        StreamReader reader;
        string data;
        string[] fileData;
        public ArrayExample() 
        {

            reader = new StreamReader("Animals.txt");
            data = reader.ReadToEnd();
            fileData = data.Split(',');
            reader.Close();

            ///We declare the array size as the size of the filData array.
            ///Once we declare an array, we can NOT change the size.
            ///If we need to change the size we would create a new array of the size we need,
            ///and copy the elements of the 1st array into newly sized one.
            animalArray = new string[fileData.Length];

            for (int i = 0; i < fileData.Length; i++)
            {
                animalArray[i] = fileData[i];
            }

            ///Setting elements to an array is pretty simple, you just iterate
            ///through the arrays length and set elements at the index.
            ///
            ///Here I set my animalArray to the size of the fileData array as that 
            ///is the amount of elements I need to store.
            ///
            ///Since 
            ///
           
            Console.WriteLine($"Items in array. Size of {animalArray.Length}"); 
            for (int i = 0; i < animalArray.Length; i++)
            {
                Console.WriteLine($"{i+1}.) {animalArray[i]}");
            }
        }
    }
}
