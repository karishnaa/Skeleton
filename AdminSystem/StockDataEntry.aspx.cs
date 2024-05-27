using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockID;

    protected void Page_Load(object sender, EventArgs e)
    {   
        //get the number of the stock to be processed
        StockID = Convert.ToInt32(Session["StockID"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            if (StockID != -1)
            {
                //update the list box
                DisplayStock();
            }
        }

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock anStock = new clsStock();
        //create test data
        string StockName = txtStockName.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string ArrivalDate = txtArrivalDate.Text;
        string Description = txtDescription.Text;
        string Available = chkAvailable.Text;

        //variable to store any error messages
        String Error = "";
        //validate the data
        Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
        if (Error == "")
        {
            //capture the stock id
            anStock.StockID = StockID;
            //capture the data
            anStock.StockName = txtStockName.Text;
            anStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            anStock.Price = Math.Round(float.Parse(txtPrice.Text), 2);
            anStock.Description = txtDescription.Text;
            anStock.Available = chkAvailable.Checked;
            anStock.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            if(StockID == -1)
            {    //set the ThisStockProperty
                StockList.ThisStock= anStock;
                //add the new record
                StockList.Add();
            }
            else
            {
                //find the record to update
                StockList.ThisStock.Find(StockID);
                //set the This property
                StockList.ThisStock = anStock;
                //update the record
                StockList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }



    protected void btnFind_Click2(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock anStock = new clsStock();
        //create a variable to store the primary key
        Int32 StockID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockID = Convert.ToInt32(txtStockID.Text);
        //find the record  
        Found = anStock.Find(StockID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStockName.Text = anStock.StockName;
            txtQuantity.Text = anStock.Quantity.ToString();
            txtPrice.Text = anStock.Price.ToString();
            txtDescription.Text = anStock.Description.ToString();
            txtArrivalDate.Text = anStock.ArrivalDate.ToShortDateString();
            chkAvailable.Text = anStock.Available.ToString();

        }
    }


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtQuantity_TextChanged(object sender, EventArgs e)
    {

    }
    void DisplayStock()
    {
        //create an instance of the stocks
        clsStockCollection stocks = new clsStockCollection();
        //find the record to update
        stocks.ThisStock.Find(StockID);
        //display the data for the record
        txtStockID.Text = stocks.ThisStock.StockID.ToString();
        txtStockName.Text = stocks.ThisStock.StockName;
        txtQuantity.Text = stocks.ThisStock.Quantity.ToString();
        txtPrice.Text = stocks.ThisStock.Price.ToString();
        txtDescription.Text = stocks.ThisStock.Description.ToString();
        txtArrivalDate.Text = stocks.ThisStock.ArrivalDate.ToShortDateString();
        chkAvailable.Text = stocks.ThisStock.Available.ToString();

    }
}