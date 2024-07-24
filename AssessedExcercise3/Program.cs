using System.Collections.Generic;
using System;
using Microsoft.Win32;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExcercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Graph intGraph = new Graph();

            intGraph.AddNode(1);
            intGraph.AddNode(2);
            intGraph.AddNode(3);
            intGraph.AddNode(4);
            intGraph.AddNode(5);
            intGraph.AddNode(6);
            intGraph.AddNode(7);

            intGraph.AddEdge(1, 2);
            intGraph.AddEdge(1, 4);
            intGraph.AddEdge(1, 6);
            intGraph.AddEdge(2, 6);
            intGraph.AddEdge(2, 3);
            intGraph.AddEdge(3, 5);
            intGraph.AddEdge(5, 7);
            intGraph.AddEdge(6, 7);

            bool isEmpty = intGraph.isEmptyGraph();
            if (isEmpty == true)
            {
                Console.WriteLine("Int Graph is empty");
            }
            else
            {
                Console.WriteLine("Int Graph is not empty");
            }

            Console.WriteLine("Test GetNodeByID method" + intGraph.GetNodeByID(1).ID);

            intGraph.DisplayAdjNodes(1);

            bool IDPresent = intGraph.ContainsGraph(8);
            Console.WriteLine("ID Present = " + IDPresent);

            bool isAdjacent = intGraph.IsAdjacent(1, 3);
            if (isAdjacent == true)
            {
                Console.WriteLine("3 is adjacent to 1");
            }
            else
            {
                Console.WriteLine("3 is not adjacent to 1");
            }

            int totalEdges = intGraph.edgeCount();
            Console.WriteLine("There are: " + totalEdges + " edges in the graph. :) ");

            Console.WriteLine("ID's visited in BFS Graph 3 search from 1 = " + intGraph.IdsVisited(1));
            LinkedList<int> IDs = intGraph.IdsVisited(1);
            foreach (int n in IDs)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("ID's visited in BFS Graph 3 search from 2 = " + intGraph.IdsVisited(2));
            LinkedList<int> IDs1 = intGraph.IdsVisited(2);
            foreach (int n in IDs1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("ID's visited in BFS Graph 3 search from 3 = " + intGraph.IdsVisited(3));
            LinkedList<int> IDs2 = intGraph.IdsVisited(3);
            foreach (int n in IDs2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("ID's visited in BFS Graph 3 search from 4 = " + intGraph.IdsVisited(4));
            LinkedList<int> IDs3 = intGraph.IdsVisited(4);
            foreach (int n in IDs3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("ID's visited in BFS Graph 3 search from 5 = " + intGraph.IdsVisited(5));
            LinkedList<int> IDs4 = intGraph.IdsVisited(5);
            foreach (int n in IDs4)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("ID's visited in BFS Graph 3 search from 6 = " + intGraph.IdsVisited(6));
            LinkedList<int> IDs5 = intGraph.IdsVisited(6);
            foreach (int n in IDs5)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("ID's visited in BFS Graph 3 search from 7 = " + intGraph.IdsVisited(7));
            LinkedList<int> IDs6 = intGraph.IdsVisited(7);
            foreach (int n in IDs6)
            {
                Console.WriteLine(n);
            }




            stringGraph nameGraph = new stringGraph();

            bool IsEmptyTest = nameGraph.isEmptyGraph();
            if (IsEmptyTest == true)
            {
                Console.WriteLine("Name Graph is empty");
            }
            else
            {
                Console.WriteLine("Name Graph is not empty");
            }

            nameGraph.AddNode("Dave");
            nameGraph.AddNode("Peggy");
            nameGraph.AddNode("Rabia");
            nameGraph.AddNode("Anwar");
            nameGraph.AddNode("Rob");
            nameGraph.AddNode("Haniy");

            nameGraph.AddEdge("Dave", "Peggy");
            nameGraph.AddEdge("Peggy", "Rabia");
            nameGraph.AddEdge("Peggy", "Rob");
            nameGraph.AddEdge("Rob", "Haniy");
            nameGraph.AddEdge("Rabia", "Anwar");
            nameGraph.AddEdge("Anwar", "Rob");
            nameGraph.AddEdge("Anwar", "Dave");


            bool IsEmpty = nameGraph.isEmptyGraph();
            if (IsEmpty == true)
            {
                Console.WriteLine("Name Graph is empty");
            }
            else
            {
                Console.WriteLine("Name Graph is not empty");
            }

            Console.WriteLine("Test GetNodeByName method " + nameGraph.GetNodeByName("Rob").Name);
            Console.WriteLine("Testing adjacent nodes to Dave");
            nameGraph.DisplayAdjNodes("Dave");
            Console.WriteLine("Testing adjacent nodes to Peggy");
            nameGraph.DisplayAdjNodes("Peggy");
            Console.WriteLine("Testing adjacent nodes to Haniy");
            nameGraph.DisplayAdjNodes("Haniy");   // write message for no adjacencies in DisplayAdjNodes() 
            Console.WriteLine("Testing adjacent nodes to Anwar");
            nameGraph.DisplayAdjNodes("Anwar");

            bool NamePresent = nameGraph.ContainsGraph("Rob");
            Console.WriteLine("Name Present = " + NamePresent);

            bool namePresent = nameGraph.ContainsGraph("Tia");
            Console.WriteLine("Name Present = " + namePresent);

            bool IsAdjacent = nameGraph.IsAdjacent("Dave", "Peggy");
            if (IsAdjacent == true)
            {
                Console.WriteLine("Dave is adjacent to Peggy");
            }
            else
            {
                Console.WriteLine("Dave is not adjacent to Peggy");
            }

            bool IsAdjacentt = nameGraph.IsAdjacent("Dave", "Haniy");
            if (IsAdjacentt == true)
            {
                Console.WriteLine("Dave is adjacent to Haniy");
            }
            else
            {
                Console.WriteLine("Dave is not adjacent to Haniy");
            }

            int edgeTotal = nameGraph.edgeCount();
            Console.WriteLine("Total edges in name graph = " + edgeTotal);

            Console.WriteLine("Names visited in BFS NameGraph search (starting with Dave) = ");
            LinkedList<string> names = nameGraph.NamesVisited("Dave");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Names visited in BFS NameGraph search (starting with Haniy) = ");
            LinkedList<string> Names = nameGraph.NamesVisited("Haniy");
            foreach (string n in Names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Names visited in BFS NameGraph search (starting with Rob) = ");
            LinkedList<string> Names2 = nameGraph.NamesVisited("Rob");
            foreach (string n in Names2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Names visited in BFS NameGraph search (starting with Anwar) = ");
            LinkedList<string> Names3 = nameGraph.NamesVisited("Anwar");
            foreach (string n in Names3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Names visited in BFS NameGraph search (starting with Peggy) = ");
            LinkedList<string> Names4 = nameGraph.NamesVisited("Peggy");
            foreach (string n in Names4)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Names visited in BFS NameGraph search (starting with Rabia) = ");
            LinkedList<string> Names5 = nameGraph.NamesVisited("Rabia");
            foreach (string n in Names5)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Testing traverse status from Dave to Haniy");
            bool canTraverse = nameGraph.TraverseCheck("Dave", "Haniy");
            Console.WriteLine(canTraverse);

            Console.WriteLine("Testing traverse status from Haniy to Dave");
            bool canTraverse2 = nameGraph.TraverseCheck("Haniy", "Dave");
            Console.WriteLine(canTraverse2);

            Console.WriteLine("Testing traverse status from Rob to Dave");
            bool canTraverse3 = nameGraph.TraverseCheck("Rob", "Dave");
            Console.WriteLine(canTraverse3);

            Console.WriteLine("Testing traverse status from Peggy to Dave");
            bool canTraverse4 = nameGraph.TraverseCheck("Peggy", "Dave");
            Console.WriteLine(canTraverse4);

            Console.WriteLine("Testing traverse status from Dave to Rabia");
            bool canTraverse5 = nameGraph.TraverseCheck("Dave", "Rabia");
            Console.WriteLine(canTraverse5);

            Console.WriteLine("Testing traverse status from Dave to Anwar");
            bool canTraverse6 = nameGraph.TraverseCheck("Dave", "Anwar");
            Console.WriteLine(canTraverse6);

            Console.WriteLine("Testing traverse status from Dave to Rob");
            bool canTraverse7 = nameGraph.TraverseCheck("Dave", "Rob");
            Console.WriteLine(canTraverse7);

            Console.WriteLine("Testing traverse status from Peggy to Haniy");
            bool canTraverse8 = nameGraph.TraverseCheck("Peggy", "Haniy");
            Console.WriteLine(canTraverse8);

            Console.WriteLine("Testing traverse status from Peggy to Anwar");
            bool canTraverse9 = nameGraph.TraverseCheck("Peggy", "Anwar");
            Console.WriteLine(canTraverse9);

            Console.WriteLine("Testing traverse status from Rabia to Dave");
            bool canTraverse10 = nameGraph.TraverseCheck("Rabia", "Dave");
            Console.WriteLine(canTraverse10);

            Console.WriteLine("Testing traverse status from Rabia to Rob");
            bool canTraverse11 = nameGraph.TraverseCheck("Rabia", "Rob");
            Console.WriteLine(canTraverse11);

            Console.WriteLine("Testing traverse status from Rabia to Haniy");
            bool canTraverse12 = nameGraph.TraverseCheck("Rabia", "Haniy");
            Console.WriteLine(canTraverse12);

            Console.WriteLine("Testing traverse status from Rabia to Peggy");
            bool canTraverse13 = nameGraph.TraverseCheck("Rabia", "Peggy");
            Console.WriteLine(canTraverse13);

            Console.WriteLine("Testing traverse status from Anwar to Peggy");
            bool canTraverse14 = nameGraph.TraverseCheck("Anwar", "Peggy");
            Console.WriteLine(canTraverse14);

            Console.WriteLine("Testing traverse status from Anwar to Rabia");
            bool canTraverse15 = nameGraph.TraverseCheck("Anwar", "Rabia");
            Console.WriteLine(canTraverse15);

            Console.WriteLine("Testing traverse status from Anwar to Haniy");
            bool canTraverse17 = nameGraph.TraverseCheck("Anwar", "Haniy");
            Console.WriteLine(canTraverse17);

            Console.WriteLine("Testing traverse status from Rob to Anwar");
            bool canTraverse18 = nameGraph.TraverseCheck("Rob", "Anwar");
            Console.WriteLine(canTraverse18);

            Console.WriteLine("Testing traverse status from Haniy to Dave");
            bool canTraverse19 = nameGraph.TraverseCheck("Haniy", "Dave");
            Console.WriteLine(canTraverse19);

            Console.WriteLine("Testing traverse status from Dave to Dave");
            bool canTraverse20 = nameGraph.TraverseCheck("Dave", "Dave");
            Console.WriteLine(canTraverse20);

            Console.WriteLine("Testing traverse status from Peggy to Peggy");
            bool canTraverse21 = nameGraph.TraverseCheck("Peggy", "Peggy");
            Console.WriteLine(canTraverse21);

            Console.WriteLine("Testing traverse status from Rabia to Rabia");
            bool canTraverse22 = nameGraph.TraverseCheck("Rabia", "Rabia");
            Console.WriteLine(canTraverse22);

            Console.WriteLine("Testing traverse status from Anwar to Anwar");
            bool canTraverse23 = nameGraph.TraverseCheck("Anwar", "Anwar");
            Console.WriteLine(canTraverse23);

            Console.WriteLine("Testing traverse status from Rob to Rob");
            bool canTraverse24 = nameGraph.TraverseCheck("Rob", "Rob");
            Console.WriteLine(canTraverse24);

            Console.WriteLine("Testing traverse status from Haniy to Haniy");
            bool canTraverse25 = nameGraph.TraverseCheck("Haniy", "Haniy");
            Console.WriteLine(canTraverse25);

            Console.ReadKey();
        }
    }
}
