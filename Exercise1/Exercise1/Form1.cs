using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        // declare the queue of the customers that can be used in the form
        readonly CustomerQueue myqueue = new CustomerQueue();
        public Form1()
        {
            InitializeComponent();   
        }




        private void PeekButton_Click(object sender, EventArgs e)
        {
            if (myqueue.IsEmpty())
            {
                DisplayTextbox.Text = "No Customer in the queue";
            }
            else
            {
                DisplayTextbox.Text = "The first person in the queue: \n" + myqueue.Peek().GetInformation();
            }
           
        }

        private void EnqueueButton_Click(object sender, EventArgs e)
        {
            string customer_name = nameTextBox.Text;

            string customer_address = addressTextBox.Text;

            int age = Int32.Parse(ageTextBox.Text);

       float amount_owed = float.Parse(amountTextBox.Text);
            if (!myqueue.IsFull()&& (!string.IsNullOrWhiteSpace(customer_name) && !string.IsNullOrWhiteSpace(customer_address) && !string.IsNullOrWhiteSpace(ageTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text)))
            {
                Customer customer = new Customer(customer_name, customer_address, age, amount_owed);
                myqueue.Enqueue(customer);
                DisplayTextbox.Text = "Customer added to the queue:  \n" + customer.GetInformation();
            }
            else
            {
                DisplayTextbox.Text = "The queue is full and no more customer can be added to the queue.";
            }
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            ageTextBox.Text = "";
            amountTextBox.Text = "";
        }

        private void DequeueButton_Click(object sender, EventArgs e)
        {
            if (myqueue.IsEmpty())
            {
                DisplayTextbox.Text = "No Customer in the Queue to be removed!";
            }
            else
            {
                DisplayTextbox.Text = "The person removed from the head of the queue: \n" + myqueue.Dequeue().GetInformation();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayTextbox.Text = "";
        }

        private void totalCustomerButton_Click(object sender, EventArgs e)
        {
            customerNoTextBox.Text = myqueue.CustomersCount.ToString();
        }

        private void totalAmountButton_Click(object sender, EventArgs e)
        {
            totalAmountTextBox.Text = myqueue.GetTotalOwedAmount().ToString();
        }

        private void maxAmountButton_Click(object sender, EventArgs e)
        {
            if (myqueue.IsEmpty())
            {
                maxAmountTextBox.Text = "No customer in the queue.";
            }
            else
            {
                maxAmountTextBox.Text = myqueue.MaxAmountOwed();
            }
       
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tailTextBox.Text = myqueue.Tail.ToString();
        }

        private void headButton_Click(object sender, EventArgs e)
        {
            headTextBox.Text = myqueue.Head.ToString();
        }


        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid number for age");
            }
        }

        private void amountTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid number for amount");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tailTextBox.Text = "";
            maxAmountTextBox.Text = "";
            headTextBox.Text = "";
            customerNoTextBox.Text = "";
            totalAmountTextBox.Text = "";

        }
    }
}
