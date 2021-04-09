using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTraversalBfsDfs
{
    public class Node
    {
        public Node left;
        public Node right;
        public String data;

        public Node(string data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public Node(string data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
