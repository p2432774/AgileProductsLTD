using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.StaffFirstnameAndLastname);
        Response.Write(AnStaff.StaffID);
        Response.Write(AnStaff.StreetAddress);
        Response.Write(AnStaff.PhoneNumber);
        Response.Write(AnStaff.DateOfBirth);
        Response.Write(AnStaff.Department);
        Response.Write(AnStaff.PermissionToChangeOrAdd);

    }
}