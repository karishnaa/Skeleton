using ClassLibrary;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _StockStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock clsStock = new clsStock();
        //retrieve data from the database
        DataTable dT = clsStock.StatisticsGroupedByPrice();

        //upload dT into GridView
        GridViewStGroupByPrice.DataSource = dT;
        GridViewStGroupByPrice.DataBind();

        //change the header of the first column
        GridViewStGroupByPrice.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsStock.StatisticsGroupedByQuantity();

        //upload dT into GridView
        GridViewStGroupByQuantity.DataSource = dT;
        GridViewStGroupByQuantity.DataBind();

        //change the header of the first column
        GridViewStGroupByQuantity.HeaderRow.Cells[0].Text = " Total ";
    }

}