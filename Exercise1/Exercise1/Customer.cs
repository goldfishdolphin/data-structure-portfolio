using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Customer
    {
        // members
        private string customer_name, address;
        private int age;
        private float amountOwed;

        // constructor
        public Customer(string customer_name, string address, int age, float amountOwed)
        {
            this.customer_name = customer_name;
            this.address = address;
            this.age = age;
            this.amountOwed = amountOwed;
        }

        // properties
        public string CustomerName
        {
            get { return this.customer_name; }
            set { this.customer_name = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public float AmountOwed
        {
            get { return this.amountOwed; }
            set { this.amountOwed = value; }
        }

        // methods
        public string GetInformation()
        {
            string information = "Customer "+this.customer_name +" is " +this.age.ToString()+ " year old.\nThey live at " + this.address+". The amount owed by them is "+this.amountOwed.ToString();
            return information;
        }

        
    }
}
