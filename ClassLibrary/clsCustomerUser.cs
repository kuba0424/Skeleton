﻿using System;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data member for the user id property
        private Int32 mUserID;
        //private data member for the username property
        private string mUserName;
        //private data member for the password property
        private string mPassword;
        //private data member for the department property
        private string mDepartment;
        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
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
            DB.Execute("sproc_tbl_staff_FindUserNamePWCustomer");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
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