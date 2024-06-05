using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // var to store the primary key value of the record to be deleted
    Int32 DeliveryID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the delivery to be deleted from the session object
        DeliveryID = Convert.ToInt32(Session["DeliveryID"]);

    }
    protected void btnDeleteYes_onClick(object sender, EventArgs e)
    {
        // create a new instance of the delivery
        clsDeliveryCollection DeliveryBook = new clsDeliveryCollection();
        // find the record to delete
        DeliveryBook.ThisDelivery.Find(DeliveryID);
        // delete the record
        DeliveryBook.Delete();
        // redirect back to the main page
        Response.Redirect("DeliveryList.aspx");
    }

    protected void btnDeleteNo_onClick(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("DeliveryList.aspx");
    }
}