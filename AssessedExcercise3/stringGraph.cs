using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExcercise3
{
    internal class stringGraph
    {
        private LinkedList<stringGraphNode> nodes;

        public stringGraph()
        {
            nodes = new LinkedList<stringGraphNode>();
        }

        public void AddNode(string name)
        {
            stringGraphNode node1 = new stringGraphNode(name);
            nodes.AddLast(node1);
        }

        public stringGraphNode GetNodeByName(string name)
        {
            foreach (stringGraphNode n in nodes)
            {
                if (name == n.Name)
                    return n;
            }
            return null;
        }

        public void AddEdge(string from, string to)
        {
            stringGraphNode n1 = GetNodeByName(from);
            stringGraphNode n2 = GetNodeByName(to);

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

        public void DisplayAdjNodes(string inputName)
        {
            LinkedList<string> adjL = new LinkedList<string>();

            stringGraphNode n = GetNodeByName(inputName);
            adjL = n.getAdjList();


            foreach (string curr in adjL)
            {
                string name = curr;
                Console.WriteLine(name);
            }
        }

        public bool ContainsGraph(string name)
        {
            foreach (stringGraphNode n in nodes)
            {
                if (n.Name.Equals(name))
                    return true;
            }
            return false;
        }

        public bool IsAdjacent(string i, string j)
        {
            stringGraphNode I = GetNodeByName(i);
            LinkedList<string> IAdjL = I.getAdjList();

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
            LinkedList<string> adjList = new LinkedList<string>();
            int edges = 0;
            int tempEdges = 0;

            foreach (stringGraphNode n in nodes)
            {
                adjList = n.getAdjList();
                tempEdges = adjList.Count;
                edges += tempEdges;
            }
            return edges;
        }

        public LinkedList<string> NamesVisited(string startNode)
        {
            LinkedList<string> visited = new LinkedList<string>();
            LinkedList<string> adjList = new LinkedList<string>();
            Queue toVisit = new Queue();

            toVisit.Enqueue(startNode);

            while (toVisit.Count > 0)
            {
                string current = (string)toVisit.Peek();
                toVisit.Dequeue();
                visited.AddLast(current);
                stringGraphNode currentNode = GetNodeByName(current);
                adjList = currentNode.getAdjList();

                foreach (string n in adjList)
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

        public bool TraverseCheck(string from, string to)
        {
            LinkedList<string> traverseList = NamesVisited(from);
            bool canTraverse = false;

            if (traverseList.Contains(to))
                canTraverse = true;

            return canTraverse;
        }
    }
}

