using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        // redirect the user to the staff list page 
        Response.Redirect("StaffList.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        // redirect the user to the stock list page 
        Response.Redirect("StockList.aspx");
    }


    protected void btnOrder_Click(object sender, EventArgs e)
    {
        // redirect the user to the Order list page 
        Response.Redirect("OrderList.aspx");
    }

    protected void btnDelivery_Click(object sender, EventArgs e)
    {
        // redirect the user to the delivery list page 
        Response.Redirect("DeliveryList.aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        // // redirect the user to the customers list page 
        Response.Redirect("CustomersList.aspx");
    }
}
