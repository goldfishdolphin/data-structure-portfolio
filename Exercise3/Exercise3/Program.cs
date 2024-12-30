using Exercise3.NameGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test the ID graph
            // define graph
            Graph intGraph = new Graph();
           
            //add nodes in the graph
            intGraph.AddNode(1);
            intGraph.AddNode(2);
            intGraph.AddNode(3);
            intGraph.AddNode(4);
            intGraph.AddNode(5);
            intGraph.AddNode(6);
            intGraph.AddNode(7);

            // add directed edges to the nodes
            intGraph.AddEdge(1, 2);
            intGraph.AddEdge(1, 6);
            intGraph.AddEdge(1, 4);
            intGraph.AddEdge(2, 3);
            intGraph.AddEdge(2, 6);
            intGraph.AddEdge(3, 5);
            intGraph.AddEdge(5, 7);
            intGraph.AddEdge(6, 7);


            //Check the number of nodes int the graph
            int numberOfNodes = intGraph.GetNumberOfNodes();

            // Check the number of edges in the graph
            int numberOfEdges = intGraph.GetEdgeCount();


            // TASK1
            Console.WriteLine("______________Task1________________");
            Console.WriteLine("Number of Nodes: "+numberOfNodes);

            // TASK2
            Console.WriteLine("______________Task2________________");
            Console.WriteLine("Number of Edges: " + numberOfEdges);


            // TASK3
            Console.WriteLine("______________Task3________________");
            Console.WriteLine("Breadth First Traversal of the ID Graph: ");
            List<int> visitedBFT = new List<int>();
            intGraph.BreadthFirstTraverse(1, ref visitedBFT);

            foreach(int number in visitedBFT)
            {
                Console.Write(number);
                Console.WriteLine();
            }


            // TASK4
            Console.WriteLine("______________Task4________________");
            //Test graph of friends in a network
            //define graph
            PersonGraph personGraph = new PersonGraph();

            // add friends nodes to the graph
            personGraph.AddFriendNode("Dave");
            personGraph.AddFriendNode("Anwar");
            personGraph.AddFriendNode("Hanya");
            personGraph.AddFriendNode("Rob");
            personGraph.AddFriendNode("Peggy");
            personGraph.AddFriendNode("Rabia");

            // add directed edges to the friends nodes
            personGraph.AddFriendEdge("Dave", "Anwar");
            personGraph.AddFriendEdge("Anwar", "Rob");
            personGraph.AddFriendEdge("Anwar", "Rabia");
            personGraph.AddFriendEdge("Rabia", "Peggy");
            personGraph.AddFriendEdge("Peggy", "Rob");
            personGraph.AddFriendEdge("Rob", "Hanya");
            personGraph.AddFriendEdge("Rob", "Maria"); //trying to add people who are not in the nodes

            //Check the number of nodes int the graph
            Console.WriteLine("Number of nodes in the social network: "+ personGraph.GetNumberOfFriendsNodes());
            Console.WriteLine ("Number of edges in the social network: " + personGraph.GetFriendEdgeCount());


            //Check the adjacent nodes of a person in a network
            personGraph.DisplayAdjNodes("Dave");

            // Check Social network of a person using Breadth First Traverse method
            List<string> visitedFriendsBFT = new List<string>();
            personGraph.BreadthFirstTraverse("Rob", ref visitedFriendsBFT);
            foreach (string person in visitedFriendsBFT)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }

            // TASK5
            Console.WriteLine("______________Task5________________");
            //Check it is possible to traverse between 2 people in a network.
            Console.WriteLine(personGraph.isTraversableNetwork("Dave", "Hanya"));
            Console.WriteLine(personGraph.isTraversableNetwork("Hanya", "Anwar"));



            Console.ReadKey();
        }
    }
}
