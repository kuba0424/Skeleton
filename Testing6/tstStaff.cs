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
        public void IsAdminPropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            staff.IsAdmin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.IsAdmin, TestData);

        }
        [TestMethod]
        public void DateCreatedPropertyOK()
        {
            //create instance of the class we want to create
            clsStaff staff = new clsStaff();
            //create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            staff.DateCreated = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(staff.DateCreated, TestData);

        }
        [TestMethod]
        public void StaffIdProperyOK()
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
        public void AdminNickNameProperyOK()
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
        public void AdminUsernameProperyOK()
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
        public void AdminPasswordProperyOK()
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

    }
}
