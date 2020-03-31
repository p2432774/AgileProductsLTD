using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void OKBtn_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsHardware
        clsHardware hardware = new clsHardware();
        //Captures the products name
        hardware.Name = txtName.Text;
        //Captures the description
        hardware.Description = txtDescription.Text;
        //Captures the price 
        hardware.Price = Int32.Parse(txtPrice.Text);
        //Captures if the "MoreStockRequired" box was ticked
        hardware.StockRequired = stockbox.Checked;
        //Captures the date
        hardware.DateAdded = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", null);
        //Stores the address in the session object
        Session["hardware"] = hardware;
        //Redirect to the product page
        Response.Redirect("HardwareItem.aspx");

    }

    protected void CancelBtn_Click(object sender, EventArgs e)
    {

    }
}