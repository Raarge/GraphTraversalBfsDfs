using System;

namespace GraphTraversalBfsDfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = sample_tree();
            //Console.WriteLine("BFS --> ");
            //BFS_Traversal.bfs_traversal(tree);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\nDFS --> ");
            DFS_Traversal.dfs_traversal(tree);
        }

        private static Node sample_tree()
        {
            Node root =
                new Node("A",
                    new Node("B",
                        new Node("C"), new Node("D")),
                    new Node("E",
                        new Node("F"), new Node("G",
                                                            new Node("H"), null )));

            return root;
        }
    }
}
