using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{ 
    int CustomerID;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        // checks if the page is loading for the first time 
        if (IsPostBack == false)
        {
                // display the list of customers 
                DisplayCustomers();
        }
    }
    // this method which displays the customers in the list 
     void DisplayCustomers()
    {
        // create an instance of the customer collection class 
        clsCustomerCollection Customers = new clsCustomerCollection();
        // set the data source for the list to the list of customers 
        lstCustomersList.DataSource = Customers.CustomersList;
        // sets the field which provides the vales of each item in the list 
        lstCustomersList.DataValueField = "CustomerID";
        // sets the field which provides the text of each item in the list 
        lstCustomersList.DataTextField = "EmailAddress";
        // data is binded to the list 
        lstCustomersList.DataBind();
    }
    // Add Button Click 
    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        // set the session variable for customerID to -1 when a new customer is added. 
        Session["CustomerID"] = -1;
        // redirects to the customer data entry page 
        Response.Redirect("CustomersDataEntry.aspx");

    }
    // Event Handler for Edit Button Click 
    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        int CustomerID;
        // Checks if an item is selected in the list 
        if(lstCustomersList.SelectedIndex != -1)
        {
            // the customerID is selected 
            CustomerID = Convert.ToInt32(lstCustomersList.SelectedValue);
            // the customerId is stored in the session
            Session["CustomerID"] = CustomerID;
            // redirect  to the customer data entry page
            Response.Redirect("CustomersDataEntry.aspx");

        }
        else 
        { 
            //  if no item is selected , it will display an error message 
            lblError.Text = "Select a record from the list to edit";
        }
    }
    // Event Handler for Delete Button Click 
    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        int CustomerID;
        // check if the item is selected in the list 
        if (lstCustomersList.SelectedIndex != -1)
        {
            // the customerID is selected 
            CustomerID = Convert.ToInt32(lstCustomersList.SelectedValue);
            // the customerId is stored in the session
            Session["CustomerID"] = CustomerID;
            // redirect to customers confirm delete 
            Response.Redirect("CustomersConfirmDelete.aspx");
        }
        else
        {
            //  if no item is selected , it will display an error message 
            lblError.Text = "Select a record from the list to Delete";
        }

    }
    

    // Event Handler for Apply Filter Button Click 
    protected void BtnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of customer collection class 
        clsCustomerCollection anCustomers = new clsCustomerCollection();
        // filter the customer list based on the text in the filter textbox 
        anCustomers.ReportByEmailAddress(txtFilter.Text);
        // set the data source of the list to the filtered list of customers 
        lstCustomersList.DataSource = anCustomers.CustomersList;
        // make sure customerId is the value of each item in the list 
        lstCustomersList.DataValueField = "CustomerID";
        // make sure emailaddress is the text of each item in the list 
        lstCustomersList.DataTextField = "EmailAddress"; 
        // bind the data to the list
        lstCustomersList.DataBind();
    }
    //  Event Handler for Clear Filter Button Click
    protected void BtnClearfilter_Click(object sender, EventArgs e)
    {
        // create an instance of customer collection class 
        clsCustomerCollection anCustomers = new clsCustomerCollection();
        // clear the filter by passing an empty string 
        anCustomers.ReportByEmailAddress("");
        // clear the filter textbox 
        txtFilter.Text = "";
        // the data source for the list to the unfiltered list of customers
        lstCustomersList.DataSource = anCustomers.CustomersList;
        //  make sure the customerID is the value of each item in the list 
        lstCustomersList.DataValueField = "CustomerID";
        //  make sure the emailaddress is the text of each item in the list 
        lstCustomersList.DataTextField = "EmailAddress";
        // // bind the data to the list
        lstCustomersList.DataBind();
    }

    
    // Event Handler for Statistics Button Click 
    protected void BtnStatisticspage_Click(object sender, EventArgs e)
    {
        // redirect to customers Statistics
        Response.Redirect("CustomersStatistics.aspx");
    }
    // Event Handler for Return to Main Menu Button Click
    protected void BtnReturntomm_Click(object sender, EventArgs e)
    {
        // redirect to Team Main menu 
        Response.Redirect("TeamMainMenu.aspx");
    }
}