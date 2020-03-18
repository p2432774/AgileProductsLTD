using System;

namespace AgileProductsLTDtesting
{
    internal class clsoftware
    {
        internal readonly object software;
        private int mSoftwareID;

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
        public bool Find(int softwareID)
        {
            mSoftwareID = 1;
            return true;
        }
    }
}

   


    //public bool Find(int SoftwareID)
    
      //  SoftwareID = 21;
      //  return true;
    

