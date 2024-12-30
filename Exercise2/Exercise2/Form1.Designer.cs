namespace Exercise2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preOrderTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.postOrderTextBox = new System.Windows.Forms.TextBox();
            this.inOrderTextBox = new System.Windows.Forms.TextBox();
            this.postOrderButton = new System.Windows.Forms.Button();
            this.inOrderButton = new System.Windows.Forms.Button();
            this.PreOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.insertCustomerButton = new System.Windows.Forms.Button();
            this.countCustomerTextBox = new System.Windows.Forms.TextBox();
            this.countCustomerButton = new System.Windows.Forms.Button();
            this.textBoxInO = new System.Windows.Forms.TextBox();
            this.postOCustomerButton = new System.Windows.Forms.Button();
            this.textBoxPostO = new System.Windows.Forms.TextBox();
            this.inOCustomerButton = new System.Windows.Forms.Button();
            this.preOCustomerButton = new System.Windows.Forms.Button();
            this.textBoxPreO = new System.Windows.Forms.TextBox();
            this.displayCustomerTextBox = new System.Windows.Forms.TextBox();
            this.findCustomer = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(305, 204);
            this.inputTextBox.MaxLength = 10;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(216, 26);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(536, 200);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(113, 38);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exercise2 - Binary Search Tree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // preOrderTextBox
            // 
            this.preOrderTextBox.Location = new System.Drawing.Point(98, 296);
            this.preOrderTextBox.Name = "preOrderTextBox";
            this.preOrderTextBox.Size = new System.Drawing.Size(367, 26);
            this.preOrderTextBox.TabIndex = 4;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // postOrderTextBox
            // 
            this.postOrderTextBox.Location = new System.Drawing.Point(124, 372);
            this.postOrderTextBox.Name = "postOrderTextBox";
            this.postOrderTextBox.Size = new System.Drawing.Size(367, 26);
            this.postOrderTextBox.TabIndex = 6;
            // 
            // inOrderTextBox
            // 
            this.inOrderTextBox.Location = new System.Drawing.Point(98, 444);
            this.inOrderTextBox.Name = "inOrderTextBox";
            this.inOrderTextBox.Size = new System.Drawing.Size(367, 26);
            this.inOrderTextBox.TabIndex = 7;
            // 
            // postOrderButton
            // 
            this.postOrderButton.Location = new System.Drawing.Point(516, 372);
            this.postOrderButton.Name = "postOrderButton";
            this.postOrderButton.Size = new System.Drawing.Size(133, 36);
            this.postOrderButton.TabIndex = 9;
            this.postOrderButton.Text = "PostOrder";
            this.postOrderButton.UseVisualStyleBackColor = true;
            this.postOrderButton.Click += new System.EventHandler(this.postOrderButton_Click);
            // 
            // inOrderButton
            // 
            this.inOrderButton.Location = new System.Drawing.Point(522, 444);
            this.inOrderButton.Name = "inOrderButton";
            this.inOrderButton.Size = new System.Drawing.Size(127, 31);
            this.inOrderButton.TabIndex = 10;
            this.inOrderButton.Text = "InOrder";
            this.inOrderButton.UseVisualStyleBackColor = true;
            this.inOrderButton.Click += new System.EventHandler(this.inOrderButton_Click);
            // 
            // PreOrderButton
            // 
            this.PreOrderButton.Location = new System.Drawing.Point(516, 288);
            this.PreOrderButton.Name = "PreOrderButton";
            this.PreOrderButton.Size = new System.Drawing.Size(134, 43);
            this.PreOrderButton.TabIndex = 11;
            this.PreOrderButton.Text = "PreOrder";
            this.PreOrderButton.UseVisualStyleBackColor = true;
            this.PreOrderButton.Click += new System.EventHandler(this.PreOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter an Integer";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(336, 559);
            this.countTextBox.MaxLength = 10;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(129, 26);
            this.countTextBox.TabIndex = 15;
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(522, 547);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(113, 38);
            this.CountButton.TabIndex = 14;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1360, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Amount Owed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1360, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Enter the Customer\'s Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1360, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Enter the Customer\'s Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1360, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Enter the Customer Name";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(1626, 274);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(302, 26);
            this.addressTextBox.TabIndex = 20;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(1626, 337);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 26);
            this.ageTextBox.TabIndex = 19;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(1626, 385);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 26);
            this.amountTextBox.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(1626, 204);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 26);
            this.nameTextBox.TabIndex = 17;
            // 
            // insertCustomerButton
            // 
            this.insertCustomerButton.Location = new System.Drawing.Point(1867, 435);
            this.insertCustomerButton.Name = "insertCustomerButton";
            this.insertCustomerButton.Size = new System.Drawing.Size(198, 65);
            this.insertCustomerButton.TabIndex = 25;
            this.insertCustomerButton.Text = "Insert Customer";
            this.insertCustomerButton.UseVisualStyleBackColor = true;
            this.insertCustomerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // countCustomerTextBox
            // 
            this.countCustomerTextBox.Location = new System.Drawing.Point(1646, 796);
            this.countCustomerTextBox.MaxLength = 10;
            this.countCustomerTextBox.Name = "countCustomerTextBox";
            this.countCustomerTextBox.Size = new System.Drawing.Size(129, 26);
            this.countCustomerTextBox.TabIndex = 27;
            // 
            // countCustomerButton
            // 
            this.countCustomerButton.Location = new System.Drawing.Point(1814, 784);
            this.countCustomerButton.Name = "countCustomerButton";
            this.countCustomerButton.Size = new System.Drawing.Size(168, 50);
            this.countCustomerButton.TabIndex = 26;
            this.countCustomerButton.Text = "Count Customers";
            this.countCustomerButton.UseVisualStyleBackColor = true;
            this.countCustomerButton.Click += new System.EventHandler(this.countCustomerButton_Click);
            // 
            // textBoxInO
            // 
            this.textBoxInO.Location = new System.Drawing.Point(1461, 645);
            this.textBoxInO.Name = "textBoxInO";
            this.textBoxInO.Size = new System.Drawing.Size(367, 26);
            this.textBoxInO.TabIndex = 33;
            // 
            // postOCustomerButton
            // 
            this.postOCustomerButton.Location = new System.Drawing.Point(1879, 573);
            this.postOCustomerButton.Name = "postOCustomerButton";
            this.postOCustomerButton.Size = new System.Drawing.Size(133, 36);
            this.postOCustomerButton.TabIndex = 34;
            this.postOCustomerButton.Text = "PostOrder";
            this.postOCustomerButton.UseVisualStyleBackColor = true;
            this.postOCustomerButton.Click += new System.EventHandler(this.postOCustomerButton_Click);
            // 
            // textBoxPostO
            // 
            this.textBoxPostO.Location = new System.Drawing.Point(1461, 578);
            this.textBoxPostO.Name = "textBoxPostO";
            this.textBoxPostO.Size = new System.Drawing.Size(367, 26);
            this.textBoxPostO.TabIndex = 32;
            // 
            // inOCustomerButton
            // 
            this.inOCustomerButton.Location = new System.Drawing.Point(1885, 645);
            this.inOCustomerButton.Name = "inOCustomerButton";
            this.inOCustomerButton.Size = new System.Drawing.Size(127, 31);
            this.inOCustomerButton.TabIndex = 35;
            this.inOCustomerButton.Text = "InOrder";
            this.inOCustomerButton.UseVisualStyleBackColor = true;
            this.inOCustomerButton.Click += new System.EventHandler(this.inOCustomerButton_Click);
            // 
            // preOCustomerButton
            // 
            this.preOCustomerButton.Location = new System.Drawing.Point(1879, 510);
            this.preOCustomerButton.Name = "preOCustomerButton";
            this.preOCustomerButton.Size = new System.Drawing.Size(134, 43);
            this.preOCustomerButton.TabIndex = 36;
            this.preOCustomerButton.Text = "PreOrder";
            this.preOCustomerButton.UseVisualStyleBackColor = true;
            this.preOCustomerButton.Click += new System.EventHandler(this.preOCustomerButton_Click);
            // 
            // textBoxPreO
            // 
            this.textBoxPreO.Location = new System.Drawing.Point(1461, 518);
            this.textBoxPreO.Name = "textBoxPreO";
            this.textBoxPreO.Size = new System.Drawing.Size(367, 26);
            this.textBoxPreO.TabIndex = 31;
            // 
            // displayCustomerTextBox
            // 
            this.displayCustomerTextBox.Location = new System.Drawing.Point(1404, 435);
            this.displayCustomerTextBox.Multiline = true;
            this.displayCustomerTextBox.Name = "displayCustomerTextBox";
            this.displayCustomerTextBox.Size = new System.Drawing.Size(424, 69);
            this.displayCustomerTextBox.TabIndex = 37;
            // 
            // findCustomer
            // 
            this.findCustomer.Location = new System.Drawing.Point(1804, 891);
            this.findCustomer.Name = "findCustomer";
            this.findCustomer.Size = new System.Drawing.Size(168, 50);
            this.findCustomer.TabIndex = 38;
            this.findCustomer.Text = "Find Customer";
            this.findCustomer.UseVisualStyleBackColor = true;
            this.findCustomer.Click += new System.EventHandler(this.findCustomer_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1404, 1015);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(424, 69);
            this.searchTextBox.TabIndex = 39;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(1597, 928);
            this.keyTextBox.MaxLength = 10;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(129, 26);
            this.keyTextBox.TabIndex = 40;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(994, 1416);
            this.splitter1.TabIndex = 41;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2092, 1015);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 69);
            this.button1.TabIndex = 42;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(374, 720);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 59);
            this.clearButton.TabIndex = 43;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2320, 1416);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.findCustomer);
            this.Controls.Add(this.displayCustomerTextBox);
            this.Controls.Add(this.textBoxInO);
            this.Controls.Add(this.postOCustomerButton);
            this.Controls.Add(this.textBoxPostO);
            this.Controls.Add(this.inOCustomerButton);
            this.Controls.Add(this.preOCustomerButton);
            this.Controls.Add(this.textBoxPreO);
            this.Controls.Add(this.countCustomerTextBox);
            this.Controls.Add(this.countCustomerButton);
            this.Controls.Add(this.insertCustomerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inOrderTextBox);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.postOrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postOrderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inOrderButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.PreOrderButton);
            this.Controls.Add(this.preOrderTextBox);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preOrderTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox postOrderTextBox;
        private System.Windows.Forms.TextBox inOrderTextBox;
        private System.Windows.Forms.Button postOrderButton;
        private System.Windows.Forms.Button inOrderButton;
        private System.Windows.Forms.Button PreOrderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countCustomerTextBox;
        private System.Windows.Forms.Button countCustomerButton;
        private System.Windows.Forms.Button insertCustomerButton;
        private System.Windows.Forms.TextBox textBoxInO;
        private System.Windows.Forms.Button postOCustomerButton;
        private System.Windows.Forms.TextBox textBoxPostO;
        private System.Windows.Forms.Button inOCustomerButton;
        private System.Windows.Forms.Button preOCustomerButton;
        private System.Windows.Forms.TextBox textBoxPreO;
        private System.Windows.Forms.TextBox displayCustomerTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button findCustomer;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
    }
}

