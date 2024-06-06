using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Data;

public partial class StaffStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff clsstaff = new clsStaff();
        //retrieve data from the database
        DataTable dT = clsstaff.StatisticsGroupByDOB(); 

        //upload dT into GridView
        GridViewStGroupByDOB.DataSource = dT;
        GridViewStGroupByDOB.DataBind();

        //change the header of the first column 
        GridViewStGroupByDOB.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsstaff.StatisticsGroupByIsAvailable();

        //upload dT into GridView
        GridViewStGroupByIsAvailable.DataSource = dT;
        GridViewStGroupByIsAvailable.DataBind();

        //change the header of the first column
        GridViewStGroupByIsAvailable.HeaderRow.Cells[0].Text = " Total ";

    }

    protected void GridViewStGroupByDOB_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridViewStGroupByIsAvailable_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}