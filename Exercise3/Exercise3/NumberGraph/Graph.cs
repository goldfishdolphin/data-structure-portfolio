using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
 // list of graphnodes in the graph
    internal class Graph
    {
        private LinkedList<GraphNode> nodes;

        // constructor
        // set the list of the nodes in the graph to be the empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        //Method
        //Add new node in the graph
        public void AddNode(int id)
        {
            nodes.AddLast(new GraphNode(id));
        }

        // Get a specific graphnode from the graph
        public GraphNode GetNodeByID(int id)
        {
            foreach(GraphNode n in nodes)
            {
                if (id == n.ID)
                    return n;
            }
            return null;
        }

        //Add a directed edge between two nodes
        public void AddEdge(int from, int to)
        {
            // get the graphnode with the id from
            GraphNode node1 = GetNodeByID(from);
            //get the graphnode with the id to
            GraphNode node2 = GetNodeByID(to);

            // add edge from node 1 to node 2
            node1.AddEdge(node2);

        }

      
        // get number of nodes in a graph
        public int GetNumberOfNodes()
        {
            if (nodes!= null)
            {
                int count = nodes.Count;
                return count;
            }
            else
            {
                return 0;
            }
        }

        // get number of edges
        public int GetEdgeCount()
        {
            int edgeCount = 0;
            foreach (GraphNode node in nodes)
                if(node!= null)
                {
                    edgeCount += node.GetAdjList().Count;
                }
            
            return edgeCount;
        }

        public void BreadthFirstTraverse(int startID, ref List <int> visited)
        {
            LinkedList<int> adjNodesOfCurrentNode;
            Queue<int> toVisit = new Queue<int>();
            toVisit.Enqueue(startID);
            int currentID;


            while (toVisit.Count != 0) {
                // Get id at the front of the queue
                currentID = toVisit.Peek();
                // remove the id at the head of the queue
                toVisit.Dequeue();
                // add current id to the visited list
                visited.Add(currentID);
                
                // get the current node given by the current id
                GraphNode currentNode = GetNodeByID(currentID);

                if(currentNode!= null)
                {
                    //get the adjacent list of the current node.
                    adjNodesOfCurrentNode= currentNode.GetAdjList();

                    // add nodes to visit queue if they are not in visited list or toVisit queue
                    foreach(int adjNodeID in adjNodesOfCurrentNode)
                    {
                        if(!visited.Contains(adjNodeID)&& !toVisit.Contains(adjNodeID))
                        {
                            toVisit.Enqueue(adjNodeID);
                        }
                    }

                }

            }

        }
    }
}
