﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class Software : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       //clsSoftware Software = new clsSoftware();
      // Software = (clsSoftware)Session["Software"];
     //  Response.Write(Software.SoftwareID);
    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        clsSoftware Software = new clsSoftware();
        Software.SoftwareID = TextBoxSoftwareID.Text;
        Software.SoftwareName = txtSoftwareName.Text;
        Software.SoftwareDescription = txtSoftwareDesription.Text;
        Software.SoftwarePrice = txtSoftwarePrice.Text;
        Software.Dateofarrival = txtDateofarrival.Text;
        Software.Instock = txtInstock.Text;
        Software.QuantityInstock = txtQuantityInstock.Text;
        Session["Software"] = Software;
        Response.Redirect("SoftwareViewer.aspx");
       
    


    }
}
