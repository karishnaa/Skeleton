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
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write("Order ID = " + AnOrder.OrderID + "<br/>");
        Response.Write("Customer ID = " + AnOrder.CustomerID + "<br/>");
        Response.Write("Staff ID = " + AnOrder.StaffID + "<br/>");
        Response.Write("Stock ID = " + AnOrder.StockID + "<br/>");
        Response.Write("Order Date = " + AnOrder.OrderDate + "<br/>");
        Response.Write("Is Paid = " + AnOrder.IsPaid + "<br/>");
        Response.Write("Notes = " + AnOrder.Notes + "<br/>");

    }
}
