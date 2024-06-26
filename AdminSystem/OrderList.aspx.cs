﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Data.SqlClient;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }

    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = Orders.OrdersList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderID";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportByOrderID(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrdersList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderID";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportByOrderID("");
        lstOrderList.DataSource = Orders.OrdersList;    
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderID";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportByOrderID("");
        lstOrderList.DataSource = Orders.OrdersList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderID";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnStatistics(object sender, EventArgs e)
    {
        //redirect to the statistics page
        Response.Redirect("OrderStatistics.aspx");

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("TeamMainMenu.aspx");
    }

}