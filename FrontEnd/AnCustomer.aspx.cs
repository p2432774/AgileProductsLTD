using Software_HardwareClasses;
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
        //capture member
        string member = txtMember.Text;
        //capture the name 
        string FullName = txtFullName.Text;
        //capture DOB
        string DOB = txtDOB.Text;
        //captureAddress
        string Address = txtAddress.Text;
        //capture email address
        string Emailaddress = txtEmailaddress.Text;
        //capture card number
        string Cardnumber = txtCardnumber.Text;
        //capture sort code
        string Sortcode = txtSortcode.Text;
        string Error = "";
        Error = AnCustomer.Valid(member, FullName, DOB, Address, Emailaddress, Cardnumber, Sortcode);
        if(Error  == "")
        {
            //AnCustomer.CustomerID = CustomerID;
            AnCustomer.member = Convert.ToBoolean(member);
            AnCustomer.FullName = FullName;
            AnCustomer.Address = Address;
            AnCustomer.DOB = Convert.ToDateTime(DOB);
            AnCustomer.Emailaddress = Emailaddress;
            AnCustomer.Cardnumber =Convert.ToInt64(Cardnumber);
            AnCustomer.Sortcode = Sortcode;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }
          
            //store the customer details in the session object
            //Session["AnCustomer"] = AnCustomer;
            //redirect to the list page           
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            Error = Error + "aaaaaaaa";
        }

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
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {

                DisplayCustomers();
            }
        }
        
    }

    private void DisplayCustomers()
    {

        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);

        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtFullName.Text = CustomerBook.ThisCustomer.FullName;
        txtMember.Text = CustomerBook.ThisCustomer.member.ToString();
        txtDOB.Text = CustomerBook.ThisCustomer.DOB.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtEmailaddress.Text = CustomerBook.ThisCustomer.Emailaddress;
        txtCardnumber.Text = CustomerBook.ThisCustomer.Cardnumber.ToString();
        txtSortcode.Text = CustomerBook.ThisCustomer.Sortcode;
    }
}