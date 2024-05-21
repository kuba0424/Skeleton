using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK() 
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.Username = "DMU";
            TestItem.Password = "DDMMUU";
            TestItem.Email = "dmu@gmail.com";
            TestItem.HomeAddress = "18 leicester road";
            TestItem.RegistrationDate = DateTime.Now;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to thte property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assing to the property
            Int32 SomeCount = 2;
            //assing the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.Username = "DMU";
            TestCustomer.Password = "DDMMUU";
            TestCustomer.Email = "dmu:@gmail.com";
            TestCustomer.HomeAddress = "18 leicester road";
            TestCustomer.RegistrationDate = DateTime.Now;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add anitme to the list
            //create the itme of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.Username = "DMU";
            TestItem.Password = "DDMMUU";
            TestItem.Email = "dmu@gmail.com";
            TestItem.HomeAddress = "18 leicester road";
            TestItem.RegistrationDate = DateTime.Now;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to thte property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, 2);
        }
    }
}
