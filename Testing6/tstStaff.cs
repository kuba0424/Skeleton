using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void StaffIsAdminPropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            staff.StaffIsAdmin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.StaffIsAdmin, TestData);

        }
        [TestMethod]
        public void StaffDateCreatedPropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            staff.StaffDateCreated = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.StaffDateCreated, TestData);

        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            staff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.StaffId, TestData);
        }
        [TestMethod]
        public void AdminNickNamePropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            String TestData = "Jakub";
            //Assign the data to the property
            staff.StaffNickName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.StaffNickName, TestData);
        }
        [TestMethod]
        public void AdminUsernamePropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            String TestData = "Jakub_staff1";
            //Assign the data to the property
            staff.StaffUser = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.StaffUser, TestData);
        }
        [TestMethod]
        public void AdminPasswordPropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            String TestData = "Password";
            //Assign the data to the property
            staff.StaffPass = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.StaffPass, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsStaff staff = new clsStaff();
            //create a boolean variable to store the result of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = staff.Find(StaffId);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class
            clsStaff staff = new clsStaff();
            //create a boolean variable to store the result of validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create test data to use
            Int32 StaffId = 1;
            //invoke the method
            Found = staff.Find(StaffId);
            //Check the address Id
            if (staff.StaffId != 1) 
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffDateCreatedFound()
        {
            //create an instance of the class
            clsStaff staff = new clsStaff();
            //create a boolean variable to store the result of validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create test data to use
            Int32 StaffId = 1;
            //invoke the method
            Found = staff.Find(StaffId);
            //Check the address Id
            if (staff.StaffDateCreated != Convert.ToDateTime("01/05/2024"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffUsername() {
            //create an instance of the class
            clsStaff staff = new clsStaff();
            //create a boolean variable to store the result of validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create test data to use
            Int32 StaffId = 1;
            //invoke the method
            Found = staff.Find(StaffId);
            //Check the address Id
            if (staff.StaffUser != "StaffJack")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffPassword()
        {
            //create an instance of the class
            clsStaff staff = new clsStaff();
            //create a boolean variable to store the result of validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create test data to use
            Int32 StaffId = 1;
            //invoke the method
            Found = staff.Find(StaffId);
            //Check the address Id
            if (staff.StaffPass != "StaffJack")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffNickname()
        {
            //create an instance of the class
            clsStaff staff = new clsStaff();
            //create a boolean variable to store the result of validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create test data to use
            Int32 StaffId = 1;
            //invoke the method
            Found = staff.Find(StaffId);
            //Check the address Id
            if (staff.StaffNickName != "Jack")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIsAdmin()
        {
            //create an instance of the class
            clsStaff staff = new clsStaff();
            //create a boolean variable to store the result of validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create test data to use
            Int32 StaffId = 1;
            //invoke the method
            Found = staff.Find(StaffId);
            //Check the address Id
            if (staff.StaffIsAdmin != true)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }


    }
}
