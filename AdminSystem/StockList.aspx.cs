using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();

        }

    }
    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to list of addresses in the collection
        lstStockList1.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList1.DataValueField = "StockID";
        //set the data field to display
        lstStockList1.DataTextField = "StockName";
        //bind the data to the list
        lstStockList1.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btn_Edit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StockID;
        //if a record has been selected from the list
        if (lstStockList1.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstStockList1.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "Please select a record from the list to edit";
        }
    }


    protected void btn_Delete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StockID;
        //if a record has been selected from the list
        if (lstStockList1.SelectedIndex != 1)
        {
            //get the primary key value of the record delete
            StockID = Convert.ToInt32(lstStockList1.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection anStock = new clsStockCollection();
        //retrieve the value of post code from the presentation layer
        anStock.ReportByStockName(txtStockName.Text);
        //set the data source to the list of stock names in the collection
        lstStockList1.DataSource = anStock.StockList;
        //set the name of the primary key
        lstStockList1.DataValueField = "StockID";
        //set the name of the field to display
        lstStockList1.DataTextField = "StockName";
        //bind the data to the list
        lstStockList1.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock names object
        clsStockCollection anStock = new clsStockCollection();
        //set an empty string
        anStock.ReportByStockName("");
        //clear any existing filter to tidy up interface
        txtStockName.Text = "";
        //set the data source to the list of stock names in the collection
        lstStockList1.DataSource = anStock.StockList;
        //set the name of the primary key
        lstStockList1.DataValueField = "StockID";
        //set the name of the field to display
        lstStockList1.DataTextField = "StockName";
        //bind the data to the list
        lstStockList1.DataBind();
    }
}