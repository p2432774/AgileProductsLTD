using System;

namespace Software_HardwareClasses
{
    public class clsHardware
    {
        //Creates a variety of Data members for each non-bool variable
        private Int32 mHardWareID;
        private string mName;
        private string mDescription;
        private Int32 mPrice;
        private Int32 mAmountInStock;
        private Boolean mStockRequired;
        private DateTime mDateAdded;
        private Boolean mActive;

        //Creates a variety of variables with getters and setters for each non-bool variable
        public Int32 HardwareID
        {
            get
            {
                return mHardWareID;
            }
            set
            {
                mHardWareID = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
        public Int32 Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public Int32 AmountInStock
        {
            get
            {
                return mAmountInStock;
            }
            set
            {
                mAmountInStock = value;
            }
        }
        public Boolean StockRequired
        {
            get
            {
                return mStockRequired;
            }
            set
            {
                mStockRequired = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        //Invokes the find method
        public bool Find(int HardWareID)
        {
            //Creates an instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the the HardWareID number to search for
            DB.AddParameter("@HardWareID", HardWareID);
            //Execute the stored procedure
            DB.Execute("sproc_tblHardWare_FilterByHardwareNo");
            //If one record is found execute the code below
            if (DB.Count == 1)
            {
                //Copy the data from the table into the private data members
                mHardWareID = Convert.ToInt32(DB.DataTable.Rows[0]["HardWareID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mAmountInStock = Convert.ToInt32(DB.DataTable.Rows[0]["AmountInStock"]);
                mStockRequired = Convert.ToBoolean(DB.DataTable.Rows[0]["StockRequired"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //Return true to indicate there is not a problem
                return true;
            }
            //If no record is found
            else
            {
                //Return false to indicate there is a problem
                return false;
            }

        }
    }
}