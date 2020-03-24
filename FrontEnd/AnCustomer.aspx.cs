using Software_HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void OK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the name 
        AnCustomer.FullName = txtFullName.Text;
        //capture DOB
        AnCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
        //captureAddress
        AnCustomer.Address = txtAddress.Text;
        //capture email address
        AnCustomer.Emailaddress = txtEmailaddress.Text;
        //capture card number
        AnCustomer.Cardnumber = Convert.ToInt32(txtCardnumber.Text);
        //capture sort code
        AnCustomer.Sortcode = txtSortcode.Text;
        
        //store the customer details in the session object
        Session["AnCustomer"] = AnCustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");

    }

   
}