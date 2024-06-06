﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the Staff Name for this entry
        Response.Write(AnStaff.Name);
        //display the Staff DOB for this entry
        Response.Write(AnStaff.DOB);
        //display the Staff Position for this entry
        Response.Write(AnStaff.Position);
        //display the Staff Salary for this entry
        Response.Write(AnStaff.Salary);
        //display the Staff Email for this entry
        Response.Write(AnStaff.Email);
        //display the Staff IsAvailable for this entry
        Response.Write(AnStaff.IsAvailable); 



    }
}