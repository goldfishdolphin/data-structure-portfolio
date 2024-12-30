using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.IntegerItem
{
    internal class Node
    {
        // members
        private int data;
        public Node Left, Right;
       

        // constructor
        public Node (int item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        // property
        public int Data
        {
            set { data = value; }
            get { return data; }
        }
        
    }
}
