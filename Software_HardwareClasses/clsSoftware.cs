using System;

namespace Software_HardwareClasses
{
    public class clsSoftware
    {

        private Int32 mSoftwareID;
        private DateTime mDateofarrival;
        private Boolean mInstock;
        private string mSoftwareName;
        private string mSoftwareDesciption;
        private Int32 mSoftwarePrice;

        public int SoftwareID
        {
            get
            {
                return mSoftwareID;
            }
            set

            {
                mSoftwareID = value;
            }
        }
        public bool Instock {
            get
            {
                return mInstock;
            }
            set
            {
                mInstock = value;
            }
        }
       
        public int SoftwarePrice {
            get
            {
                return mSoftwarePrice;
            }
            set {
                mSoftwarePrice = value;
            }
        }

        public string SoftwareName { get { return mSoftwareName; } set { mSoftwareName = value; } }

        public DateTime Dateofarrival { get { return mDateofarrival; } set { mDateofarrival = value; } }

        public string SoftwareDesciption { get { return mSoftwareDesciption; } set { mSoftwareDesciption = value; } }


        public bool Find(int SoftwareID)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SoftwareID", SoftwareID);

            DB.Execute("sproc_tblsoftware_FilterBySoftwareNo");

            if (DB.Count == 1)
            {

                mSoftwareID = Convert.ToInt32(DB.DataTable.Rows[0]["SoftwareID"]);
                mSoftwareName = Convert.ToString(DB.DataTable.Rows[0]["SoftwareName"]);
                mSoftwareDesciption = Convert.ToString(DB.DataTable.Rows[0]["SoftwareDesciption"]);
                mSoftwarePrice = Convert.ToInt32(DB.DataTable.Rows[0]["SoftwarePrice"]);
                mDateofarrival = Convert.ToDateTime(DB.DataTable.Rows[0]["Dateofarrival"]);
                mInstock = Convert.ToBoolean(DB.DataTable.Rows[0]["Instock"]);
               

                return true;
            }

            else
            {
                return false;
            }

        }
    }
}