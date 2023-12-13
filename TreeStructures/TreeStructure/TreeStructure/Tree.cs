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
                Console.WriteLine("Found Node");
                return true;
            }
            Console.WriteLine("Couldn't Find Node");
            return false;
        }

        /// <summary>
        /// 
        /// Follows the LNR (Left-child, Node, Right-child) search pattern.
        /// From the root, we go down each Node's left child value until there are
        /// no more left-children. We then check the parent node's value, and then 
        /// the right child value. 
        /// 
        /// If we didn't find the desired value, then we move
        /// back up to the next parent and repeat this process throughout the ENTIRE
        /// tree until the end. 
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="startingNode"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        private Node InOrderSearch(Node startingNode, int searchValue)
        {
            Node temp = null;

            if (startingNode.leftNode != null)
            {
                temp = InOrderSearch(startingNode.leftNode, searchValue);
                if (temp.value == searchValue)
                {
                    //Found Node
                    return temp;
                }
            }

            //Reads node-value when LEFT = Null; (When node is considered Parent)
            temp = startingNode;
            Console.WriteLine($"Value: {temp.value}");

            if (temp.value == searchValue)
            {
                //Found Node
                return temp;
            }

            if (startingNode.rightNode != null)
            {
                temp = InOrderSearch(startingNode.rightNode, searchValue);
                if (temp.value == searchValue)
                {
                    //Found Node
                    return temp;
                }
            }

            return temp;
        }
    }
}
