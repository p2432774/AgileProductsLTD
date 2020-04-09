using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class HardwareList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        //Creates instance of the clsHardwareCollection
        clsHardwareCollection hardwareCollection = new clsHardwareCollection();
        //Sets the data source to the list of hardware products in the collection
        lstHardwareList.DataSource = hardwareCollection.HardwareProductList;
        //Sets the name of the primary key
        lstHardwareList.DataValueField = "HardwareID";
        //Sets the data field to display
        lstHardwareList.DataTextField = "Name";
        //Bind the data to the list
        lstHardwareList.DataBind();
    }

    protected void lstHardwareList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 in the session object to indicate this is a new record
        Session["hardware"] = -1;
        //Redirect to entry page
        Response.Redirect("HardwareSearchPage.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Creates a Int32 variable to store the primary key to be deleted
        Int32 HardwareID;
        //If a record has been selected from the list
        if (lstHardwareList.SelectedIndex != -1)
        {
            //Get the primary key of the record to delete
            HardwareID = Convert.ToInt32(lstHardwareList.SelectedValue);
            //Store the data in the session object
            Session["hardware"] = HardwareID;
            //Redirect to the delete page
            Response.Redirect("DeleteHardware.aspx");
        }
        else //If no record is selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Creates a Int32 variable to store the primary key to be deleted
        Int32 HardwareID;
        //If a record has been selected from the list
        if (lstHardwareList.SelectedIndex != -1)
        {
            //Get the primary key of the record to delete
            HardwareID = Convert.ToInt32(lstHardwareList.SelectedValue);
            //Store the data in the session object
            Session["hardware"] = HardwareID;
            //Redirect to the HardwareSearchPage
            Response.Redirect("HardwareSearchPage.aspx");
        }
        else //If no record is selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //Creates instance of clsHardwareCollection
        clsHardwareCollection hardwareCollection = new clsHardwareCollection();
        hardwareCollection.FilterByPrice(Convert.ToInt32(txtPriceInput.Text));
        lstHardwareList.DataSource = hardwareCollection.HardwareProductList;
        //Set the name of the primary key
        lstHardwareList.DataValueField = "HardwareID";
        //Set the name of the field to display
        lstHardwareList.DataTextField = "Name";
        //Bind the data to the list
        lstHardwareList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Creates instance of clsHardwareCollection
        clsHardwareCollection hardwareCollection = new clsHardwareCollection();
        lstHardwareList.DataSource = hardwareCollection.HardwareProductList;
        txtPriceInput.Text = "";
        //Set the name of the primary key
        lstHardwareList.DataValueField = "HardwareID";
        //Set the name of the field to display
        lstHardwareList.DataTextField = "Name";
        //Bind the data to the list
        lstHardwareList.DataBind();
    }
}