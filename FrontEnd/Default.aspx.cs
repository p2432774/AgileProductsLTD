using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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
        Software_HardwareClasses.clsHardwareCollection HardwareProducts = new Software_HardwareClasses.clsHardwareCollection();
        //Sets the data source to the list of hardware products in the collection
    }
}