using Software_HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        Software_HardwareClasses.clsCustomerCollection Customers = new Software_HardwareClasses.clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("AnCustomer.aspx");
    }

    protected void lblError_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("AnCustomer.aspx");
        }
        else
        {
            lblError.Text = "please select to account you would like to delete";
        }
    }

    protected void Apply_Click(object sender, EventArgs e)
    { 
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByFullName(Apply.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();
    }

    protected void Clear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByFullName("");
        Clear.Text = "";
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();

    }
}