using System;
using System.Collections.Generic;

namespace Software_HardwareClasses
{
    public class clsHardwareCollection
    {
        //Creates a constructor
        public clsHardwareCollection()
        {
            //Creates instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the procedure
            DB.Execute("sproc_tblHardWare_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);          
        }

        void PopulateArray(clsDataConnection DB)
        {
            //Creates a Int32 variable to store the index
            Int32 Index = 0;
            //Creates a Int32 variable to store the count
            Int32 RecordCount;
            //Get the record count
            RecordCount = DB.Count;
            //Clear the private array list
            mHardwareProductList = new List<clsHardware>();
            while (Index < RecordCount)
            {
                //Creates instance of clsHardware
                clsHardware hardware = new clsHardware();
                //Sets the properties
                hardware.HardwareID = Convert.ToInt32(DB.DataTable.Rows[Index]["HardWareID"]);
                hardware.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                hardware.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                hardware.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                hardware.AmountInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["AmountInStock"]);
                hardware.StockRequired = Convert.ToBoolean(DB.DataTable.Rows[Index]["StockRequired"]);
                hardware.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //Add the record to the private data member
                mHardwareProductList.Add(hardware);
                //Point to the next indexed product
                Index++;
            }
        }

        private List<clsHardware> mHardwareProductList = new List<clsHardware>();
        private clsHardware mThisHardwareProduct = new clsHardware();

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
        public clsHardware ThisHardwareProduct
        {
            get
            {
                return mThisHardwareProduct;
            }
            set
            {
                mThisHardwareProduct = value;
            }
        }

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

        public int Add()
        {
            //Creates instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //Sets the parameters for the stored procedure
            DB.AddParameter("@Name", mThisHardwareProduct.Name);
            DB.AddParameter("@Description", mThisHardwareProduct.Description);
            DB.AddParameter("@Price", mThisHardwareProduct.Price);
            DB.AddParameter("@AmountInStock", mThisHardwareProduct.AmountInStock);
            DB.AddParameter("@StockRequired", mThisHardwareProduct.StockRequired);
            DB.AddParameter("@DateAdded", mThisHardwareProduct.DateAdded);
            //Execute returning the primary key after it is added
            return DB.Execute("sproc_tblHardWare_Insert");
        }

        public void Delete()
        {
            //Creates instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //Sets the parameters for the stored procedure
            DB.AddParameter("@HardwareID", mThisHardwareProduct.HardwareID);
            //Execute the procedure
            DB.Execute("sproc_tblHardWare_Delete");
        }

        public void Update()
        {
            //Creates instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //Sets parameters for the stored procedure
            DB.AddParameter("@HardwareID", mThisHardwareProduct.HardwareID);
            DB.AddParameter("@Name", mThisHardwareProduct.Name);
            DB.AddParameter("@Description", mThisHardwareProduct.Description);
            DB.AddParameter("@Price", mThisHardwareProduct.Price);
            DB.AddParameter("@AmountInStock", mThisHardwareProduct.AmountInStock);
            DB.AddParameter("@StockRequired", mThisHardwareProduct.StockRequired);
            DB.AddParameter("@DateAdded", mThisHardwareProduct.DateAdded);
            //Execute the procedure
            DB.Execute("sproc_tblHardWare_Update");
        }

        public void FilterByPrice(Int32 Price)
        {
            //Creates instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //Sets the parameter for the stored procedure
            DB.AddParameter("@Price", Price);
            //Execute the procedure
            DB.Execute("sproc_tblHardware_FilterByPrice");
            //Populate the array list with the data table
            PopulateArray(DB);
        }
    }
}