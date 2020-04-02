using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void OKBtn_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsHardware
        clsHardware hardware = new clsHardware();
        //Captures the hardwareID number
        hardware.HardwareID = Convert.ToInt32(txtHardwareID.Text);
        //Captures the products name
        hardware.Name = txtName.Text;
        //Captures the description
        hardware.Description = txtDescription.Text;
        //Captures the price 
        hardware.Price = Convert.ToInt32(txtPrice.Text);
        //Captures if the "MoreStockRequired" box was ticked
        hardware.StockRequired = Convert.ToBoolean(txtStockRequired.Text);
        //Captures the date 
        hardware.DateAdded = Convert.ToDateTime(txtDate.Text);
        //Stores the address in the session object
        Session["hardware"] = hardware;
        //Redirect to the product page
        Response.Redirect("HardwareItem.aspx");
    }

    protected void CancelBtn_Click(object sender, EventArgs e)
    {
        //Clears all text boxes and the check box

    }

    protected void BtnFind_Click1(object sender, EventArgs e)
    {
        //Creates an instance of clsHardware
        clsHardware hardware = new clsHardware();
        //Creates an Int32 variable to store the ID in
        Int32 HardwareID;
        //Creates a Boolean variable to store the result of the find operation
        Boolean Found = false;
        //Assigns the ID number given to the variable HardwareID but also checks to ensure an int was entered
        if (int.TryParse(txtHardwareID.Text, out HardwareID))
        { 
            //Looks for the record
            Found = hardware.Find(HardwareID);
            //If the record is found
            if (Found == true)
            {
                //Assigns the value in the clsHardware variable to the variable on the left
                txtName.Text = hardware.Name;
                txtDescription.Text = hardware.Description;
                txtPrice.Text = hardware.Price.ToString();
                txtAmountInStock.Text = hardware.AmountInStock.ToString();
                txtStockRequired.Text = hardware.StockRequired.ToString();
                txtDate.Text = hardware.DateAdded.ToString();
                //Displays to the screen that the ID does exist
                txtIDResult.Text = "Does exist!";
            }
            else
            {
                //Displays to the screen that the ID does not exist
                txtIDResult.Text = "Does not exist!";
                //Clears all of the text boxes
                txtName.Text = "";
                txtDescription.Text = "";
                txtPrice.Text = "";
                txtAmountInStock.Text = "";
                txtStockRequired.Text = "";
                txtDate.Text = "";
            }
        }
    }
}