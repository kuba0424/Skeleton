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
            TestItem.Customer_Id = 1;
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
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.Customer_Id = 1;
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
            TestItem.Customer_Id = 1;
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
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //varible to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true ;
            TestItem.Customer_Id = 1;
            TestItem.Username = "DMU";
            TestItem.Password = "DDMMUU";
            TestItem.Email = "dmu@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.HomeAddress = "18 leicester road";
            //set ThisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.Customer_Id = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true ;
            TestItem.Username = "DMU";
            TestItem.Password = "DDMMUU";
            TestItem.Email = "dmu@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.HomeAddress = "18 leicester road";
            //set ThisCustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.Customer_Id = PrimaryKey;
            //modify the test record
            TestItem.Active = false;
            TestItem.Username = "DMU1";
            TestItem.Password = "DDMMUU1";
            TestItem.Email = "dmu1@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.HomeAddress = "11 leicester road";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer() ;
            //varible to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Username = "DMU";
            TestItem.Password = "DDMMUU";
            TestItem.Email = "DMU@gmail.com";
            TestItem.HomeAddress = "18 leicester road";
            TestItem.RegistrationDate = DateTime.Now;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key
            TestItem.Customer_Id = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }

}
