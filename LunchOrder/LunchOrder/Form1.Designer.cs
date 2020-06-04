namespace LunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.saladButton = new System.Windows.Forms.RadioButton();
            this.pizzaButton = new System.Windows.Forms.RadioButton();
            this.hamburgerButton = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sideCheckbox = new System.Windows.Forms.CheckBox();
            this.condimentCheckbox = new System.Windows.Forms.CheckBox();
            this.veggieCheckbox = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(707, 339);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(235, 55);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(45, 320);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GroupBox1.Size = new System.Drawing.Size(597, 248);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(277, 172);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(235, 48);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(277, 114);
            this.lblSalesTax.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(235, 48);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(277, 57);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(235, 48);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(43, 172);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(213, 38);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(43, 114);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(213, 38);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (7.75%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(43, 57);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(213, 38);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.saladButton);
            this.gbxMainCourse.Controls.Add(this.pizzaButton);
            this.gbxMainCourse.Controls.Add(this.hamburgerButton);
            this.gbxMainCourse.Location = new System.Drawing.Point(45, 33);
            this.gbxMainCourse.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxMainCourse.Size = new System.Drawing.Size(384, 248);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // saladButton
            // 
            this.saladButton.AutoSize = true;
            this.saladButton.Location = new System.Drawing.Point(25, 179);
            this.saladButton.Name = "saladButton";
            this.saladButton.Size = new System.Drawing.Size(221, 36);
            this.saladButton.TabIndex = 2;
            this.saladButton.Text = "Salad - $4.95";
            this.saladButton.UseVisualStyleBackColor = true;
            // 
            // pizzaButton
            // 
            this.pizzaButton.AutoSize = true;
            this.pizzaButton.Location = new System.Drawing.Point(25, 119);
            this.pizzaButton.Name = "pizzaButton";
            this.pizzaButton.Size = new System.Drawing.Size(217, 36);
            this.pizzaButton.TabIndex = 1;
            this.pizzaButton.Text = "Pizza - $5.95";
            this.pizzaButton.UseVisualStyleBackColor = true;
            this.pizzaButton.CheckedChanged += new System.EventHandler(this.pizzaButton_CheckedChanged);
            // 
            // hamburgerButton
            // 
            this.hamburgerButton.AutoSize = true;
            this.hamburgerButton.Checked = true;
            this.hamburgerButton.Location = new System.Drawing.Point(25, 64);
            this.hamburgerButton.Name = "hamburgerButton";
            this.hamburgerButton.Size = new System.Drawing.Size(288, 36);
            this.hamburgerButton.TabIndex = 0;
            this.hamburgerButton.TabStop = true;
            this.hamburgerButton.Text = "Hamburger - $6.95";
            this.hamburgerButton.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(707, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(235, 55);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sideCheckbox);
            this.groupBox2.Controls.Add(this.condimentCheckbox);
            this.groupBox2.Controls.Add(this.veggieCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(455, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 251);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add-On Items ($.75/each)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sideCheckbox
            // 
            this.sideCheckbox.AutoSize = true;
            this.sideCheckbox.Location = new System.Drawing.Point(19, 186);
            this.sideCheckbox.Name = "sideCheckbox";
            this.sideCheckbox.Size = new System.Drawing.Size(202, 36);
            this.sideCheckbox.TabIndex = 2;
            this.sideCheckbox.Text = "French fries";
            this.sideCheckbox.UseVisualStyleBackColor = true;
            // 
            // condimentCheckbox
            // 
            this.condimentCheckbox.AutoSize = true;
            this.condimentCheckbox.Location = new System.Drawing.Point(19, 124);
            this.condimentCheckbox.Name = "condimentCheckbox";
            this.condimentCheckbox.Size = new System.Drawing.Size(414, 36);
            this.condimentCheckbox.TabIndex = 1;
            this.condimentCheckbox.Text = "Ketchup, mustard, and mayo";
            this.condimentCheckbox.UseVisualStyleBackColor = true;
            // 
            // veggieCheckbox
            // 
            this.veggieCheckbox.AutoSize = true;
            this.veggieCheckbox.Location = new System.Drawing.Point(19, 66);
            this.veggieCheckbox.Name = "veggieCheckbox";
            this.veggieCheckbox.Size = new System.Drawing.Size(404, 36);
            this.veggieCheckbox.TabIndex = 0;
            this.veggieCheckbox.Text = "Lettuce, tomato, and onions";
            this.veggieCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1005, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.GroupBox1.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton saladButton;
        private System.Windows.Forms.RadioButton pizzaButton;
        private System.Windows.Forms.RadioButton hamburgerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox sideCheckbox;
        private System.Windows.Forms.CheckBox condimentCheckbox;
        private System.Windows.Forms.CheckBox veggieCheckbox;
    }
}

