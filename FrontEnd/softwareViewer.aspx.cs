using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class softwareViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSoftware Software = new clsSoftware();
        Software = (clsSoftware)Session["Software"];
        Response.Write(Software.SoftwareID);
    }
}