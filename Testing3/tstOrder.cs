using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            AnOrder.CustomerAddress =TestData;
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
    }
}
