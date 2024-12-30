using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.CustomerItem
{
    internal class CustomerBinTree
    {
        private CustomerNode root;
        private string keySearch;
        string formattedStringInO;
        string formattedStringPreO;
        string formattedStringPostO;
        StringBuilder sbInO = new StringBuilder();
        StringBuilder sbPreO = new StringBuilder();
        StringBuilder sbPostO = new StringBuilder();
        
        public CustomerBinTree() //create an empty tree
        {
            root = null;
        }
        public CustomerBinTree(CustomerNode root) //create a tree with a node as the root
        {
            this.root = root;
        }


        // properties
        public string KeySearch
        {
            set { keySearch = value; }
            get { return keySearch; }
        }

        //starts recursive InOrder at root node
        public string InOrder()
        {
            inOrder(root);

            return formattedStringInO;
        }
        private void inOrder(CustomerNode tree)
        {
            if (tree != null) //not empty

            {
                inOrder(tree.Left);
                sbInO.Append(tree.Data.CustomerName).Append(", "); // build a string of customers' name inserted into a tree
                formattedStringInO = sbInO.ToString().Remove(sbInO.Length - 2); // remove last 2 char "," and blank space at the end of the string
                inOrder(tree.Right);
            }
        }

        //starts recursive PreOrder at root node
        public string PreOrder() 

        {  
         preOrder(root);
          return formattedStringPreO;
        }

        private void preOrder(CustomerNode tree)
        {
            if (tree != null) //not empty

            {
                sbPreO.Append(tree.Data.CustomerName).Append(", "); // build a string of customers' name inserted into a tree
                formattedStringPreO = sbPreO.ToString().Remove(sbPreO.Length - 2); // remove last 2 char "," and blank space at the end of the string
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }

        //starts recursive PreOrder at root node
        public string PostOrder() 

        {
          postOrder(root);
          return formattedStringPostO;
        }

        
        private void postOrder(CustomerNode tree)
        {
            if (tree != null) //not empty

            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                sbPostO.Append(tree.Data.CustomerName).Append(", "); // build a string of customers' name inserted into a tree
                formattedStringPostO = sbPostO.ToString().Remove(sbPostO.Length - 2); // remove last 2 char "," and blank space at the end of the string
            }
        }

        // insert a customer to the customer tree
        private void insertItem(Customer customer, ref CustomerNode tree)
        {
            if (tree == null)
            {
                tree = new CustomerNode(customer);
            }
            else if (customer.CompareTo(tree.Data) < 0)
            {
                insertItem(customer, ref tree.Left);
            }
            else if (customer.CompareTo(tree.Data) > 0)
            {
                insertItem(customer, ref tree.Right);
            }
        }

        public void InsertItem(Customer customer)
        {
            insertItem(customer, ref root);
        }
        public int Count()
        {
            return count(root);
        }

        //count number of customer nodes
        public int count(CustomerNode tree)
        {
            if (tree == null)
                return 0;
            return count(tree.Left) + count(tree.Right) + 1;
        }


        // searches customer given the name
        private string searchCustomer(ref CustomerNode tree, string KeySearch) {
            if (tree == null)
            {
                return "Customer Not found";
            }
            else if (KeySearch.CompareTo(tree.Data.CustomerName) < 0)
                {
                   return searchCustomer(ref tree.Left, KeySearch);
                } else if (KeySearch.CompareTo(tree.Data.CustomerName) > 0)
                {
                   return searchCustomer(ref tree.Right,KeySearch);
                }
                
                    return tree.Data.GetInformation();
                }
        

        public string SearchCustomer()
        {
            return searchCustomer(ref root, KeySearch);
        }



        // reset the string value

        public void resetInOrderString()
        {
            sbInO.Clear();
        }
        public void resetPreOrderString()
        {
            sbPreO.Clear();
        }
        public void resetPostOrderString()
        {
            sbPostO.Clear();
        }

    }
}
