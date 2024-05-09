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

        //private data member for the staff date property
        private DateTime mStaffDate;

        //private data member for the staff user property
        private String mStaffUser;

        //private data member for the staff pass property
        private String mStaffPass;

        //private data member for the staff NickName property
        private String mStaffNickName;

        //private data member for the staff is admin propert
        private bool mStaffIsAdmin;

        //staffid public property
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
        //date created public property
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

        //staffuser public property
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
        //staffpass public property
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
        //staffnickname public property
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
        //staff is admin public property
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