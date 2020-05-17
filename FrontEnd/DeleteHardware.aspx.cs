using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class DeleteHardware : System.Web.UI.Page
{
    Int32 HardwareID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Gets the primary key of the record to be deleted from the session object
        HardwareID = Convert.ToInt32(Session["hardware"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Creates instance of clsHardwareCollection
        clsHardwareCollection hardwareCollection = new clsHardwareCollection();
        //Find the record to delete
        hardwareCollection.ThisHardwareProduct.Find(HardwareID);
        //Delete the record
        hardwareCollection.Delete();
        //Redirect back to main page
        Response.Redirect("HardwareList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("HardwareList.aspx");
    }
}