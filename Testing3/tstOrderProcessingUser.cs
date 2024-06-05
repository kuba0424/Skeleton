using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderProcessingUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser User = new clsOrderUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            User.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(User.StaffId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "StaffJosh";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "Josh123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "OrderProcessing";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            string UserName = "StaffJosh";
            string Password = "Josh123";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "StaffJosh";
            string Password = "Josh123";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

