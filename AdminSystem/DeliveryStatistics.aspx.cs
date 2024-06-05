using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Data;


public partial class DeliveryStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsDelivery clsDelivery = new clsDelivery();
        //retrive the database
        DataTable dT = clsDelivery.StatisticsGroupedByDeliveryStatus();

        //upload DataTable to the gridview
        GridViewStatsGroupedByDeliveryStatus.DataSource = dT;
        GridViewStatsGroupedByDeliveryStatus.DataBind();

        // change header
        GridViewStatsGroupedByDeliveryStatus.HeaderRow.Cells[0].Text = "Delivery Status";

        //retrieve data from database 
        dT = clsDelivery.StatsGroupedByOrderID();

        // upload DataTable to the gridview
        GridViewStatsGroupedByOrderID.DataSource = dT;
        GridViewStatsGroupedByOrderID.DataBind();

        //change header
        GridViewStatsGroupedByOrderID.HeaderRow.Cells[0].Text = "Order ID";



    }

    protected void btnBack_onClick(object sender, EventArgs e)
       
    {
        //redirect to the delivery
        Response.Redirect("DeliveryList.aspx");

    }
}