using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        //private data member for the properties
        private Int32 mStaffId;
        private string mUsername;
        private string mPassword;
        private string mDepartment;


        public clsStockUser()
        {
        }

        public int StaffId
        {
            get
            {
                //return the private data member
                return mStaffId;
            }
            set
            {
                mStaffId = value;
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
        public string Username
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
            //create instance of data connction
            clsDataConnection DB = new clsDataConnection();
            //add parameters for the user username and password to search for
            DB.AddParameter("@Username", Username);
            DB.AddParameter("@Password", Password);
            DB.Execute("sproc_tblStaff_FindUserNamePW");
            //if record is found (shound be either one or none)
            if (DB.Count == 1)
            {
                //copy data from database to private member
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true if everything worked okay
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}