# data-structure-portfolio

## Exercise 1 - Customrers' Queue
Create a windows form application in Visual Studio for C# (.NET framework). Implement a class Customer that contains name, age, address and amountOwed in pounds sterling of the student (assume the name and address are string, age is int and amountOwed is a float, remember 5.99f  represents a float value).  Customer class should also implement appropriate properties (get / set methods) in the class Customer.  

Also add in the class Customer a method, GetInformation()
   public string GetInformation()
  {
         // to be completed
  }

that returns a string containing all the information of the customer (concatenation of name, age, address and amountOwed). 
Create an array-backed Queue class of type Customer, needs to have methods : Enqueue, Dequeue, Peek.
Add a windows form that allows :
1.	new customer details to be entered and a new customer to be added to the Queue (enqueue).
2.	display the number of customers in the queue.
3.	remove the next customer and display their details (dequeue).
4.	display the total amount owed by all customers in the queue.
5.	display the amount and details of the customer who owes the maximum amount in the queue.
6.	Make the Queue a circular queue, retaining the functionality above.


## Exercise 2 - Binary Search Tree
Create a C# windows form application to maintain a binary search tree of type int. Your windows application should allow 
1.	a new item (int) to be inserted in the tree 
2.	total number of items in tree to be displayed
3.	items in tree to be traversed using PreOrder, InOrder and PostOrder and displayed  
4.	Alter your tree and windows form to store Customer objects (re-use the class from Assessed Exercise 1) and ammend your form to allow customer details to be entered.  The number of items in the tree should be retained.
5.	Add functionality to allow retrieval of a customers details by providing a name. 


## Exercise 3 - Graph
Create a console application to test the GraphNode and Graph class. Add (and test) graph methods to :
1.	return the number of nodes in a graph  
2.	return the number of edges in a graph
3.	return a list of visited id’s generated by a BreadthFirstSearch
4.	amend your graph to store people’s names (string rather than id) and construct the social network (below) and test it using your BreadthFirstSearch method. Each connection shows a one-way friendship from one person to another.
5.	Add a method to return true if its possible to traverse (friend of friends …) between 2 people in the network, false otherwise.

