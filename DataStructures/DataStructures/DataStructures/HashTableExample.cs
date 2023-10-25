using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures
{
    public class HashTableExample
    {
        public Hashtable myTable;
        private int capacity;

        //For getting data
        StreamReader reader;
        string data;
        string[] fileData;
        public HashTableExample()
        {
            reader = new StreamReader("Animals.txt");
            data= reader.ReadToEnd();
            fileData = data.Split(',');
            reader.Close();


            //Size of our HashTable
            capacity = 22;

            ///This is my new hashtable.
            ///
            ///Using the default constructor, the hashtable will be initialized with
            ///the default: Capacity, Load factor, and hashing and comparer.
            ///We can set custom values ^ in the constructor to fit our needs if needed.
            /// 
            myTable = new Hashtable(capacity); //We pass an initial capacity

            ///We add to our hastable using this method.
            ///We provid a (KEY[pick a type] , item to add).
            ///For this table, keys will be type(int) and items will be strings          
            ///

            //We set data from a text file holding various animals, and assign them a key based on index
            for (int i = 0; i < fileData.Length; i++)
            {
                myTable.Add(i+2, fileData[i]);
            }
            #region manually adding to hashtable
            //myTable.Add(11, "Cat");
            //myTable.Add(2, "Dog");
            //myTable.Add(33, "Horse");
            //myTable.Add(4, "Whale");
            //myTable.Add(15, "Alligator");
            //myTable.Add(15, "Alligator");
            //myTable.Add(15, "Alligator");
            //myTable.Add(15, "Alligator");
            #endregion

            //Items in the Hash Table are structs called DictionaryEntry 
            //as they only contain data: key, item
            foreach (DictionaryEntry hashEntry in myTable)
            {
                Console.WriteLine($"Key:{hashEntry.Key}\nHashCode:{hashEntry.GetHashCode() % capacity}\nItem:{hashEntry.Value}\n");
            }
        }
        
    }
}
