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
        dT = clsOrder.StatisticsGroupedByIsPaid();
        //upload DataTable to the gridview
        GridViewStatGroupedByIsPaid.DataSource = dT;
        GridViewStatGroupedByIsPaid.DataBind();
        //change header for first column in gridview
        GridViewStatGroupedByIsPaid.HeaderRow.Cells[0].Text = "Is Paid?";

    }
    protected void btnBack_onClick(object sender, EventArgs e)
    {
        //redirect to the delivery
        Response.Redirect("OrderList.aspx");
    }
}