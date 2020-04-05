using System;
using System.Collections.Generic;

namespace Software_HardwareClasses
{
    public class clsHardwareCollection
    {
        //Creates a constructor
        public clsHardwareCollection()
        {
            //Creates Int32 variable to store the index number
            Int32 Index = 0;
            //Creates a Int32 variable to count the records
            Int32 RecordCount = 0;
            //Creates object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblHardWare_SelectAll");
            RecordCount = DB.Count; 
            //Whilst there are records to process
            while ( Index < RecordCount )
            {
                //Creates blank instance of clsHardware
                clsHardware hardware = new clsHardware();
                //Sets the properties
                hardware.HardwareID = Convert.ToInt32(DB.DataTable.Rows[0]["HardWareID"]);
                hardware.Name = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                hardware.Description = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                hardware.Price = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                hardware.AmountInStock = Convert.ToInt32(DB.DataTable.Rows[0]["AmountInStock"]);
                hardware.StockRequired = Convert.ToBoolean(DB.DataTable.Rows[0]["StockRequired"]);
                hardware.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //Add the item to the list
                mHardwareProductList.Add(hardware);
                //Points to the next indexed value
                Index++;
            }

        }

        private List<clsHardware> mHardwareProductList = new List<clsHardware>();

        public List<clsHardware> HardwareProductList
        {
            get
            {
                return mHardwareProductList;
            }
            set
            {
                mHardwareProductList = value;
            }
        }
        public clsHardware ThisHardwareProduct { get; set; }
        public int Count
        {
            get
            {
                return mHardwareProductList.Count;
            }
            set
            {

            }
        }
    }
}