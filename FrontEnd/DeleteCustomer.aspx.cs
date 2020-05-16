using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void yes_Click(object sender, EventArgs e)
    {
        Software_HardwareClasses.clsCustomerCollection CustomerRecords = new Software_HardwareClasses.clsCustomerCollection();
        CustomerRecords.ThisCustomer.Find(CustomerID);
        CustomerRecords.Delete();
        Response.Redirect("CustomerList.aspx");
    }


    protected void no_Click(object sender, EventArgs e)
    {

    }
}