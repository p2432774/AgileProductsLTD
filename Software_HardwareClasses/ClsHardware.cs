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
        public bool StockRequired { get; set; }
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
        public bool Active { get; set; }

        //Invokes the find method
        public bool Find(Int32 HardWareID)
        {
            mHardWareID = 5;
            mName = "Test Name";
            mDescription = "Test Description";
            mPrice = 10;
            mAmountInStock = 10;
            mDateAdded = Convert.ToDateTime("12/12/1212");
            //Always return true
            return true;
        }
    }
}