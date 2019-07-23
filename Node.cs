using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node
    {
        //member variables
        public int data;
        public Node left;
        public Node right;

        //constructor
        public Node()
        {

        }
        public Node(int item)
        {
            data = item;
        }
    }
}
