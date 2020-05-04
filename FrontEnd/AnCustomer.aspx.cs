﻿using Software_HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnCustomer : System.Web.UI.Page
{
    

    protected void OK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        // capture customerID
        AnCustomer.CustomerID =Convert.ToInt16 (txtCustomerID.Text);
        //capture the name 
        AnCustomer.FullName = txtFullName.Text;
        //capture DOB
        AnCustomer.DOB = Convert.ToDateTime( txtDOB.Text);
        //captureAddress
        AnCustomer.Address = txtAddress.Text;
        //capture email address
        AnCustomer.Emailaddress = txtEmailaddress.Text;
        //capture card number
        AnCustomer.Cardnumber =Convert.ToInt32 (txtCardnumber.Text);
        //capture sort code
        AnCustomer.Sortcode = txtSortcode.Text;
        
        //store the customer details in the session object
        Session["AnCustomer"] = AnCustomer;
        //redirect to the viewer page
        Response.Write("CustomerViewer.aspx");

        Session["AnCustomer"] = AnCustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtCardumber_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int16 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt16(txtCustomerID.Text);
        Found = AnCustomer.Find(CustomerID);
        if(Found == true)
        {
            txtCustomerID.Text = AnCustomer.CustomerID.ToString();
            txtFullName.Text = AnCustomer.FullName;
            txtMember.Text = AnCustomer.member.ToString();
            txtDOB.Text = AnCustomer.DOB.ToString();
            txtAddress.Text = AnCustomer.Address;
            txtEmailaddress.Text = AnCustomer.Emailaddress;
            txtCardnumber.Text = AnCustomer.Cardnumber.ToString();
            txtSortcode.Text = AnCustomer.Sortcode;

        }
    }
}