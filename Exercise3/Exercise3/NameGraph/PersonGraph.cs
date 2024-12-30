using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.NameGraph
    {
        // list of graphnodes in the graph
        internal class PersonGraph
        {
            private LinkedList<PersonGraphNode> friends;

            // constructor
            // set the list of the nodes in the graph to be the empty list
            public PersonGraph()
            {
              friends = new LinkedList<PersonGraphNode>();
            }

            //Method
            //Add new node in the graph
            public void AddFriendNode(string name)
            {
                friends.AddLast(new PersonGraphNode(name));
            }

            // Get a specific graphnode  friend given the name from the graph
        public PersonGraphNode GetNodeByName(string name)
        {
            foreach (PersonGraphNode friend in friends)
            {
                if (name == friend.Name)
                    return friend;
            }
            return null;
        }


        //Add a directed edge between two nodes
        public void AddFriendEdge(string from, string to)
            {
                // get the graphnode with the name from
                PersonGraphNode person1 = GetNodeByName(from);
                //get the graphnode with the name to
                PersonGraphNode person2 = GetNodeByName(to);

                // add edge from person 1 to person 2
                person1.AddFriendEdge(person2);

            }

            //Check if graph is empty
            public bool IsEmptyGraph()
            {
                int count = friends.Count;
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public int GetNumberOfFriendsNodes()
            {
                int count = friends.Count;
                return count;
            }

            public int GetFriendEdgeCount()
            {
                int edgeCount = 0;
                foreach (PersonGraphNode friend in friends)
                    if (friend != null)
                    {
                        edgeCount += friend.GetAdjFriendList().Count;
                    }

                return edgeCount;
            }

            
            public void DisplayAdjNodes(string inputName)
            {
                LinkedList<string> adjList = new LinkedList<string>();
                PersonGraphNode n = GetNodeByName(inputName);
                if(n!= null)
                {
                    adjList = n.GetAdjFriendList();

                    foreach (string node in adjList)
                    {
                        Console.WriteLine("Adjacent Friend of "+inputName+ ": " + node);
                    }
                    Console.WriteLine(" Edge Count: " + adjList.Count);
                }
            }

        // Store the names of people in a network using Breadth First Traverse method
        public void BreadthFirstTraverse(string startName, ref List<string> visited)
            {
                LinkedList<string> adjNodesOfCurrentPerson;
                Queue<string> toVisitFriends = new Queue<string>();
                toVisitFriends.Enqueue(startName);
                string currentPerson;


                while (toVisitFriends.Count != 0)
                {
                    // Get person at the front of the queue
                    currentPerson = toVisitFriends.Peek();
                    // remove the id at the head of the queue
                    toVisitFriends.Dequeue();
                    // add current id to the visited list
                    visited.Add(currentPerson);

                    // get the current node given by the current name
                    PersonGraphNode currentNode = GetNodeByName(currentPerson);

                    if (currentNode != null)
                    {
                        //get the adjacent list of the current node.
                        adjNodesOfCurrentPerson = currentNode.GetAdjFriendList();

                        // add nodes to visit queue if they are not in visited list or toVisit queue
                        foreach (string adjNodePerson in adjNodesOfCurrentPerson)
                        {
                            if (!visited.Contains(adjNodePerson) && !toVisitFriends.Contains(adjNodePerson))
                            {
                                toVisitFriends.Enqueue(adjNodePerson);
                            }
                        }

                    }

                }

            }

        // Check if it is possible to traverse the network between two people in the network.
        public bool isTraversableNetwork(string person1, string person2)
        {
            List<string> visitedFriendsBFT = new List<string>();
            BreadthFirstTraverse( person1, ref visitedFriendsBFT);
            if (visitedFriendsBFT.Contains(person2)){
                return true;
            }
            else
            {
                return false;
            }
        }

        }

    }


