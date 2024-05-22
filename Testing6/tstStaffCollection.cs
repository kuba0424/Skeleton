using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

//use in sql server object explorer v00egd00002l.lec-admin.dmu.ac.uk


namespace Testing6
{

    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
            
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            //in this case it needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //Set its properties
            TestItem.StaffId = 1;
            TestItem.StaffUser = "JakubStaff";
            TestItem.StaffPass = "JakubStaff";
            TestItem.StaffNickName = "Jakub";
            TestItem.StaffDateCreated = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            //Add item to list
            TestList.Add(TestItem);
            //assign data to property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        
        [TestMethod]
        public void ThisAddressProperty()
        {
            //create instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Add item to the list
            //create the item of the test data
            clsStaff TestStaff = new clsStaff();
            //Set its properties
            TestStaff.StaffId = 1;
            TestStaff.StaffUser = "JakubStaff";
            TestStaff.StaffPass = "JakubStaff";
            TestStaff.StaffNickName = "Jakub";
            TestStaff.StaffDateCreated = DateTime.Now;
            TestStaff.StaffIsAdmin = true;
            
            //assign data to property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            //in this case it needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //Set its properties
            TestItem.StaffId = 1;
            TestItem.StaffUser = "JakubStaff";
            TestItem.StaffPass = "JakubStaff";
            TestItem.StaffNickName = "Jakub";
            TestItem.StaffDateCreated = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            //Add item to list
            TestList.Add(TestItem);
            //assign data to property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create intance of class we want to create
            clsStaffCollection Staffcollection = new clsStaffCollection();
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.StaffUser = "Oki";
            TestItem.StaffPass = "Oki";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffId = 4;
            TestItem.StaffNickName = "Oki";
            TestItem.StaffDateCreated = DateTime.Now;
            //set this staff to the test data
            Staffcollection.ThisStaff = TestItem;
            //add the record
            PrimaryKey = Staffcollection.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            Staffcollection.ThisStaff.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(Staffcollection.ThisStaff, TestItem);
        }

        public void UpdateMethodOK()
        {
            //create instance of class we want to create
            clsStaffCollection staffcollection = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set the test properties
            TestItem.StaffUser = "Ben";
            TestItem.StaffPass = "Ben";
            TestItem.StaffNickName = "Ben";
            TestItem.StaffIsAdmin = false;
            TestItem.StaffDateCreated = DateTime.Now;
            //set the thisstaff to the test data
            staffcollection.ThisStaff = TestItem;
            //add the record
            PrimaryKey = staffcollection.Add();
            //set the primary ky of the test data
            TestItem.StaffId = PrimaryKey;
            //modiy test record
            TestItem.StaffUser = "Men";
            TestItem.StaffPass = "Men";
            TestItem.StaffNickName = "Men";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffDateCreated = DateTime.Now;
            //sett the record based on new test data
            staffcollection.ThisStaff = TestItem;
            //update the record
            staffcollection.Update();
            //find the record
            staffcollection.ThisStaff.Find(PrimaryKey);
            //test to see if thisstaff matches test data
            Assert.AreEqual(staffcollection.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create intance of class we want to create
            clsStaffCollection Staffcollection = new clsStaffCollection();
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.StaffUser = "ToDElete";
            TestItem.StaffPass = "ToDElete";
            TestItem.StaffIsAdmin = true;
            TestItem.StaffId = 26;
            TestItem.StaffNickName = "ToDElete";
            TestItem.StaffDateCreated = DateTime.Now;
            //set this staff to the test data
            Staffcollection.ThisStaff = TestItem;
            //add the record
            PrimaryKey = Staffcollection.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            Staffcollection.ThisStaff.Find(PrimaryKey);
            //dele the record
            Staffcollection.Delete();
            //now find the record
            Boolean Found = Staffcollection.ThisStaff.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportbyNickNameOK()
        {
            clsStaffCollection staffCollection = new clsStaffCollection();
            //create instance of filtered data
            clsStaffCollection FillteredStaff = new clsStaffCollection();
            //apply a blank string (should return all record)
            FillteredStaff.ReportbyNickName("");
            //test to see if values are the same
            Assert.AreEqual(staffCollection.Count, FillteredStaff.Count);

        }
        [TestMethod]
        public void ReportbyNickNameNoneFound()
        {
            clsStaffCollection staffCollection = new clsStaffCollection();
            //create instance of filtered data
            clsStaffCollection FillteredStaff = new clsStaffCollection();
            //apply a nickname that doesnt exist
            FillteredStaff.ReportbyNickName("xxxxxx");
            //test to see if values are the same
            Assert.AreEqual(0, FillteredStaff.Count);

        }
          [TestMethod]
        public void ReportbyNickNameTestDataFound()
        {
            //create instance of filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            //apply a nickname that exists
            FilteredStaff.ReportbyNickName("yyyyyyy");
            //check that the correct number of records are found
            if(FilteredStaff.Count == 2)
            {
                //check to see that the first record is 35
                if (FilteredStaff.StaffList[0].StaffId != 37)
                {
                    OK = false;
                }
                //check to see that the first record is 36
                if (FilteredStaff.StaffList[0].StaffId != 38)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see if values are the same
            Assert.IsTrue(OK);

        }






    }
}
