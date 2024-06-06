using ClassLibrary;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class OrderStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder clsOrder = new clsOrder();
        DataTable dT = clsOrder.StatisticsByOrderID();

        GridViewStatGroupByOrderID.DataSource = dT;
        GridViewStatGroupByOrderID.DataBind();

        GridViewStatGroupByOrderID.HeaderRow.Cells[0].Text = "Order ID ";

        dT = clsOrder.StatisticsByIsPaid();

        GridViewStatGroupByIsPaid.DataSource = dT;
        GridViewStatGroupByIsPaid.DataBind();

        GridViewStatGroupByIsPaid.HeaderRow.Cells[0].Text = "Is Paid ";


    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

}