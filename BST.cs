using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BST
    {
        //member variables
        Node root = null;
        //Constructor


        public void Add(int item)
        {
            Node node = new Node(item);

            if (root == null)
            {
                root = node;
                return;
            }             

            else
            {
                Node parent = root;
            
                if (item > parent.data)
                {
                    if (parent.right == null)
                    {
                        parent.right = new Node(item);
                    }

                }
                else
                {
                    if (parent.left == null)
                    {
                        parent.left = new Node(item);
                    }

                }
            }
        }

        


    }
}
