using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {   double meal;

        public Form1()
        {
            InitializeComponent();

        }

        private void ClearTotals()
        {
            lblSubtotal.Text = (" ");
            lblSalesTax.Text = (" ");
            lblOrderTotal.Text = (" ");
        }

        private void ClearAddOns()
        {
            veggieCheckbox.Checked = false;
            condimentCheckbox.Checked = false;
            sideCheckbox.Checked = false;
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {   //Main Courses
            double hamburger = 6.95;
            double pizza = 5.95 ; 
            double salad = 4.95;
            //Hamburger Add-Ons
            double hamburgerAddOns = .75;
            //Pizza Add-Ons
            double pizzaAddOns = .50;
            //Salad Add-Ons
            double saladAddOns = .25;
            double tax = .0775;
            double subtotal;
            double mealTax;
        

            var checkboxesChecked = groupBox2.Controls.OfType<CheckBox>().Where(x => x.Checked).ToList().Count ;
            if (hamburgerButton.Checked)
            {
                subtotal = (hamburger + (checkboxesChecked * hamburgerAddOns));

                lblSubtotal.Text = subtotal.ToString();

                mealTax = (subtotal * tax);

                lblSalesTax.Text = mealTax.ToString();

                lblOrderTotal.Text = (subtotal + mealTax).ToString();

            }

            if (pizzaButton.Checked)
            {
                subtotal = (pizza + (checkboxesChecked * pizzaAddOns));
                
                lblSubtotal.Text = subtotal.ToString();

                mealTax = (subtotal * tax);

                lblSalesTax.Text = mealTax.ToString();

                lblOrderTotal.Text = (subtotal + mealTax).ToString();

            }

            if (saladButton.Checked)
            {
                subtotal = (salad + (checkboxesChecked * saladAddOns));

                lblSubtotal.Text = subtotal.ToString();

                mealTax = (subtotal * tax);

                lblSalesTax.Text = mealTax.ToString();

                lblOrderTotal.Text = (subtotal + mealTax).ToString();

            }


        }

        private void MealChanged()
        {
            if (hamburgerButton.Checked)
            {
                groupBox2.Text = ("Add-On Items ($.75/each");
                veggieCheckbox.Text = ("Lettuce,Tomato, and Onions");
                condimentCheckbox.Text = ("Ketchup, Mustard, and Mayo");
                sideCheckbox.Text = ("French Fries");

            }

            if (pizzaButton.Checked)
            {
                groupBox2.Text = ("Add-On Items ($.50/each");
                veggieCheckbox.Text = ("Pepperoni");
                condimentCheckbox.Text = ("Sausage");
                sideCheckbox.Text = ("Olives");

            }

            if (saladButton.Checked)
            {
                groupBox2.Text = ("Add-On Items ($.25/each");
                veggieCheckbox.Text = ("Croutons");
                condimentCheckbox.Text = ("Bacon Bits");
                sideCheckbox.Text = ("Bread Sticks");

            }

            ClearAddOns();
            ClearTotals();
    
        }

        private void pizzaButton_CheckedChanged(object sender, EventArgs e)
        {
            MealChanged();

        }

        private void hamburgerButton_CheckedChanged(object sender, EventArgs e)
        {
            MealChanged();
        }

        private void saladButton_CheckedChanged(object sender, EventArgs e)
        {
            MealChanged();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            ClearTotals();
        }
    }
}