namespace Exercise1
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Enqueue_Button = new System.Windows.Forms.Button();
            this.Peek_Button = new System.Windows.Forms.Button();
            this.Dequeue_Button = new System.Windows.Forms.Button();
            this.DisplayTextbox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.totalCustomerButton = new System.Windows.Forms.Button();
            this.customerNoTextBox = new System.Windows.Forms.RichTextBox();
            this.totalAmountButton = new System.Windows.Forms.Button();
            this.totalAmountTextBox = new System.Windows.Forms.RichTextBox();
            this.maxAmountButton = new System.Windows.Forms.Button();
            this.maxAmountTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NaureenImran = new System.Windows.Forms.Label();
            this.tailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.headButton = new System.Windows.Forms.Button();
            this.headTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(565, 207);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(565, 388);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 26);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(565, 340);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 26);
            this.ageTextBox.TabIndex = 3;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(565, 277);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(302, 26);
            this.addressTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the Customer\'s Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter the Customer\'s Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount Owed";
            // 
            // Enqueue_Button
            // 
            this.Enqueue_Button.Location = new System.Drawing.Point(1225, 186);
            this.Enqueue_Button.Name = "Enqueue_Button";
            this.Enqueue_Button.Size = new System.Drawing.Size(177, 72);
            this.Enqueue_Button.TabIndex = 9;
            this.Enqueue_Button.Text = "Enqueue";
            this.Enqueue_Button.UseVisualStyleBackColor = true;
            this.Enqueue_Button.Click += new System.EventHandler(this.EnqueueButton_Click);
            // 
            // Peek_Button
            // 
            this.Peek_Button.Location = new System.Drawing.Point(1225, 282);
            this.Peek_Button.Name = "Peek_Button";
            this.Peek_Button.Size = new System.Drawing.Size(177, 72);
            this.Peek_Button.TabIndex = 10;
            this.Peek_Button.Text = "Peek";
            this.Peek_Button.UseVisualStyleBackColor = true;
            this.Peek_Button.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // Dequeue_Button
            // 
            this.Dequeue_Button.Location = new System.Drawing.Point(1225, 388);
            this.Dequeue_Button.Name = "Dequeue_Button";
            this.Dequeue_Button.Size = new System.Drawing.Size(177, 72);
            this.Dequeue_Button.TabIndex = 11;
            this.Dequeue_Button.Text = "Dequeue";
            this.Dequeue_Button.UseVisualStyleBackColor = true;
            this.Dequeue_Button.Click += new System.EventHandler(this.DequeueButton_Click);
            // 
            // DisplayTextbox
            // 
            this.DisplayTextbox.Location = new System.Drawing.Point(460, 495);
            this.DisplayTextbox.Name = "DisplayTextbox";
            this.DisplayTextbox.Size = new System.Drawing.Size(731, 96);
            this.DisplayTextbox.TabIndex = 12;
            this.DisplayTextbox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1216, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // totalCustomerButton
            // 
            this.totalCustomerButton.Location = new System.Drawing.Point(303, 651);
            this.totalCustomerButton.Name = "totalCustomerButton";
            this.totalCustomerButton.Size = new System.Drawing.Size(285, 59);
            this.totalCustomerButton.TabIndex = 16;
            this.totalCustomerButton.Text = " Total Customer in the Queue";
            this.totalCustomerButton.UseVisualStyleBackColor = true;
            this.totalCustomerButton.Click += new System.EventHandler(this.totalCustomerButton_Click);
            // 
            // customerNoTextBox
            // 
            this.customerNoTextBox.Location = new System.Drawing.Point(628, 651);
            this.customerNoTextBox.Name = "customerNoTextBox";
            this.customerNoTextBox.Size = new System.Drawing.Size(223, 59);
            this.customerNoTextBox.TabIndex = 18;
            this.customerNoTextBox.Text = "";
            // 
            // totalAmountButton
            // 
            this.totalAmountButton.Location = new System.Drawing.Point(303, 753);
            this.totalAmountButton.Name = "totalAmountButton";
            this.totalAmountButton.Size = new System.Drawing.Size(285, 59);
            this.totalAmountButton.TabIndex = 19;
            this.totalAmountButton.Text = " Total Amount owed by all customers in the queue";
            this.totalAmountButton.UseVisualStyleBackColor = true;
            this.totalAmountButton.Click += new System.EventHandler(this.totalAmountButton_Click);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(628, 753);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(223, 59);
            this.totalAmountTextBox.TabIndex = 20;
            this.totalAmountTextBox.Text = "";
            // 
            // maxAmountButton
            // 
            this.maxAmountButton.Location = new System.Drawing.Point(303, 887);
            this.maxAmountButton.Name = "maxAmountButton";
            this.maxAmountButton.Size = new System.Drawing.Size(285, 59);
            this.maxAmountButton.TabIndex = 21;
            this.maxAmountButton.Text = "Max Amount owed in the Queue";
            this.maxAmountButton.UseVisualStyleBackColor = true;
            this.maxAmountButton.Click += new System.EventHandler(this.maxAmountButton_Click);
            // 
            // maxAmountTextBox
            // 
            this.maxAmountTextBox.Location = new System.Drawing.Point(628, 849);
            this.maxAmountTextBox.Name = "maxAmountTextBox";
            this.maxAmountTextBox.Size = new System.Drawing.Size(822, 97);
            this.maxAmountTextBox.TabIndex = 22;
            this.maxAmountTextBox.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(923, 74);
            this.label6.TabIndex = 25;
            this.label6.Text = "Exercise1 - Customer Queue ";
            // 
            // NaureenImran
            // 
            this.NaureenImran.AutoSize = true;
            this.NaureenImran.Location = new System.Drawing.Point(2119, 1234);
            this.NaureenImran.Name = "NaureenImran";
            this.NaureenImran.Size = new System.Drawing.Size(127, 21);
            this.NaureenImran.TabIndex = 26;
            this.NaureenImran.Text = "Naureen Imran";
            // 
            // tailTextBox
            // 
            this.tailTextBox.Location = new System.Drawing.Point(605, 1009);
            this.tailTextBox.Name = "tailTextBox";
            this.tailTextBox.Size = new System.Drawing.Size(137, 26);
            this.tailTextBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 1001);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Tail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // headButton
            // 
            this.headButton.Location = new System.Drawing.Point(412, 1119);
            this.headButton.Name = "headButton";
            this.headButton.Size = new System.Drawing.Size(149, 43);
            this.headButton.TabIndex = 29;
            this.headButton.Text = "Head";
            this.headButton.UseVisualStyleBackColor = true;
            this.headButton.Click += new System.EventHandler(this.headButton_Click);
            // 
            // headTextBox
            // 
            this.headTextBox.Location = new System.Drawing.Point(605, 1136);
            this.headTextBox.Name = "headTextBox";
            this.headTextBox.Size = new System.Drawing.Size(137, 26);
            this.headTextBox.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1029, 1034);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 108);
            this.button3.TabIndex = 31;
            this.button3.Text = "Clear All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1065, 1080);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 32;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2315, 1673);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.headTextBox);
            this.Controls.Add(this.headButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tailTextBox);
            this.Controls.Add(this.NaureenImran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxAmountTextBox);
            this.Controls.Add(this.maxAmountButton);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.totalAmountButton);
            this.Controls.Add(this.customerNoTextBox);
            this.Controls.Add(this.totalCustomerButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DisplayTextbox);
            this.Controls.Add(this.Dequeue_Button);
            this.Controls.Add(this.Peek_Button);
            this.Controls.Add(this.Enqueue_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Enqueue_Button;
        private System.Windows.Forms.Button Peek_Button;
        private System.Windows.Forms.Button Dequeue_Button;
        private System.Windows.Forms.RichTextBox DisplayTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button totalCustomerButton;
        private System.Windows.Forms.RichTextBox customerNoTextBox;
        private System.Windows.Forms.Button totalAmountButton;
        private System.Windows.Forms.RichTextBox totalAmountTextBox;
        private System.Windows.Forms.Button maxAmountButton;
        private System.Windows.Forms.RichTextBox maxAmountTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NaureenImran;
        private System.Windows.Forms.TextBox tailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button headButton;
        private System.Windows.Forms.TextBox headTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

