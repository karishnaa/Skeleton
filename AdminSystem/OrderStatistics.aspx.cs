using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClassLibrary;

public partial class OrderStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder clsOrder = new clsOrder();
        //retrive the database
        DataTable dT = clsOrder.StatisticsGroupedByOrderStatus();

        // upload DataTable to the gridview
        GridViewStatGroupByOrderID.DataSource = dT;
        GridViewStatGroupByOrderID.DataBind();

        // change header for first column in gridview
        GridViewStatGroupByOrderID.HeaderRow.Cells[0].Text = "Order Status";

        // retrieve data from database
        dT = clsOrder.StatisticsGroupedByDispatched();
        //upload DataTable to the gridview
        GridViewStatGroupByDispatched.DataSource = dT;
        GridViewStatGroupByDispatched.DataBind();
        //change header for first column in gridview
        GridViewStatGroupByDispatched.HeaderRow.Cells[0].Text = "Dispatched";

    }
    protected void btnBack_onClick(object sender, EventArgs e)
    {
        //redirect to the delivery
        Response.Redirect("OrderList.aspx");
    }
}