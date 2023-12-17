using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public class Node
    {
        public int value;
        public int Key; //If we had a dictionary, we would sort and search by Key-values

        public Node ?leftNode;
        public Node ?rightNode;

        public Node(int n) 
        {
            this.value = n;
        }
        public Node(int key, int n) 
        {
            this.Key = key;
            value = n;
        }

        

    }
}
