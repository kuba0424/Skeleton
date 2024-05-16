using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for list
        List<clsStaff> mStaffList = new List<clsStaff>();

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

            /*clsStaff TestItem = new clsStaff();
            //Set its properties
            TestItem.StaffId = 1;
            TestItem.StaffUser = "JakubStaff";
            TestItem.StaffPass = "JakubStaff";
            TestItem.StaffNickName = "Jakub";
            TestItem.StaffDateCreated = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            //add item to the test list
            mStaffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStaff();
            TestItem.StaffId = 2;
            TestItem.StaffUser = "JeffStaff";
            TestItem.StaffPass = "JeffStaff";
            TestItem.StaffNickName = "Jeff";
            TestItem.StaffDateCreated = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            mStaffList.Add(TestItem);*/
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


        public clsStaff ThisStaff { get; set; }
    }

}