using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        string DispatchDate = DateTime.Now.ToShortDateString();
        string OrderDispatched = "True";
        string PaymentInformation = "card";
        string CustomerAddress = "LE1 9BH";
        string TotalPrice = "Pounds";

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderDispatchedPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to asign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.OrderDispatched = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDispatched, TestData);
        }

        [TestMethod]
        public void DispatchDatePropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //Assign the data to the property
            AnOrder.DispatchDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DispatchDate, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            int TestData = 1;
            //Assign the data to the property
            AnOrder.OrderID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void PaymentInformationPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            int TestData = 1;
            //Assign the data to the property
            AnOrder.PaymentInformation = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentInformation, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "LE1 4AB";
            AnOrder.CustomerAddress = TestData;
            Assert.AreEqual(AnOrder.CustomerAddress, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            double TestData = 1.0;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 10;
            //invoke the method
            Found = anOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 10;
            //Invoke the method
            Found = anOrder.Find(OrderID);
            //check the address id
            if (anOrder.OrderID != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDispatchDateFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 10;
            Found = anOrder.Find(OrderID);
            if (anOrder.DispatchDate != Convert.ToDateTime("01/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDispatchedFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 10;
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderDispatched != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentInformationFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 10;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.PaymentInformation != 23545)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 10;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustomerAddress != "7 Megson Way")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 10;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalPrice != Convert.ToDouble(9.0000))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instnace of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DispatchDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is yesterday
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DispatchDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-2);
            string DispatchDate = TestDate.ToString();
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DispatchDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DispatchDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DispatchDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddDays(42);
            //convert the date variable to a string variable
            string DispatchDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DispatchDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DispatchDate = "This is not a date!";
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentInformation = "";
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentInformation = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentInformation = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentInformation = "aaaaaaaaaaaaaaaaaaa"; //this should be ok
                                      //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentInformation = "aaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                       //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PaymentInformation = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentInformation = "aaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentInformationExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentInformation = "";
            PaymentInformation = PaymentInformation.PadRight(200, 'a');
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "a";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "aa";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string TotalPrice = "";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaa";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaaa";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaaaa";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaaaaa";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string TotalPrice = "aaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "aaa";
            //invoke the method
            Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
