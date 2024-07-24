using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExcercise3
{
    internal class GraphNode
    {
        private int id;

        private LinkedList<int> adjList;

        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>();

        }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }

        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.ID);
        }

    }
}
