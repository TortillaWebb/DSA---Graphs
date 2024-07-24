using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExcercise3
{
    internal class Graph
    {
        private LinkedList<GraphNode> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        public void AddNode(int id)
        {
            GraphNode node1 = new GraphNode(id);
            nodes.AddLast(node1);
        }

        public GraphNode GetNodeByID(int id)
        {
            foreach (GraphNode n in nodes)
            {
                if (id == n.ID)
                    return n;
            }
            return null;
        }

        public void AddEdge(int from, int to)
        {
            GraphNode n1 = GetNodeByID(from);
            GraphNode n2 = GetNodeByID(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }
        }

        public bool isEmptyGraph()
        {
            int elements = nodes.Count();
            if (elements == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayAdjNodes(int inputID)
        {
            LinkedList<int> adjL = new LinkedList<int>();

            GraphNode n = GetNodeByID(inputID);
            adjL = n.GetAdjList();


            foreach (int curr in adjL)
            {
                int id = curr;
                Console.WriteLine(id);
            }
        }

        public bool ContainsGraph(int ID)
        {
            foreach (GraphNode n in nodes)
            {
                if (n.ID.Equals(ID))
                    return true;
            }
            return false;
        }

        public bool IsAdjacent(int i, int j)
        {
            GraphNode I = GetNodeByID(i);
            LinkedList<int> IAdjL = I.GetAdjList();

            if (IAdjL.Contains(j))
            {
                return true;
            }
            return false;
        }

        public int nodeCount()
        {
            int TotalNodes = nodes.Count();
            return TotalNodes;
        }

        public int edgeCount()
        {
            LinkedList<int> adjList = new LinkedList<int>();
            int edges = 0;
            int tempEdges = 0;

            foreach (GraphNode n in nodes)
            {
                adjList = n.GetAdjList();
                tempEdges = adjList.Count;
                edges += tempEdges;
            }
            return edges;
        }

        public LinkedList<int> IdsVisited(int startNode)
        {
            LinkedList<int> visited = new LinkedList<int>();
            LinkedList<int> adjList = new LinkedList<int>();
            Queue toVisit = new Queue();

            toVisit.Enqueue(startNode);

            while (toVisit.Count > 0)
            {
                int current = (int)toVisit.Peek();
                toVisit.Dequeue();
                visited.AddLast(current);
                GraphNode currentNode = GetNodeByID(current);
                adjList = currentNode.GetAdjList();

                foreach (int n in adjList)
                {
                    bool hasQueued = toVisit.Contains(n);
                    bool hasVisited = visited.Contains(n);
                    if (!hasQueued && !hasVisited)
                    {
                        toVisit.Enqueue(n);
                    }
                }

            }
            return visited;
        }

    }
}
