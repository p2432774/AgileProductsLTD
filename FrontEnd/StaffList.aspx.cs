using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;


public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffs();
        }
    }
    void DisplayStaffs()
    {
        Class_Library.clsStaffCollection Staffs = new Class_Library.clsStaffCollection();
        lstStaff.DataSource = Staffs.StaffList;
        lstStaff.DataValueField = "StaffID";
        lstStaff.DataTextField = "StaffFirstnameAndLastname";
        lstStaff.DataBind();



    }
}
