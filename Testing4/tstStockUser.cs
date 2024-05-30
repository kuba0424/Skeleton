using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;

namespace Testing4
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsStockUser User = new clsStockUser();
            //test to see if it exists
            Assert.IsNotNull(User);
        }

        [TestMethod]

        public void UserIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser User = new clsStockUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            User.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(User.StaffId, TestData);
        }

        [TestMethod]

        public void PasswordPropertyOK()
        {
            clsStockUser User = new clsStockUser();
            //create some testb data to assign to the property
            string TestData = "passwort1234";
            //assign the data to the property
            User.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(User.Password, TestData);   
        }

        [TestMethod]

        public void UserNamePropertyOK()
        {
            clsStockUser User = new clsStockUser();
            //create some testb data to assign to the property
            string TestData = "6euan";
            //assign the data to the property
            User.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(User.Username, TestData);
        }

        [TestMethod]

        public void DepartmentPropertyOK()
        {
            clsStockUser User = new clsStockUser();
            //create some testb data to assign to the property
            string TestData = "StockManagement";
            //assign the data to the property
            User.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(User.Department, TestData);
        }


        [TestMethod]

        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStockUser User = new clsStockUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string Username = "StaffEuan";
            string Password = "EuanPassword";
            //invoke the method
            Found = User.FindUser(Username, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]

        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsStockUser User = new clsStockUser();
            //create a boolean variable to store the resullt of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string Username = "StaffEuan";
            string Password = "EuanPassword";
            //invoke the method
            Found = User.FindUser(Username, Password);
            //check the user id property
            if (User.Username != Username && User.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}
