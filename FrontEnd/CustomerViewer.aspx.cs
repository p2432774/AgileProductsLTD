using Software_HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the Customer for this entry
        Response.Write(AnCustomer.CustomerID);
        //display the name for entry
        Response.Write(AnCustomer.FullName);
        //display DOB for entry
        Response.Write(AnCustomer.DOB);
        //diplay address for entry
        Response.Write(AnCustomer.Emailaddress);
        //display email for entry
        Response.Write(AnCustomer.Emailaddress);
        //display sort code for entry
        Response.Write(AnCustomer.Sortcode);
        //display card number for entry
        Response.Write(AnCustomer.Cardnumber);
    }

}