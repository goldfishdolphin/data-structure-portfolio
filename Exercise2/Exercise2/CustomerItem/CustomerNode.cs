 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.CustomerItem
{
    internal class CustomerNode
    {
        // members
        private Customer data;
        public CustomerNode Left, Right;


        // constructor
        public CustomerNode(Customer customer)
        {
            data = customer;
            Left = null;
            Right = null;
        }

        // property
        public Customer Data
        {
            set { data = value; }
            get { return data; }
        }


    }
}

