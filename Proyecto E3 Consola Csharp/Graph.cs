using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_E3_Consola_Csharp
{
    internal class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int vertex)
        {
            adjacencyList[vertex] = new List<int>();
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
            adjacencyList[destination].Add(source);
        }

        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList.Keys)
            {
                Console.Write($"{vertex}: ");
                foreach (var neighbor in adjacencyList[vertex])
                {
                    Console.Write($"{neighbor} ");
                }
                Console.WriteLine();
            }
        }
    }
}
