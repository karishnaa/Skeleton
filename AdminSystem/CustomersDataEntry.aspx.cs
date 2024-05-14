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
        //create a new instance of clsCustomer
        clsCustomers anCustomer = new clsCustomers();
        // Capture the Customer 
        anCustomer.FullName = txtFullName.Text;
        anCustomer.EmailAddress = TxtEmailAddress.Text;
        anCustomer.PhoneNumber = txtPhoneNumber.Text;
        //store the address in the session object 
        Session["anCustomer"] =anCustomer;
        //navigate to the view page 
        Response.Redirect("CustomersViewer.aspx");
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}