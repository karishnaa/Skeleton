using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }
    }
    protected void DisplayStaffs()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of staffs in the collection
        lstStaffList.DataSource = Staffs.StaffList;

        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "Name";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }





    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrieve the value of DOB from the presentation layer
        AnStaff.ReportByDOB(txtDOB.Text);
        //set the data source to the list of Staffs in the collection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the DOB of the field to display
        lstStaffList.DataTextField= "DOB";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {

        DisplayStaffs();
        





    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
      
        Int32 StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
        //store the data in the session object
        Session["StaffId"] = StaffId;
        Response.Redirect("StaffConfirmDelete.aspx");


    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnStatisticsPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffStatistics.aspx");
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}