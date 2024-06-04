using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomersStatistics : System.Web.UI.Page
{
    // Event Handler for the page load 
    protected void Page_Load(object sender, EventArgs e)
    {
        // create an instance of the clsCustomers class 
        clsCustomers clsCustomers = new clsCustomers();
        // Retrieve statistics grouped by date of birth 
        DataTable dT = clsCustomers.StatisticsGroupedByDOB();
        // data source for gridview to the datatable 
        GridViewStGroupByDOB.DataSource = dT;
        //  binds the data to the gridview 
        GridViewStGroupByDOB.DataBind();
        // the column header text is set to total 
        GridViewStGroupByDOB.HeaderRow.Cells[0].Text = "Total";
        // Retrieve statistics grouped by Subscribed 
        dT = clsCustomers.StatisticsGroupedBySubscribed();
        // data source for gridview to the datatable 
        GridViewStGroupBySubscribed.DataSource = dT;
        //  binds the data to the gridview 
        GridViewStGroupBySubscribed.DataBind();
        // the column header text is set to total
        GridViewStGroupBySubscribed.HeaderRow.Cells[0].Text = "Total";
    }

    protected void GridViewStGroupBySubscribed_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridViewStGroupByDOB_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BtnCustomersList_Click(object sender, EventArgs e)
    {
        // redirect to the customerslist.aspx
        Response.Redirect("CustomersList.aspx");
    }
}