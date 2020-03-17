using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class AnStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff.StaffFirstnameAndLastname = txtStaffFirstnameAndLastname.Text;
        //AnStaff.StaffID = Convert.ToInt16(txtStaffID.Text);
        AnStaff.StreetAddress = txtStaffAddress.Text;
        AnStaff.PhoneNumber = txtStaffPhoneNumber.Text;
        AnStaff.PermissionToChangeOrAdd = Convert.ToBoolean(txtStaffPermissionToCorAdd.Text);
        AnStaff.DateOfBirth = Convert.ToDateTime(txtStaffDateOfBirth.Text);
        AnStaff.Department = txtStaffDepartment.Text;



        Session["AnStaff"] = AnStaff;
        Response.Redirect("StaffViewer.aspx");
    }

}
