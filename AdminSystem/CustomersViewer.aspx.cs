using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomers anCustomer = new clsCustomers();
        // Capture the Customer 
        anCustomer = (clsCustomers)Session["anCustomer"];
        //store the address in the session object 
        Response.Write(anCustomer.FullName);
    }
}