using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
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


    }

}
