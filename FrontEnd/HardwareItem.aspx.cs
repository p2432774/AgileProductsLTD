using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class HardwareItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Creates a new instance of clsHardware
        clsHardware hardware = new clsHardware();
        //Get Data from the session object
        hardware = (clsHardware)Session["hardware"];
        //Display the name for this entry
        Response.Write(hardware.HardwareID);
        Response.Write(hardware.StockRequired);
       
    }
}