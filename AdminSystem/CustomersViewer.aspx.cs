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
        clsCustomers anCustomers = new clsCustomers();
        anCustomers = (clsCustomers)Session["anCustomers"];
        Response.Write(anCustomers.CustomerID);
        Response.Write(anCustomers.FullName);
        Response.Write(anCustomers.EmailAddress);
        Response.Write(anCustomers.PhoneNumber);
        Response.Write(anCustomers.DOB);
        Response.Write(anCustomers.Subscribed);
    }
}