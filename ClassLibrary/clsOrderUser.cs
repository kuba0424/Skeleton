using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private Int32 mStaffId;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

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

        public bool FindUser(string UserName, string Password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            DB.Execute("sproc_tblStaff_FindUserNamePW");
            if (DB.Count == 1)
            {
                //copy data from database to private member
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
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