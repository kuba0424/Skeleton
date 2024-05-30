using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing1
{
    /// <summary>
    /// Summary description for tstCustomerUser
    /// </summary>
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Username";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Address Book";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a boolean varible to store the results of the validation
            Boolean Found = false;
            //create some test data to use with method
            string UserName = "Jeremy";
            string Password = "Jeremy";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a boolean varible to store the results of the validation
            Boolean Found = false;
            //create a boolean varible to record if the data is ok
            Boolean OK = true;
            //create some test data to use with method
            string UserName = "Jeremy";
            string Password = "Jeremy";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
