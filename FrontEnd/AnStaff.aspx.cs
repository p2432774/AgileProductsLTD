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

        string StaffFirstnameAndLastname = txtStaffFirstnameAndLastname.Text;
        string StreetAddress = txtStaffAddress.Text;
        string PhoneNumber = txtStaffPhoneNumber.Text;
        string PermissionToChangeOrAdd = txtStaffPermissionToCorAdd.Text;
        string DateOfBirth = txtStaffDateOfBirth.Text;
        string Department = txtStaffDepartment.Text;
        string Error = "";
        Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
        if (Error == "")
        {
            AnStaff.StaffFirstnameAndLastname = StaffFirstnameAndLastname;
            AnStaff.StreetAddress = StreetAddress;
            AnStaff.PhoneNumber = PhoneNumber;
            AnStaff.PermissionToChangeOrAdd = Convert.ToBoolean(PermissionToChangeOrAdd);
            AnStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnStaff.Department = Department;

            Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click1(object sender, EventArgs e)
        {
            clsStaff AnStaff = new clsStaff();
            Int32 StaffID;
            Boolean Found = false;
            StaffID = Convert.ToInt32(txtStaffID.Text);
            Found = AnStaff.Find(StaffID);
            if (Found == true)
            {
                txtStaffFirstnameAndLastname.Text = AnStaff.StaffFirstnameAndLastname;
                txtStaffDateOfBirth.Text = AnStaff.DateOfBirth.ToString();
                txtStaffDepartment.Text = AnStaff.Department;
                txtStaffAddress.Text = AnStaff.StreetAddress;
                txtStaffPhoneNumber.Text = AnStaff.PhoneNumber;
                txtStaffPermissionToCorAdd.Text = AnStaff.PermissionToChangeOrAdd.ToString();
            }

        }

    }


