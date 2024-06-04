using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;


public partial class _1_DataEntry : System.Web.UI.Page
{

    // variable to store the primary key with page level scope
    Int32 OrderID;  

    protected void Page_Load(object sender, EventArgs e)
    {
        // get number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (OrderID != -1)
            {
                // display the current data for the record
                DisplayOrder();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the delivery
        clsOrder Order = new clsOrder();
        //capture the order id
        string OrderID = txtOrderID.Text;
        //capture the customer id
        string CustomerID = txtCustomerID.Text;
        //capture the staff id
        string StaffID = txtStaffID.Text;
        //capture the date
        string Date = txtDate.Text;
        //capture the is paid
        string IsPaid = chkIsPaid.Text;
        //capture the notes
        string Notes = txtNotes.Text;
        // validate the data
        string Error = "Error";
        Error = Order.Valid(OrderID, CustomerID, StaffID, Date, IsPaid, Notes);
        if (Error == "")
        {
            //capture the order id
            Order.OrderID = Convert.ToInt32(OrderID);
            //capture the customer id
            Order.CustomerID = Convert.ToInt32(CustomerID);
            //capture the staff id
            Order.StaffID = Convert.ToInt32(StaffID);
            //capture the date
            Order.Date = Convert.ToDateTime(Date);
            //capture the is paid
            Order.IsPaid = Convert.ToBoolean(IsPaid);
            //capture the notes
            Order.Notes = Notes;
            //store the address in the session object
            Session["Order"] = Order;
            //navigate to the view page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }



        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the order
        clsOrder Order = new clsOrder();
        // variable to store the primary key
        Int32 OrderID;
        // variable to store the result of the find operation
        Boolean Found = false;
        // get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        // find the record
        Found = Order.Find(OrderID);
        // if found
        if (Found == true)
        {
            // display the values of the properties in the form
            txtCustomerID.Text = Order.CustomerID.ToString();
            txtStaffID.Text = Order.StaffID.ToString();
            txtDate.Text = Order.Date.ToString();
            chkIsPaid.Checked = Order.IsPaid;
            txtNotes.Text = Order.Notes;
        }
        else
        {
               lblError.Text = "Order not found";
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order
        clsOrder Order = new clsOrder();
        //find the order to update
        Order.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = Order.OrderID.ToString();
        txtCustomerID.Text = Order.CustomerID.ToString();
        txtStaffID.Text = Order.StaffID.ToString();
        txtDate.Text = Order.Date.ToString();
        chkIsPaid.Checked = Order.IsPaid;
        txtNotes.Text = Order.Notes;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

}

