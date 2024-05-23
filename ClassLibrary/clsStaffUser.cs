using System;

namespace ClassLibrary
{
    public class clsStaffUser
    {
        //private members
        private Int32 mStaffId;
        private String mUsername;
        private String mPassword;
        private String mDepartment;



        public int StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            { 
                mStaffId = value;
            }
        }
        public string StaffUsername
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }
        public string StaffPassword
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

        public bool FindUser(string Username, string Password)
        {
            //create instance of data connection
            clsDataConnection DB = new  clsDataConnection();
            //add params for the user username and password to search for
            DB.AddParameter("@Username",Username);
            DB.AddParameter("@Password", Password);
            DB.Execute("sproc_tblStaff_FindUserNamePW");
            //if record is found
            if (DB.Count == 1)
            {
                //copy data from database to private member
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true if everything worked ok
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}