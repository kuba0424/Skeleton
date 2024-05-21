using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStock);
        }



        [TestMethod]

        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be in the list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Id = 1;
            TestItem.itemId = 2;
            TestItem.itemStock = 45;
            TestItem.itemPrice = 7;
            TestItem.itemSize = 44;
            TestItem.itemDescription = "this is an item";
            TestItem.itemAvailable = true;
            TestItem.itemDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two valuea are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }


        /*[TestMethod]

        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStock.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
        }*/


        [TestMethod]

        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some tyest data to assign to the propery
            clsStock TestItem = new clsStock();
            //set the properties of the test object
            TestItem.Active = true;
            TestItem.Id = 1;
            TestItem.itemId = 2;
            TestItem.itemStock = 45;
            TestItem.itemPrice = 7;
            TestItem.itemSize = 44;
            TestItem.itemDescription = "this is an item";
            TestItem.itemAvailable = true;
            TestItem.itemDate = DateTime.Now;
            //assign the data to the property
            AllStock.ThisStock = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        /*[TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the liest
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Id = 1;
            TestItem.itemId = 2;
            TestItem.itemStock = 45;
            TestItem.itemPrice = 7;
            TestItem.itemSize = 44;
            TestItem.itemDescription = "this is an item";
            TestItem.itemAvailable = true;
            TestItem.itemDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }*/

        [TestMethod]

        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, 5);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Id = 1;
            TestItem.itemId = 2;
            TestItem.itemStock = 45;
            TestItem.itemPrice = 7;
            TestItem.itemSize = 44;
            TestItem.itemDescription = "this is an item";
            TestItem.itemAvailable = true;
            TestItem.itemDate = DateTime.Now;
            //set ThisStock to the test data]
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.Id = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);


        }


        }
    }

