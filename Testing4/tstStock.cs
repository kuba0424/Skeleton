using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {

        //good test data
        //create some test data to pass the method

        string itemId = "80";
        string itemStock = "81";
        string itemSize = "5";
        string itemPrice = "200";
        string itemDescription = "shirrt";
        string itemAvailable = "true";
        string itemDate = DateTime.Now.ToShortDateString();

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

        public void IdOK()
        {
            clsStock Stock = new clsStock();
            Int32 TestData = 1;
            Stock.Id = TestData;
            Assert.AreEqual(Stock.Id, TestData);
        }

        [TestMethod]

        public void ItemIDOK()
        {
            clsStock Stock = new clsStock();
            Int32 TestData = 1;
            Stock.itemId = TestData;
            Assert.AreEqual(Stock.itemId, TestData);
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

            Int32 Id = 2;
            //invoke the method
            Found = Stock.Find(Id);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]


        public void TestIdFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 2;
            Found = Stock.Find(Id);
            if (Stock.Id != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
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
            Int32 Id = 2;
            //invoke the method
            Found = Stock.Find(Id);
            //check the item id


            if (Stock.itemId != 46)
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

            Int32 Id = 2;
            Found = Stock.Find(Id);
            if (Stock.itemStock != 60)

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
            Int32 Id = 2;
            Found = Stock.Find(Id);
            if (Stock.itemSize != 10)
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

            Int32 Id = 2;
            Found = Stock.Find(Id);
            if (Stock.itemPrice != 15)

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

            Int32 Id = 2;
            Found = Stock.Find(Id);
            if (Stock.itemDescription != "shirt")

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

            Int32 Id = 2;
            Found = Stock.Find(Id);


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

            Int32 Id = 2;
            Found = Stock.Find(Id);
            if (Stock.itemDate != Convert.ToDateTime("14/05/2024"))

            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Stock.Valid(itemDescription, itemDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        //Test cases for item description -----

        [TestMethod]

        public void ItemDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass the method
            string itemDescription = ""; //this should trigger an event
            //invoke the method
            Error = Stock.Valid(itemDescription, itemDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ItemDescriptionNoMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDescription = "a"; //this should be okay since it meet minimum requirement
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void ItemDescriptionNoMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDescription = "aa"; //this should be okay since it meet minimum requirement +1
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void ItemDescriptionMaxLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be okay since it is maximum (50) -1
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]

        public void ItemDescriptionMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be okay since it is the maximum
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void ItemDescriptionMaxPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should give an error since it is max +1
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void ItemDescriptionMid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDescription = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be okay since it is half the maximum (25)
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ItemDescriptionExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDescription = "";
            itemDescription = itemDescription.PadRight(500, 'a'); //this should fail
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreNotEqual(Error, "");
        }


        //Test case for Date added.


        [TestMethod]

        public void ItemDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string itemDate = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(itemDescription, itemDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]

        public void ItemDateExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string itemDate = TestDate.ToString();
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void ItemDateMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string itemDate = TestDate.ToString();
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void ItemDateMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string itemDate = TestDate.ToString();
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void ItemDateMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.Date.AddDays(1);
            string itemDate = TestDate.ToString();
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]

        public void ItemDateInvalid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string itemDate = "This is not a data teehee!";
            Error = Stock.Valid(itemDescription, itemDate);
            Assert.AreNotEqual(Error, "");

        }






    }

    }  


