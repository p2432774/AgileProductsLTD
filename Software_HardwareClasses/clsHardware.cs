﻿using System;

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

        //Invokes the find method
        public bool Find(Int32 HardwareID)
        {
            //Creates an instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the the HardWareID number to search for
            DB.AddParameter("@HardWareID", HardwareID);
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

        //Invokes validation method
        public string Valid(string Name, string Description, string Price, string AmountInStock,
                            string StockRequired, string DateAdded)
        {
            //Create a string variable to store an error message
            String Error = "";
            //Creates a temporary variable to store date values
            DateTime DateTemp;
            //If the ID number is blank
            if (Name.Length == 0)
            {
                //Record the error
                Error = Error + "The HardWareID may not be blank: ";
            }
            //If the ID number is greater than 5
            if (Name.Length > 25)
            {
                //Record the error
                Error = Error + "The HardWareID must be 6 characters or less: ";
            }
            //If the name is blank
            if (Description.Length == 0)
            {
                //Record the error
                Error = Error + "The Name may not be blank: ";
            }
            //If the Name is blank
            if (Description.Length > 100)
            {
                //Record the error
                Error = Error + "The name must be 25 characters or less";
            }
            try
            {
                //Copies the DateAdded variable to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                //If the date given is in the past
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //If the date given is in the future
                if (DateTemp > DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //Record the error
                Error = Error + "The date was not a valid date: ";
            }
            //Return the error message
            return Error;
        }
    }
}