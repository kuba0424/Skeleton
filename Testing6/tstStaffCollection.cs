using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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

        


    }
}
