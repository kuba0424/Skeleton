using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
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
    }
}
