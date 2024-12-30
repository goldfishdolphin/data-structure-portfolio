using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class CustomerQueue
    {
        // members
        private readonly int maxsize = 3;
        private int head = 0;
        private int tail = 0;
        private Customer[] customersList;
        private int customersCount;

        public CustomerQueue()
        {
            customersList = new Customer[maxsize];
        }
        public CustomerQueue(int count)
        {
            maxsize = count;
            customersList = new Customer[maxsize];

        }
        //property
        // customer queue count is read only. We can get the customer count but can not set the count.
        public int CustomersCount 
        {
            get { return this.customersCount; }
        }
        public int Tail
        {
            get { return this.tail;  }
        }
        public int Head
        {
            get { return this.head; }
        }


        // methods
        // Enqueue - Add a customer at the tail of the queue
        public void Enqueue(Customer customer)
        {
            if (customersCount < maxsize)
            {
                customersCount++;
                customersList[tail] = customer;
                tail++;

                if (tail == maxsize) //Check wrap around to make a circular queue
                {
                    tail = 0;
                }
            }
        }

        // Dequeue - Remove a customer from the head of the queue
        public Customer Dequeue()
        {
            Customer headCustomer;
            customersCount--;
            headCustomer = customersList[head];
            head++;

            if(head == maxsize) //Check wrap around to make a circular queue
            {
                head = 0;
            }
            return headCustomer;
        }

        // Peek - Get a customer at the head of the queue
        public Customer Peek()
        {
            Console.WriteLine(customersList[head].CustomerName);
            return customersList[head];
        }

        // IsEmpty - Check if the the customer list is emtpy
        public bool IsEmpty()
        {

            if (customersCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // IsFull - Check if the list of the customers is full
        public bool IsFull()
        {
            if (customersCount == maxsize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        // While Loop Customer circular queue : Loop through current number of customer items
        // i = current position
        // Get current amount owed at i 
        // i ++
        // if i>= maxSize
        // Then i =0;

        // Get total ammount owed by  customers in the queue

        public float GetTotalOwedAmount()
        {
            float totalOwedAmount = 0.0f;
            if (customersList == null)
            {
                // Return 0 when customersList is null
                return totalOwedAmount;
            }
            
          
            int i = head; 
            while (true)
            {
                if (customersCount > 0)
                {

                    totalOwedAmount += customersList[i].AmountOwed;
                }
                else { totalOwedAmount += 0; }
             
              
                i++;
                if (i >= maxsize)
                {
                    i = 0; // Wrap around
                }

                if (i == tail)
                {
                    break;
                }
            }

            return totalOwedAmount;
        }



        // Get maximum owed amount and details of the customer/ customers

        public string MaxAmountOwed()
        {
            float maxAmount = 0.0f;
            int countHighestOwingCustomers = 0;
            string outputString = "";
            int i = head;

            // Get the max amount owed by the customers in the queue.
         
            while (true)
            {
                if (customersCount > 0 && customersList[i].AmountOwed > maxAmount)
                {
                    maxAmount = customersList[i].AmountOwed;
                    countHighestOwingCustomers = 1;
                    outputString = $"Customer: {customersList[i].GetInformation()}";

                }
                else if (customersCount > 0 && customersList[i].AmountOwed == maxAmount)
                {
                    countHighestOwingCustomers++;
                    outputString += $"\n Customer: {customersList[i].GetInformation()}";
                }
              
              
                i++;
                
                if (i >= maxsize)
                {
                    i = 0; // Wrap around 
                }

                if (i == tail)
                {
                    break;
                }

            }
            return outputString;
        }


    }
}