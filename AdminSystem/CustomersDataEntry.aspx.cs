using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtFullName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomers
        clsCustomers anCustomer = new clsCustomers();

        // Capture the customer details from UI elements
        anCustomer.FullName = txtFullName.Text;
        anCustomer.EmailAddress = TxtEmailAddress.Text;
        anCustomer.PhoneNumber = txtPhoneNumber.Text;
        anCustomer.Subscribed = Convert.ToBoolean(Subscribed.Text); // Assuming Subscribed is a string representing a boolean value

        // Parse the text from txtDOB.Text to a DateTime
        DateTime dob;
        if (DateTime.TryParse(txtDOB.Text, out dob))
        {
            anCustomer.DOB = dob;
        }

        // Store the customer object in the session
        Session["anCustomer"] = anCustomer;

        // Navigate to the view page
        Response.Redirect("CustomersViewer.aspx");
    }


    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    public void TestBtnFind_Click()
    {
        // Create an instance of the class we want to test
        clsCustomers anCustomer = new clsCustomers();

        int CustomerID;
        bool Found = false;

        // Parse the text from txtCustomerID.Text to an integer
        if (int.TryParse(txtCustomerID.Text, out CustomerID))
        {
            // Call the Find method to find the customer
            Found = anCustomer.Find(CustomerID);
        }

        // If customer found, display the details
        if (Found)
        {
            txtFullName.Text = anCustomer.FullName;
            TxtEmailAddress.Text = anCustomer.EmailAddress;
            txtPhoneNumber.Text = anCustomer.PhoneNumber;
            txtDOB.Text = anCustomer.DOB.ToString(); // Corrected to include parentheses for ToString method
            Subscribed.Text = anCustomer.Subscribed.ToString(); // Convert boolean to string
        }
    }


}