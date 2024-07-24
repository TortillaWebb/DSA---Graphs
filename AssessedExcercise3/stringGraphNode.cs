using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExcercise3
{
    internal class stringGraphNode
    {
        private string name;
        private LinkedList<string> adjList;

        public stringGraphNode(string name)
        {
            this.name = name;
            adjList = new LinkedList<string>();
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public LinkedList<string> getAdjList()
        { return adjList; }

        public void AddEdge(stringGraphNode to)
        {
            adjList.AddLast(to.Name);
        }
    }
}

