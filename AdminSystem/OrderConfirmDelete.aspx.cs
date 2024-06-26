﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);


    }

    //function to delete the selected record
    void DeleteOrder()
    {
        //create a new instance of the order
        clsOrdersCollection OrderBook = new clsOrdersCollection();
        //find the record to delete
        OrderBook.ThisOrder.Find(OrderID);
        //delete the record
        OrderBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrder();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}