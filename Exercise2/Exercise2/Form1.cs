using Exercise2.CustomerItem;
using Exercise2.IntegerItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        // declare the tree of the integers and customers that can be used in the form
        BinaryTree myTree = new BinaryTree();
        CustomerBinTree customerTree = new CustomerBinTree();
     
      
        public Form1()
        {
            InitializeComponent();
        }


        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only enter a valid integer");
            }
        }
        
        private void insertButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(inputTextBox.Text)){
                int inputItem = Int32.Parse(inputTextBox.Text);
                myTree.InsertItem(inputItem);
                inputTextBox.Text = "";
            }
            else
            {
                inputTextBox.Text = "Field cannot be left empty";
            }
           
        }

        private void inOrderButton_Click(object sender, EventArgs e)
        {
            inOrderTextBox.Text = myTree.InOrder();
            myTree.resetInOrderString();

        }

        private void postOrderButton_Click(object sender, EventArgs e)
        {
          
            postOrderTextBox.Text = myTree.PostOrder();
            myTree.resetPostOrderString();
           
        }

        private void PreOrderButton_Click(object sender, EventArgs e)
        {
       
            preOrderTextBox.Text = myTree.PreOrder();
            myTree.resetPreOrderString();
     
        }

     

        private void CountButton_Click(object sender, EventArgs e)
        {
            countTextBox.Text = myTree.Count().ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string customer_name = nameTextBox.Text.ToLower(); //store customers in lowercase to avoid duplicate insertion
            string customer_address = addressTextBox.Text;
            
           // check all values are entered before adding a customer
            if (!string.IsNullOrWhiteSpace(customer_name) && !string.IsNullOrWhiteSpace(customer_address) && !string.IsNullOrWhiteSpace(ageTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text))
            {
                int age = Int32.Parse(ageTextBox.Text);
                float amount_owed = float.Parse(amountTextBox.Text);
                Customer customer = new Customer(customer_name, customer_address, age, amount_owed);
                customerTree.InsertItem(customer);
                displayCustomerTextBox.Text = "Customer called " + char.ToUpper(customer.CustomerName[0]) + customer.CustomerName.Substring(1) + " has been added. \n " + customer.GetInformation();
                nameTextBox.Text = "";
                addressTextBox.Text = "";
                amountTextBox.Text = "";
                ageTextBox.Text = "";
                countTextBox.Text = "";
            }
            else
            {
                displayCustomerTextBox.Text = "Enter all the values. No fields can be left Empty.";
            }
        }
        

        private void countCustomerButton_Click(object sender, EventArgs e)
        {
            countCustomerTextBox.Text = customerTree.Count().ToString();
        }

        private void preOCustomerButton_Click(object sender, EventArgs e)

        {
           
            textBoxPreO.Text = customerTree.PreOrder();
            customerTree.resetPreOrderString();
        }

        private void inOCustomerButton_Click(object sender, EventArgs e)
        {
    
            textBoxInO.Text = customerTree.InOrder();
            customerTree.resetInOrderString();
        }

        private void postOCustomerButton_Click(object sender, EventArgs e)
        {
           
            textBoxPostO.Text = customerTree.PostOrder();
            customerTree.resetPostOrderString();
        }

        private void findCustomer_Click(object sender, EventArgs e)
        {
            customerTree.KeySearch = keyTextBox.Text.ToLower();
            searchTextBox.Text = customerTree.SearchCustomer();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxPostO.Text = "";
            textBoxInO.Text = "";
            textBoxPreO.Text = "";
            displayCustomerTextBox.Text = "";
            textBoxInO.Text = "";
            textBoxPreO.Text = "";
            textBoxPostO.Text = "";
            countCustomerTextBox.Text = "";
            searchTextBox.Text = "";
            keyTextBox.Text = "";

        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid number");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            inOrderTextBox.Text = "";
            postOrderTextBox.Text = "";
            preOrderTextBox.Text = "";
            countTextBox.Text = "";
        }

        
    }
}
