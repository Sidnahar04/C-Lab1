///Name:Siddharth Mahendrabhai Nahar
///Date Created:28/10/2024
///Student ID:000930031
///Purpose:This will help the user to calculate the lunch items with add-ons.

namespace Lab1
{
    public partial class Form1 : Form
    {
        private const decimal HamburgerPrice = 6.95m;
        private const decimal PizzaPrice = 5.95m;
        private const decimal SaladPrice = 4.95m;
        private const decimal HamburgerAddonPrice = 0.75m;
        private const decimal PizzaAddonPrice = 0.50m;
        private const decimal SaladAddonPrice = 0.25m;

        private const decimal TaxRate = 0.05m;


        public Form1()
        {
            InitializeComponent();
            UpdateAddons();
            rdoHamburger.Text = "Hamburger - " + HamburgerPrice;
            rdoPizza.Text = "Pizza - " + PizzaPrice;
            rdoSalad.Text = "Salad - " + SaladPrice;
            rdoHamburger.Checked = true;
            totaltxt.ReadOnly = true;
            taxtxt.ReadOnly = true;
            subtotaltxt.ReadOnly = true;
        }
        //Changing Add-on as per change in Radio button selection
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddons();
        }

        /// Updating Addons as a common function
        /// by this on selecting each item from main menu 
        /// it will change options
        private void UpdateAddons()
        {

            if (rdoHamburger.Checked)
            {
                chkAddOn1.Text = "Lettuce, tomato, and onions";
                chkAddOn2.Text = "Ketchup, mustard, and mayo";
                chkAddOn3.Text = "French fries";
                grpbox2.Text = "Add-on items ($" + HamburgerAddonPrice + "/each)";
            }
            else if (rdoPizza.Checked)
            {
                chkAddOn1.Text = "Pepperoni";
                chkAddOn2.Text = "Sausage";
                chkAddOn3.Text = "Olives";
                grpbox2.Text = "Add-on items ($" + PizzaAddonPrice + "/each)";
            }
            else if (rdoSalad.Checked)
            {
                chkAddOn1.Text = "Croutons";
                chkAddOn2.Text = "Bacon bits";
                chkAddOn3.Text = "Bread sticks";
                grpbox2.Text = "Add-on items ($" + SaladAddonPrice + "/each)";
            }

            // Reset checkboxes (deselect all add-ons when switching main course)
            chkAddOn1.Checked = false;
            chkAddOn2.Checked = false;
            chkAddOn3.Checked = false;
            totaltxt.Clear();
            subtotaltxt.Clear();
            taxtxt.Clear();
        }

        //Changing Add-on as per change in Radio button selection
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateAddons();
        }

        //Changing Add-on as per change in Radio button selection
        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAddons();
        }

        //Reset button click
        private void reset_Click(object sender, EventArgs e)
        {
            subtotaltxt.Clear();
            totaltxt.Clear();
            taxtxt.Clear();
            rdoHamburger.Checked = true;
            UpdateAddons();
        }

        //Calculating the subtotal
        private void placeorder_click(object sender, EventArgs e)
        {
            decimal subtotal = 0;

            // Determine main course price and add-ons
            if (rdoHamburger.Checked)
            {
                subtotal += HamburgerPrice;
                // Add-ons for Hamburger
                subtotal += chkAddOn1.Checked ? HamburgerAddonPrice : 0;
                subtotal += chkAddOn2.Checked ? HamburgerAddonPrice : 0;
                subtotal += chkAddOn3.Checked ? HamburgerAddonPrice : 0;
                grpbox2.Text = "Add-on items ($" + HamburgerAddonPrice + "/each)";
            }
            else if (rdoPizza.Checked)
            {
                subtotal += PizzaPrice;
                // Add-ons for Pizza
                subtotal += chkAddOn1.Checked ? PizzaAddonPrice : 0;
                subtotal += chkAddOn2.Checked ? PizzaAddonPrice : 0;
                subtotal += chkAddOn3.Checked ? PizzaAddonPrice : 0;
                grpbox2.Text = "Add-on items ($" + PizzaAddonPrice + "/each)";
            }
            else if (rdoSalad.Checked)
            {
                subtotal += SaladPrice;
                // Add-ons for Salad
                subtotal += chkAddOn1.Checked ? SaladAddonPrice : 0;
                subtotal += chkAddOn2.Checked ? SaladAddonPrice : 0;
                subtotal += chkAddOn3.Checked ? SaladAddonPrice : 0;
                grpbox2.Text = "Add-on items ($" + SaladAddonPrice + "/each)";
            }

            // Calculate tax and total
            decimal tax = Math.Round(subtotal * TaxRate,2);
            decimal total = Math.Round(subtotal + tax,2);

            // Display the values in the text boxes
            subtotaltxt.Text = "$ " + subtotal;
            taxtxt.Text = "$ " + tax;
            totaltxt.Text = "$ " + total;
        }


        /// <summary>
        // Addon optons change text when selecting each Add-On
        // Changing Group text dynamically
        /// </summary>
        private void chkAddOn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                grpbox2.Text = "Add-on items ($" + HamburgerAddonPrice + "/each)";
            }
            else if (rdoPizza.Checked)
            {
                grpbox2.Text = "Add-on items ($" + PizzaAddonPrice + "/each)";
            }
            else if (rdoSalad.Checked)
            {
                grpbox2.Text = "Add-on items ($" + SaladAddonPrice + "/each)";

            }
        }

        private void chkAddOn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                grpbox2.Text = "Add-on items ($" + HamburgerAddonPrice + "/each)";
            }
            else if (rdoPizza.Checked)
            {
                grpbox2.Text = "Add-on items ($" + PizzaAddonPrice + "/each)";
            }
            else if (rdoSalad.Checked)
            {
                grpbox2.Text = "Add-on items ($" + SaladAddonPrice + "/each)";

            }

        }

        private void chkAddOn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                grpbox2.Text = "Add-on items ($" + HamburgerAddonPrice + "/each)";
            }
            else if (rdoPizza.Checked)
            {
                grpbox2.Text = "Add-on items ($" + PizzaAddonPrice + "/each)";
            }
            else if (rdoSalad.Checked)
            {
                grpbox2.Text = "Add-on items ($" + SaladAddonPrice + "/each)";

            }
        }

        //Close the application
        private void exit_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}