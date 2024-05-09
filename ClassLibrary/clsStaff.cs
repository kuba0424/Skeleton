using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Find(int StaffId)
        {
            //set the private data members to test data value
            mStaffId = 1;
            mStaffDate = Convert.ToDateTime("01/05/2024");
            mStaffUser = "StaffJack";
            mStaffPass = "StaffJack";
            mStaffNickName = "Jack";
            mStaffIsAdmin = true;
            //always return true
            return true;
        }

        //private data member for the staff id property
        private Int32 mStaffId;

        private DateTime mStaffDate;

        private String mStaffUser;

        private String mStaffPass;

        private String mStaffNickName;

        private bool mStaffIsAdmin;

        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out to property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into property
                mStaffId = value;
            }

        }
        public DateTime StaffDateCreated
        {
            get
            {
                return mStaffDate;
            }
            set
            {
                mStaffDate = value;
            }
        }

        public String StaffUser
        {
            get
            {
                return mStaffUser;
            }
            set 
            {
                mStaffUser = value; 
            }
        }
        public String StaffPass
        {
            get
            {
                return mStaffPass;
            }
            set
            {
                mStaffPass = value;
            }
        }
        public String StaffNickName
        {
            get
            {
                return mStaffNickName;
            }
            set
            {
                mStaffNickName= value;
            }
        }
        public bool StaffIsAdmin
        {
            get
            {
                return mStaffIsAdmin;
            }
            set
            {
                mStaffIsAdmin = value;
            }
        }
    }
}