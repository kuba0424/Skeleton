using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data 
        //create some test data to pass the method
        string Username = "username";
        string Password = "password";
        string Email = "email";
        string HomeAddress = "address";
        string RegistrionDate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void ActivePropertyOK2()
        {
            //crete an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnCustomer.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        [TestMethod]
        public void RegistrationDateOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.RegistrationDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.RegistrationDate, TestData);

        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Jame_Bond23";
            //assign the data to the property
            AnCustomer.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Username, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "CurryGoat12!";
            //assign the data to the property
            AnCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Password, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "James12@gmail.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Grange Lane";
            //assign the data to the property
            AnCustomer.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.HomeAddress, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CustomerId, TestData);
        }
        [TestMethod]
        public void TestCustomerIdFoundOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the customer id
            if (AnCustomer.CustomerId != 21)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string varible to store any error message
            string Error = "";
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void UsernameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=varible to store any error message
            string Error = "";
            //create some test data to pass to the method 
            string Username = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "a"; // this should be ok 
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "aa"; // this should be ok 
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "";
            Username = Username.PadRight(49, 'a'); // this should be ok 
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "";
            Username = Username.PadRight(50, 'a'); // this should be ok 
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "";
            Username = Username.PadRight(25, 'a');// this should be ok 

            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string varible to store any error message
            string Error = "";
            //create some test data to pass to the method 
            string Username = "";
            Username = Username.PadRight(51, 'a'); //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string varible to store any error message
            string Error = "";
            //create a varible to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to 100 years ago
            TestDate = TestDate.AddYears(-100);
            //conver the varible to a string varible
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RegistrationDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}