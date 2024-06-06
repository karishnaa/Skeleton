using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // private object chkIsAvailable;
    // private readonly object chkIsAvailable;


    //variable to store the primary key with page level scope
    Int32 StaffId = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        //get the number of the staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (StaffId != -1)
            {
              
                    //display the current data for the record
                    DisplayStaff();
                
              
            }

        }


    }

    private void DisplayStaff()
    {
        //create an instance of the Staff book
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to update
        if (Staff.ThisStaff.Find(StaffId))
        {
            //display the data for the record
            txtStaffId.Text = Staff.ThisStaff.StaffId.ToString();
            txtName.Text = Staff.ThisStaff.Name.ToString();
            txtPosition.Text = Staff.ThisStaff.Position.ToString();
            txtEmail.Text = Staff.ThisStaff.Email.ToString();
            txtDOB.Text = Staff.ThisStaff.DOB.ToString();
            chkIsAvailable.Checked = Staff.ThisStaff.IsAvailable;
            txtSalary.Text = Staff.ThisStaff.Salary.ToString();
        }

    }

    public bool IsAvailable { get; private set; }

    
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }


    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the Staff name
        string Name = txtName.Text;
        //capture the Staff DateOfBirth

        DateTimeFormatInfo format = new DateTimeFormatInfo();
        format.ShortDatePattern = "dd/MM/yyyy";
        //  string x = Convert.ToDateTime(txtDOB.Text).ToShortTimeString();
        string DOB = Convert.ToDateTime(txtDOB.Text, format).ToShortDateString();
        //capture the staff salary
        float Salary = float.Parse(txtSalary.Text);
        //capture the staff Position
        string Position = txtPosition.Text;
        //capture the staff email
        string Email = txtEmail.Text;
        //capture IsAvailable checkbox
        bool IsAvailable = chkIsAvailable.Checked;
        //variable to store any error messages
        string Error = "";
        //validate the data

        Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
        if (Error == "")
        {
            //capture the Staff Id
            AnStaff.StaffId = StaffId;
            //capture the Name
            AnStaff.Name = Name;
            //capture the Position
            AnStaff.Position = Position;
            //capture the Email
            AnStaff.Email = Email;
            //capture DOB
            AnStaff.DOB = Convert.ToDateTime(DOB);
            //capture the Salary
            AnStaff.Salary = Salary;
            //capture IsAvailable
            AnStaff.IsAvailable = chkIsAvailable.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //if this is a new record i.e StaffId = -1 then add the data
            if (StaffId == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the list page 
            Response.Redirect("StaffList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void txtSalary_TextChanged(object sender, EventArgs e)
    {

    }

   
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AnStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDOB.Text = AnStaff.DOB.ToString();
            txtName.Text = AnStaff.Name;
            txtPosition.Text = AnStaff.Position;
            txtEmail.Text = AnStaff.Email;
            txtSalary.Text = AnStaff.Salary.ToString();
            chkIsAvailable.Checked = AnStaff.IsAvailable;

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("StaffList.aspx");
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void chkIsAvailable_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }
}










    
