using System;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data member for the user id property
        private Int32 mStaffId;
        //private data member for the username property
        private string mUserName;
        //private data member for the password property
        private string mPassword;
        //private data member for the department property
        private string mDepartment;
        public int StaffId
        {
            get
            {
                //return the private data
                return mStaffId;
            }
            set
            {
                //set the private data
                mStaffId = value;
            }
        }
        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }
        public bool FindUser(string UserName,string Passowrd)
        {
            //creat an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user name and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter ("@Password", Passowrd);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FindUserNamePWCustomer");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirmeverything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}