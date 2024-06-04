using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // a varaible which stores the Customer ID
    int CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //fecthes the Customer IDfrom the session then it will convert to an integer
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }



    protected void btnNO_Click(object sender, EventArgs e)
    {
        // Redirects to the CustomersList.aspx when the No button is clicked
        Response.Redirect("CustomersList.aspx");
    }

    protected void btnYES_Click(object sender, EventArgs e)
    {
        // create a new instance of the clsCustomerCollection class
        clsCustomerCollection CustomersList = new clsCustomerCollection();
        // find the customer with an customerid
        CustomersList.ThisCustomers.Find(CustomerID);
        // Delete the customer from the collection
        CustomersList.Delete();
        // Redirects to the CustomersList.aspx when the Yes button is clicked
        Response.Redirect("CustomersList.aspx");
    }

   
}