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
        clsDelivery Delivery = new clsDelivery();
        //get the address from the session object
        Delivery = (clsDelivery)Session["Delivery"];
        //display the delivery address for this entry
        Response.Write("Delivery ID = " + Delivery.DeliveryID + "<br>");
        Response.Write("Order ID = " + Delivery.OrderID + "<br>");
        Response.Write("Delivery Address = " + Delivery.DeliveryAddress + "<br>");
        Response.Write("Date Of Delivery = " + Delivery.DateOfDelivery + "<br>");
        Response.Write("Dispatched = " + Delivery.Dispatched + "<br>");

        

    }
}