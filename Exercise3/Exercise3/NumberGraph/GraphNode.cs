
using System.Collections.Generic;


namespace Exercise3
{
    // class for the node of the graph
    internal class GraphNode
    {
        private int id; // data stored in the node. ​

        private LinkedList<int> adjList; // list of the ids of the nodes that are adjacent​

        //constructor
        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>();
        }

        // set and get properties from the node
        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        // add edge from this node to an adjacent node 'to'
        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.ID);
        }

        // return the adjecent list of the nodes to visit
        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }
    }
}
