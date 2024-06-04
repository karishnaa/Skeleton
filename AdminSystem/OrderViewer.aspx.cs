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
        //create a new instance of the delivery
        clsOrder Order = new clsOrder();
        //get the address from the session object
        Order = (clsOrder)Session["Order"];
        //display the delivery address for this entry
        Response.Write("Order ID: " + Order.OrderID + "<br>");
        Response.Write("Customer ID: " + Order.CustomerID + "<br>");
        Response.Write("Staff ID: " + Order.StaffID + "<br>");
        Response.Write("Date: " + Order.Date + "<br>");
        Response.Write("Is Paid: " + Order.IsPaid + "<br>");
        Response.Write("Notes: " + Order.Notes + "<br>");


    }
}

