using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;

public partial class _1_DataEntry : System.Web.UI.Page
{
    
    // variable to store the primary key with page level scope
    Int32 DeliveryID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the delivery to be processed
        DeliveryID = Convert.ToInt32(Session["DeliveryID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (DeliveryID != -1)
            {
                // display the current data for the record
                DisplayDelivery();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of delivery
        clsDelivery ADelivery = new clsDelivery();
        // capture the delivery id
        string DeliveryID = txtDeliveryID.Text;
        // capture the order id
        string OrderID = txtOrderID.Text;
        // capture the delivery address
        string DeliveryAddress = txtDeliveryAddress.Text;
        // capture the date of delivery
        string DateOfDelivery = txtDateOfDelivery.Text;
        // capture the dispatched status
        string Dispatched = chkActive.Text;
        // variable to store any error messages
        string Error = "";
        // validate the data
        Error = ADelivery.Valid(DeliveryID, OrderID, DeliveryAddress, DateOfDelivery, Dispatched);
        if (Error == "Error")
        {
            // capture the delivery id
            ADelivery.DeliveryID = Convert.ToInt32(DeliveryID);
            // capture the order id
            ADelivery.OrderID = Convert.ToInt32(OrderID);
            // capture the delivery address
            ADelivery.DeliveryAddress = DeliveryAddress;
            // capture the date of delivery
            ADelivery.DateOfDelivery = Convert.ToDateTime(DateOfDelivery);
            // capture the dispatched status
            ADelivery.Dispatched = Convert.ToBoolean(Dispatched);
            // store the delivery in the session object
            Session["ADelivery"] = ADelivery;
            // redirect to the viewer page
            Response.Redirect("DeliveryViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
               
            

            
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the delivery class
        clsDelivery Delivery = new clsDelivery();
        // variable to store the primary key
        Int32 DeliveryID;
        // variable to store the result of the find operation
        Boolean Found = false;
        // get the primary key entered by the user
        DeliveryID = Convert.ToInt32(txtDeliveryID.Text);
        // find the record
        Found = Delivery.Find(DeliveryID);
        // if found 
        if (Found == true)
        {
            // display the values of the properties in the form
            txtOrderID.Text = Delivery.OrderID.ToString();
            txtDeliveryAddress.Text = Delivery.DeliveryAddress;
            txtDateOfDelivery.Text = Delivery.DateOfDelivery.ToString();
            chkActive.Checked = Delivery.Dispatched;
        }
        else
        {
               lblError.Text = "Delivery ID not found";
        }

    }

    void DisplayDelivery()
    {
        // create an instance of the delivery class
        clsDeliveryCollection DeliveryBook = new clsDeliveryCollection();
        // find the record to update
        DeliveryBook.ThisDelivery.Find(DeliveryID);
        // display the data for this record
        txtDeliveryID.Text = DeliveryBook.ThisDelivery.DeliveryID.ToString();
        txtOrderID.Text = DeliveryBook.ThisDelivery.OrderID.ToString();
        txtDeliveryAddress.Text = DeliveryBook.ThisDelivery.DeliveryAddress;
        txtDateOfDelivery.Text = DeliveryBook.ThisDelivery.DateOfDelivery.ToString();
        chkActive.Checked = DeliveryBook.ThisDelivery.Dispatched;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("DeliveryList.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("DeliveryList.aspx");
    }

}


