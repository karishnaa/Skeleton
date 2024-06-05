using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Data.SqlClient;

public partial class _1_List : System.Web.UI.Page
{
    private object txtFilter;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
               //update the list box
            DisplayDeliveries();

        }

    }

    void DisplayDeliveries()
    {
        //create an instance of the delivery collection
        ClassLibrary.clsDeliveryCollection Deliveries = new ClassLibrary.clsDeliveryCollection();
        //set the data source to the list of deliveries in the collection
        lstDeliveryList1.DataSource = Deliveries.DeliveryList;
        //set the name of the primary key
        lstDeliveryList1.DataValueField = "DeliveryID";
        //set the data field to display
        lstDeliveryList1.DataTextField = "DeliveryName";
        //bind the data to the list
        lstDeliveryList1.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["DeliveryID"] = -1;
        //redirect to the data entry page
        Response.Redirect("DeliveryDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 DeliveryID;
        //if a record has been selected from the list
        if (lstDeliveryList1.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            DeliveryID = Convert.ToInt32(lstDeliveryList1.SelectedValue);
            //store the data in the session object
            Session["DeliveryID"] = DeliveryID;
            //redirect to the edit page
            Response.Redirect("DeliveryDataEntry.aspx");
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
        Int32 DeliveryID;
        //if a record has been selected from the list
        if (lstDeliveryList1.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            DeliveryID = Convert.ToInt32(lstDeliveryList1.SelectedValue);
            //store the data in the session object
            Session["DeliveryID"] = DeliveryID;
            //redirect to the delete page
            Response.Redirect("DeliveryConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the delivery collection
        ClassLibrary.clsDeliveryCollection Deliveries = new ClassLibrary.clsDeliveryCollection();
        Deliveries.ReportByDeliveryStatus(txtFilter.Text);
        lstDeliveryList1.DataSource = Deliveries.DeliveryList;
        //set the name of the primary key
        lstDeliveryList1.DataValueField = "DeliveryID";
        //set the name of the field to display
        lstDeliveryList1.DataTextField = "DeliveryName";
        //bind the data to the list
        lstDeliveryList1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the delivery collection
        ClassLibrary.clsDeliveryCollection Deliveries = new ClassLibrary.clsDeliveryCollection();
        Deliveries.ReportByDeliveryStatus("");
        lstDeliveryList1.DataSource = Deliveries.DeliveryList;
        //set the name of the primary key
        lstDeliveryList1.DataValueField = "DeliveryID";
        //set the name of the field to display
        lstDeliveryList1.DataTextField = "DeliveryName";
        //bind the data to the list
        lstDeliveryList1.DataBind();
    }

    protected void btnStati(object sender, EventArgs e)
    {
        //create an instance of the delivery collection
        ClassLibrary.clsDeliveryCollection Deliveries = new ClassLibrary.clsDeliveryCollection();
        Deliveries.ReportByDeliveryStatus(txtFilter.Text);
        lstDeliveryList1.DataSource = Deliveries.DeliveryList;
        //set the name of the primary key
        lstDeliveryList1.DataValueField = "DeliveryID";
        //set the name of the field to display
        lstDeliveryList1.DataTextField = "DeliveryName";
        //bind the data to the list
        lstDeliveryList1.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("TeamMainMenu.aspx");
    }



    

   

   
}