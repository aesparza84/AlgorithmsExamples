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
        public bool ContainsValue(int checkValue)
        {
            //Iterate through Tree to see if we already
            //stored this value
            return true;
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
    }
}
