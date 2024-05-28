using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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

        //[TestMethod]

        /*public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, 5);
        }*/

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


        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.itemId = 1;
            TestItem.itemStock = 4;
            TestItem.itemSize = 42;
            TestItem.itemPrice = 700;
            TestItem.itemDate= DateTime.Now;
            TestItem.itemAvailable= true;
            TestItem.itemDescription = "Updtmethodtesting";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the new record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.Id= PrimaryKey;
            //modify the test record
            TestItem.Active = false;
            TestItem.itemId = 12;
            TestItem.itemStock = 7;
            TestItem.itemSize = 38;
            TestItem.itemPrice = 750;
            TestItem.itemDate = DateTime.Now;
            TestItem.itemAvailable = true;
            TestItem.itemDescription = "Updtmethodtesting2";
            //set the record based on thew new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if the ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);


        }


        [TestMethod]


        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.itemId = 1;
            TestItem.itemStock = 4;
            TestItem.itemSize = 42;
            TestItem.itemPrice = 700;
            TestItem.itemDate = DateTime.Now;
            TestItem.itemAvailable = true;
            TestItem.itemDescription = "Updtmethodtesting";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.Id = PrimaryKey;
            //find the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]

        public void ReportByItemDescriptionMethodOK()
        {
            //create an instance of the class containing unfiltered results 
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByItemDescription("");
            //test to see that the two reults are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]

        public void ReportByItemDescriptionNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a post code that doesnt exist
            FilteredStock.ReportByItemDescription("zzzzzz");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]

        public void ReportByItemDescriptionTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //variabvle to store the outcome
            Boolean OK = true;
            //apply a description that doesnt exist ("zzzzz");
            FilteredStock.ReportByItemDescription("testDesc");
            //check that the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                //check to see that the first record is 168
                if (FilteredStock.StockList[0].Id != 168)
                {
                    OK = false;
                }
                //check to see that the first record is 169
                if (FilteredStock.StockList[1].Id != 169)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
            

        }
    }

