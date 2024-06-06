using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    int CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    { 
          // converts the customerid from the session to an int 
          CustomerID = Convert.ToInt32(Session["CustomerID"]);
          // customer details will only display if customer id is valid 
          if (IsPostBack == false)
          { 
                if (CustomerID != -1)
                {
                    DisplayCustomers();
                }
           }
    }
    

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the class we want to test
        clsCustomers anCustomers = new clsCustomers();

        int CustomerID;
        bool Found = false;

        // Parse the text from txtCustomerID.Text to an integer
        if (int.TryParse(txtCustomerID.Text, out CustomerID))
        {
            // Call the Find method to find the customer
            Found = anCustomers.Find(CustomerID);
        }

        // If customer found, display the details
        if (Found)
        {
            txtFullName.Text = anCustomers.FullName;
            TxtEmailAddress.Text = anCustomers.EmailAddress;
            txtPhoneNumber.Text = anCustomers.PhoneNumber;
            txtDOB.Text = anCustomers.DOB.ToString("dd-MM-yyyy"); // Correct date format
            ChkSubscribed.Checked = anCustomers.Subscribed; // Set checkbox state
        }

        else
        {
            // diplays an error message when customer is not found 
            lblError.Text = "Customer not found.";
        }
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        // create an instance of the clsCustomers class
        clsCustomers anCustomers = new clsCustomers();
        // the data from the form input is retrieve 
        string FullName = txtFullName.Text;
        string EmailAddress = TxtEmailAddress.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string DOB = txtDOB.Text;
        string Subscribed = ChkSubscribed.Text;
        string Error = "";
        // valiadates the form input data 
        Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
        if (Error == "")
        {
            anCustomers.CustomerID = CustomerID;
            // Assign values to the customer object  
            anCustomers.FullName = txtFullName.Text;
            anCustomers.EmailAddress = TxtEmailAddress.Text;
            anCustomers.PhoneNumber = txtPhoneNumber.Text;
            anCustomers.DOB = Convert.ToDateTime(txtDOB.Text);
            anCustomers.Subscribed = ChkSubscribed.Checked;
            // create an instance of the customer collection class
            clsCustomerCollection CustomersList = new clsCustomerCollection();
            // only if customerid is -1, it will add a new customer
            if (CustomerID == -1)
            {
                CustomersList.ThisCustomers = anCustomers;
                CustomersList.Add();
            }
            else
            {
                // if the customerid is valid then can update the customers details
                CustomersList.ThisCustomers.Find(CustomerID);
                CustomersList.ThisCustomers = anCustomers;
                CustomersList.Update();
            }   
            // redirect to the customerslist,aspx
            Response.Redirect("CustomersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }


    void DisplayCustomers()
    {
            // creates an instance of the customer collection class
            clsCustomerCollection Customers = new clsCustomerCollection();
            // Find the record to update
            Customers.ThisCustomers.Find(CustomerID);
            // displys the customer details in the form
            txtCustomerID.Text = Customers.ThisCustomers.CustomerID.ToString();
            txtFullName.Text = Customers.ThisCustomers.FullName;
            TxtEmailAddress.Text = Customers.ThisCustomers.EmailAddress;
            txtPhoneNumber.Text = Customers.ThisCustomers.PhoneNumber;
            txtDOB.Text = Customers.ThisCustomers.DOB.ToString("dd-MM-yyyy");
            ChkSubscribed.Checked = Customers.ThisCustomers.Subscribed;
     }
        


    protected void btnReturntomm_Click(object sender, EventArgs e)
    {
        // Redirects to the TeamMainMenu.aspx when the returntomm button is clicked
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        // Redirects to the CustomersList.aspx when the Cancel button is clicked
        Response.Redirect("CustomersList.aspx");
    }

}