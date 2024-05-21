using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

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
            //capture the data
            anStock.StockName = txtStockName.Text;
            anStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            anStock.Price = Math.Round(float.Parse(txtPrice.Text), 2);
            anStock.Description = txtDescription.Text;
            anStock.Available = chkAvailable.Checked;
            anStock.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
            //store the data in the session object
            Session["anStock"] = anStock;
            //navigate to the view page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void txtQuantity_TextChanged(object sender, EventArgs e)
    {

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
            txtArrivalDate.Text = anStock.ArrivalDate.ToString();
            chkAvailable.Text = anStock.Available.ToString();

        }
    }

}