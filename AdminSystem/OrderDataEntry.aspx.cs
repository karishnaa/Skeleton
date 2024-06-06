using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrders();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string OrderID = txtOrderID.Text;
        string CustomerID = txtCustomerID.Text;
        string StaffID = txtStaffID.Text;
        string StockID = txtStockID.Text;
        string OrderDate = txtOrderDate.Text;
        string IsPaid = chkIsPaid.Text;
        string Notes = txtNotes.Text;

        string Error = "";

        Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
        if (Error == "")
        {


            AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
            AnOrder.StockID = Convert.ToInt32(txtStockID.Text);
            AnOrder.StaffID = Convert.ToInt32(txtStaffID.Text);
            AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            AnOrder.IsPaid = chkIsPaid.Checked;
            AnOrder.Notes = txtNotes.Text;

            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        try
        {
            clsOrder AnOrder = new clsOrder();
            Int32 OrderID;
            Boolean Found = false;
            OrderID = Convert.ToInt32(txtOrderID.Text);
            Found = AnOrder.Find(OrderID);
            if (Found == true)
            {
                txtOrderID.Text = AnOrder.OrderID.ToString();
                txtCustomerID.Text = AnOrder.CustomerID.ToString();
                txtStaffID.Text = AnOrder.StaffID.ToString();
                txtStockID.Text = AnOrder.StockID.ToString();
                txtOrderDate.Text = AnOrder.OrderDate.ToShortDateString();
                chkIsPaid.Checked = AnOrder.IsPaid;
                txtNotes.Text = AnOrder.Notes;
            }
        }
        catch
        {
            lblError.Text = "There was a problem with the data entered";
        }

    }

    void DisplayOrders()
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ThisOrder.Find(OrderID);
        txtOrderID.Text = OrderList.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrderList.ThisOrder.CustomerID.ToString();
        txtStaffID.Text = OrderList.ThisOrder.StaffID.ToString();
        txtStockID.Text = OrderList.ThisOrder.StockID.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToShortDateString();
        chkIsPaid.Checked = OrderList.ThisOrder.IsPaid;
        txtNotes.Text = OrderList.ThisOrder.Notes;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnReturnToMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }


    protected void btnFind_Click1(object sender, EventArgs e)
    {

    }

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }
}