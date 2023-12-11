using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_E3_Consola_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista Enlazada
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            Console.WriteLine("Linked List:");
            foreach (var item in linkedList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Pila
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("\nStack:");
            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();

            // Cola
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("\nQueue:");
            while (queue.Count > 0)
            {
                Console.Write($"{queue.Dequeue()} ");
            }
            Console.WriteLine();

            // Árbol Binario
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);

            Console.WriteLine("\nBinary Tree (Inorder Traversal):");
            InorderTraversal(root);
            Console.WriteLine();

            // Grafo No Dirigido
            Graph graph = new Graph();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);

            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);

            Console.WriteLine("\nGraph Representation:");
            graph.PrintGraph();

            Console.ReadKey();
        }

        static void InorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                Console.Write($"{node.Value} ");
                InorderTraversal(node.Right);
            }
        }
    }
}
