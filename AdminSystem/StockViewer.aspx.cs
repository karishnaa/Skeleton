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
        //create a new instance of clsStock
        clsStock anStock = new clsStock();
        //get the data from the session object
        anStock = (clsStock)Session["anStock"];
        //display the data of the stock
        Response.Write("Stock Name = "+anStock.StockName+"<br/>");
        Response.Write("Price = "+anStock.Price + "<br/>");
        Response.Write("Quantity = "+anStock.Quantity + "<br/>");
        Response.Write("Available = "+anStock.Available + "<br/>");
        Response.Write("Desription = "+anStock.Description + "<br/>");
        Response.Write("Arrival Date = "+anStock.ArrivalDate + "<br/>");
    }
}