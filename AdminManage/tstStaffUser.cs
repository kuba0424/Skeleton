using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the new class we want to create
            clsStaffUser staffuser = new clsStaffUser();
            //test to see it exists
            Assert.IsNotNull(staffuser);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaffUser StaffUser = new clsStaffUser();
            //create some test data to assign to property
            Int32 TestData = 1;
            //assign the data to the propety
            StaffUser.StaffId = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(StaffUser.StaffId, TestData);
        }
        [TestMethod]
        public void StaffUsernamePropertyOK()
        {
            clsStaffUser StaffUser = new clsStaffUser();
            //create some test data to assign to property
            string TestData = "StaffJakub";
            //assign the data to the propety
            StaffUser.StaffUsername = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(StaffUser.StaffUsername, TestData);
        }
        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            clsStaffUser StaffUser = new clsStaffUser();
            //create some test data to assign to property
            string TestData = "Password";
            //assign the data to the propety
            StaffUser.StaffPassword = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(StaffUser.StaffPassword, TestData);
        }
        [TestMethod]
        public void StaffDepatmentPropertyOK()
        {
            clsStaffUser StaffUser = new clsStaffUser();
            //create some test data to assign to property
            string TestData = "AdminManage";
            //assign the data to the propety
            StaffUser.Department = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(StaffUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStaffUser staffuser = new clsStaffUser();
            //cretae boolean variable to store result of validation
            Boolean Found = false;
            //create some test data to use with the method
            string Username = "StaffJakub";
            string Password = "Password";
            //invoke method
            Found = staffuser.FindUser(Username, Password);
            //test to see if true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUsernamePWFound()
        {
            clsStaffUser staffuser = new clsStaffUser();
            //create boolean variable to store result of search
            Boolean Found = false;
            //create boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            string Username = "StaffJakub";
            string Password = "Password";
            //invoke the method
            Found = staffuser.FindUser(Username, Password);
            //check the user id property
            if (staffuser.StaffUsername != Username && staffuser.StaffPassword != Password)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }


    }
}
