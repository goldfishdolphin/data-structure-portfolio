using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise2.IntegerItem
{
    internal class BinaryTree

    {
        // member
        private Node root;
        string formattedStringInOrder;
        string formattedStringPreOrder;
        string formattedStringPostOrder;
        StringBuilder sbInOrder = new StringBuilder();
        StringBuilder sbPreOrder = new StringBuilder();
        StringBuilder sbPostOrder = new StringBuilder();


        public BinaryTree() // create an empty tree with no root
        {
            root = null;
        }

        public BinaryTree(Node node) // creates a tree using node as a root
        {
            root = node;
        }

        // methods 
        // insert a number to the tree
        private void insertItem(int item, ref Node tree)
        {
            if (tree == null)
                tree = new Node(item);
            else if (item < tree.Data)
                insertItem(item, ref tree.Left);
            else if (item > tree.Data)
                insertItem(item, ref tree.Right);
        }
        public void InsertItem(int item)
        { insertItem(item, ref root); }




        // PreOrder Traversal
        public string PreOrder()
        {
            preOrder(root);

            return formattedStringPreOrder;
        }
        private void preOrder(Node tree)
        {
            if (tree != null)
            {
                sbPreOrder.Append(tree.Data).Append(", "); // build a string of numbers inserted into a tree
                formattedStringPreOrder = sbPreOrder.ToString().Remove(sbPreOrder.Length - 2); // remove last 2 char "," and blank space at the end of the string
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }


        // InOrder Traversal
        public string InOrder()
        {
            inOrder(root);

            return formattedStringInOrder;
        }
        private void inOrder(Node tree)
        {
            if (tree != null)
            {
                inOrder(tree.Left);
                sbInOrder.Append(tree.Data).Append(", "); // build a string of numbers inserted into a tree
                formattedStringInOrder = sbInOrder.ToString().Remove(sbInOrder.Length - 2); // remove last 2 char "," and blank space at the end of the string
                inOrder(tree.Right);
            }
        }

        //PostOrder Traversal
        public string PostOrder()
        {
            postOrder(root);

            return formattedStringPostOrder;
        }
        private void postOrder(Node tree)
        {
            if (tree != null)
            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                sbPostOrder.Append(tree.Data).Append(", "); // build a string of numbers inserted into a tree
                formattedStringPostOrder = sbPostOrder.ToString().Remove(sbPostOrder.Length - 2); // remove last 2 char "," and blank space at the end of the string;
            }
        }

        // reset the string value

        public void resetInOrderString()
        {
            sbInOrder.Clear();
        }
        public void resetPreOrderString()
        {
            sbPreOrder.Clear();
        }
        public void resetPostOrderString()
        {
            sbPostOrder.Clear();
        }

        // count the number of items in the tree
        public int Count()
        {
            return count(root);
        }
        private int count(Node tree)
        {
            if (tree == null)
                return 0;
            return count(tree.Right) + count(tree.Left) + 1;
        }

    }
}
