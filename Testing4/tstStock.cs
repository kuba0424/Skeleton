﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        public bool Found { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(Stock);
        }



        [TestMethod]

        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Stock.itemAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Stock.itemAvailable, TestData);

        }

        [TestMethod]

        public void DateAddedPropertyOK()
        {
            clsStock Stock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            Stock.itemDate = TestData;
            Assert.AreEqual(Stock.itemDate, TestData);
        }

        [TestMethod]

        public void ItemIDOK()
        {
            clsStock Stock = new clsStock();
            Int32 TestData = 1;
            Stock.itemID = TestData;
            Assert.AreEqual(Stock.itemID, TestData);
        }

        [TestMethod]

        public void ItemStockOK()
        {
            clsStock Stock = new clsStock();
            Int32 TestData = 1;
            Stock.itemStock = TestData;
            Assert.AreEqual(Stock.itemStock, TestData);

        }

        [TestMethod]

        public void itemSizeOK()
        {
            clsStock Stock = new clsStock();
            double TestData = 1.5;
            Stock.itemSize = TestData;
            Assert.AreEqual(Stock.itemSize, TestData);
        }


        [TestMethod]

        public void itemPriceOK()
        {
            clsStock Stock = new clsStock();
            double TestData = 1.5;
            Stock.itemPrice = TestData;
            Assert.AreEqual(Stock.itemPrice, TestData);
        }


        [TestMethod]

        public void itemDescriptionOK()
        {
            clsStock Stock = new clsStock();
            string TestData = "This is an item of clothing";
            Stock.itemDescription = TestData;
            Assert.AreEqual(Stock.itemDescription, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create a boolean variale to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 itemId = 45;
            //invoke the method
            Found = Stock.Find(itemId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestItemIdFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 itemId = 45;
            //invoke the method
            Found = Stock.Find(itemId);
            //check the item id
            if (Stock.itemID != 45)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestItemStockFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemId = 45;
            Found = Stock.Find(itemId);
            if (Stock.itemStock != 30)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestItemSizeFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemId = 45;
            Found = Stock.Find(itemId);
            if (Stock.itemSize != 1.5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]

        public void TestItemPriceFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemId = 45;
            Found = Stock.Find(itemId);
            if (Stock.itemPrice != 8.5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestItemDescFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemId = 45;
            Found = Stock.Find(itemId);
            if (Stock.itemDescription != "This is an item description.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestItemAvailableFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemId = 45;
            Found = Stock.Find(itemId);
            if (Stock.itemAvailable != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestItemDateFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemId = 45;
            Found = Stock.Find(itemId);
            if (Stock.itemDate != Convert.ToDateTime("10/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

