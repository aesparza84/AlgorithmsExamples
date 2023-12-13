using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public class Tree
    {
        public Node ?rootNode;

        public Tree() 
        {

        }

        public Node InsertValue(Node currentNode, int newValue) 
        {
            Node temp = new Node(newValue);

            //If this is the 1st item, then it is root
            if (rootNode == null)
            {
                rootNode = temp;
            }
            else
            {
                if (currentNode == null)
                {
                    currentNode = temp;
                }

                if (temp.value < currentNode.value)
                {
                    if (currentNode.leftNode == null)
                    {
                        currentNode.leftNode = InsertValue(currentNode.leftNode, temp.value);
                    }
                    else
                    {
                        InsertValue(currentNode.leftNode, temp.value);
                    }
                }

                if (temp.value > currentNode.value)
                {
                    if (currentNode.rightNode == null)
                    {
                        currentNode.rightNode = InsertValue(currentNode.rightNode, temp.value);
                    }
                    else
                    {
                        InsertValue(currentNode.rightNode, temp.value);
                    }
                }
            }   
            
            return temp;
        }

        public bool ContainsValue(int checkValue) 
        {
            Node temp = InOrderSearch(rootNode, checkValue);
            if (temp.value == checkValue)
            {
                return true;
            }
            return false;
        }

        private Node InOrderSearch(Node startingNode, int searchValue)
        {
            Node temp = null;
            bool found;

            if (startingNode.leftNode != null)
            {
                temp = InOrderSearch(startingNode.leftNode, searchValue);
            }

            //Reads node-value when LEFT = Null;
            temp = startingNode;
            Console.WriteLine($"Value: {temp.value}");

            if (temp.value == searchValue)
            {
                Console.WriteLine("Found Node");
                return temp;
            }

            if (startingNode.rightNode != null)
            {
                temp = InOrderSearch(startingNode.rightNode, searchValue);
                if (temp.value == searchValue)
                {
                    Console.WriteLine("Found Node");
                    return temp;
                }
            }

            return temp;
        }
    }
}
