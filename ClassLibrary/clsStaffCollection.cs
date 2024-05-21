using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for thisstaff
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            //variable for index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute stored proceduer
            DB.Execute("sproc_tblStaff_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank staff
                clsStaff Staff = new clsStaff();
                Staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                Staff.StaffUser = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                Staff.StaffPass = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                Staff.StaffDateCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateCreated"]);
                Staff.StaffNickName = Convert.ToString(DB.DataTable.Rows[Index]["staffNickname"]);
                Staff.StaffIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["isAdmin?"]);
                //add the record to private data member
                mStaffList.Add(Staff);
                //point to next record
                Index++;


            }

        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //worry about later
            }
        }


        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
        public int Add()
        {
            //adds a record to the database based on te values of mThisStaff
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for stored procedure
            DB.AddParameter("@Username", mThisStaff.StaffUser);
            DB.AddParameter("@Password", mThisStaff.StaffPass);
            DB.AddParameter("@DateCreated", mThisStaff.StaffDateCreated);
            DB.AddParameter("@isAdmin", mThisStaff.StaffIsAdmin);
            DB.AddParameter("@staffNickname", mThisStaff.StaffNickName);
            //execute the query for returning primary ke value
            return DB.Execute("sproc_tblStaff_Insert");


        }

        public void Delete()
        {
            //deletes the record pointed to by thisstaff
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set params for stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update existing record based on the values of thisstaff
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set parameters for new stored procedue
            DB.AddParameter("StaffId", mThisStaff.StaffId);
            DB.AddParameter("Username", mThisStaff.StaffUser);
            DB.AddParameter("Password", mThisStaff.StaffPass);
            DB.AddParameter("DateCreated", mThisStaff.StaffDateCreated);
            DB.AddParameter("isAdmin", mThisStaff.StaffIsAdmin);
            DB.AddParameter("staffNickname", mThisStaff.StaffNickName);
            //execute stored procedure
            DB.Execute("sproc_tblStaff_Update");



        }
    }

}