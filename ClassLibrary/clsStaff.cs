﻿using System;

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

        //function for the public validation method
        public string Valid(string staffUser,
                            string staffPass,
                            string staffNickName,
                            string staffDateCreated)
            //this function accepts 4 parameter for validation
            //the funtion returns a string containing any error msg
            //if no error found then blank string is returned
        {
            //string to store error
            String Error = "";
            //temporary variable to store the date values
            DateTime DateTemp;

            if (StaffUser.Length == 0)
            {
                Error = Error + "The username may not be blank";
            }
            if (StaffUser.Length > 50)
            {
                Error = Error + "The username must be less than 50 characters";
            }






            //if staffnickname is blank
            if (staffNickName.Length == 0)
            {
                Error = Error + "The Nickname may not be blank : ";
            
            }
            //if staffnickname is greater than 50 chracters
            if (staffNickName.Length > 50)
            {
                Error = Error + "The Nickname must be less than 50 characters";
            }

            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy datecreated value to temp variable
                DateTemp = Convert.ToDateTime(staffDateCreated);
                //check if the date is less than today's date
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future";
                }


            }
            catch
            {
                //record the error
                Error = Error + " The date was not a valid date";
            }
            
            //return any error msgs
            return Error;

        }


    }
}