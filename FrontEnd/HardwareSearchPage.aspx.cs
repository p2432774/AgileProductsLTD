using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Software_HardwareClasses;

public partial class _Default : System.Web.UI.Page
{
    Int32 HardwareID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the primary key for the record to be editted from the session object
        HardwareID = Convert.ToInt32(Session["hardware"]);

        if (IsPostBack == false)
        {
            if (HardwareID != -1)
            {
                DisplayProducts();
            }
        }

    }

    void DisplayProducts()
    {
        //Creates instance of clsHardwareCollection
        clsHardwareCollection hardwareCollection = new clsHardwareCollection();
        //Find the record to update
        hardwareCollection.ThisHardwareProduct.Find(HardwareID);
        //Display the data on the record 
        txtHardwareID.Text = hardwareCollection.ThisHardwareProduct.HardwareID.ToString();
        txtName.Text = hardwareCollection.ThisHardwareProduct.Name;
        txtDescription.Text = hardwareCollection.ThisHardwareProduct.Description;
        txtPrice.Text = hardwareCollection.ThisHardwareProduct.Price.ToString();
        txtAmountInStock.Text = hardwareCollection.ThisHardwareProduct.AmountInStock.ToString();
        txtStockRequired.Text = hardwareCollection.ThisHardwareProduct.StockRequired.ToString();
        txtDate.Text = hardwareCollection.ThisHardwareProduct.DateAdded.ToString();
    }

    protected void OKBtn_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsHardware
        clsHardware hardware = new clsHardware();
        //Captures the products name
        string Name = txtName.Text;
        //Captures the description
        string Description = txtDescription.Text;
        //Captures the price 
        string Price = txtPrice.Text;
        //Captures amount in stock
        string AmountInStock = txtAmountInStock.Text;
        //Captures if more stock is needed
        string StockRequired = txtStockRequired.Text;
        //Captures the date 
        string DateAdded = txtDate.Text;
        //Creates a string variable to store an error message
        string Error = "";
        //Validate the data
        Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
        if (Error == "")
        {
            //Captures the HardwareID
            hardware.HardwareID = HardwareID;
            //Captures the products name
            hardware.Name = txtName.Text;
            //Captures the description
            hardware.Description = txtDescription.Text;
            //Captures the price 
            hardware.Price = Convert.ToInt32(txtPrice.Text);
            //Captures amount in stock
            hardware.AmountInStock = Convert.ToInt32(txtAmountInStock.Text);
            //Captures if the "MoreStockRequired" box was ticked
            hardware.StockRequired = Convert.ToBoolean(txtStockRequired.Text);
            //Captures the date 
            hardware.DateAdded = Convert.ToDateTime(txtDate.Text);
            //Creates instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();

            if (HardwareID == -1)
            {
                //Sets the product
                hardwareCollection.ThisHardwareProduct = hardware;
                //Adds the record
                hardwareCollection.Add();
            }
            else
            {
                //Find the record to update
                hardwareCollection.ThisHardwareProduct.Find(HardwareID);
                //Sets the product
                hardwareCollection.ThisHardwareProduct = hardware;
                //Update the record
                hardwareCollection.Update();
            }
            //Redirect back to the list page
            Response.Redirect("HardwareList.aspx");
            }
        else
        {
            //Displays the error message
            lblError.Text = Error;
        }
    }

    protected void CancelBtn_Click(object sender, EventArgs e)
    {
        //Clears all text boxes 
        txtHardwareID.Text = "";
        txtName.Text = "";
        txtDescription.Text = "";
        txtPrice.Text = "";
        txtAmountInStock.Text = "";
        txtStockRequired.Text = "";
        txtDate.Text = "";
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

    protected void btnList_Click(object sender, EventArgs e)
    {
        Response.Redirect("HardwareList.aspx");
    }

    protected void btnTodaysDate_Click(object sender, EventArgs e)
    {
        txtDate.Text = Convert.ToString(DateTime.Now.Date);
    }
}