using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTraversalBfsDfs
{
    static class DFS_Traversal
    {
        public static void dfs_traversal(Node node)
        {
            if (node == null)
                return;
            Console.Write(node.data + " ");
            dfs_traversal(node.left);
            dfs_traversal(node.right);

        }
    }
}
