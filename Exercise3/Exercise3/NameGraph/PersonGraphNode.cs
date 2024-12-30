using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.NameGraph
{
    internal class PersonGraphNode
    {

        private string name; // data stored in the node. ​

        private LinkedList<string> adjFriendList; // list of the names of the people that are adjacent in a social network​

        //constructor
        public PersonGraphNode(string name)
        {
            this.name = name;
            adjFriendList = new LinkedList<string>();
        }

        // set and get properties from the node
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        // add edge from this node to an adjacent node 'to'
        public void AddFriendEdge(PersonGraphNode to)
        {
            if(to != null) // do not add the people to edge, who do not exist in the nodes
            {
                adjFriendList.AddLast(to.Name);
            } 
        }

        // return the adjecent list of the nodes to visit
        public LinkedList<string> GetAdjFriendList()
        {
            return adjFriendList;
        }
    }
}

