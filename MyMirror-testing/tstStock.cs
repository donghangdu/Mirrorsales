using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMirror_classes;

namespace MyMirror_testing
{
    [TestClass]
    public class tstStock
    {
        string StockDescription = "a big mirror";
        string Quantity = "1";
        string Price = "11";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void StockNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockNo, TestData);
        }

        [TestMethod]
        public void StockDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Something for stock";
            //assign the data to the property
            AStock.StockDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockDescription, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }


        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean Found = false;
            Int32 StockNo = 4;
            //assign the data to the property
            Found = AStock.Find(StockNo);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStockNoNofound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean Found = false;
            bool OK = true;
            Int32 StockNo = 4;
            //assign the data to the property
            Found = AStock.Find(StockNo);
            //test to see that the two values are the same
            if (AStock.StockNo != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 4;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.DateAdded != Convert.ToDateTime("2006/6/11"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSttockDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 4;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.StockDescription != "A big mirror")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 4;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 4;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.Price != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 4;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";

            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            string StockDescription = "";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            string StockDescription = "a";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            string StockDescription = "aa";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            string StockDescription = "aaaaaaaaaaaaaaaaaaa";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StockDescriptionMAXPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            string StockDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionExtrameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(500, 'a');
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtrmeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidDate()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";

            string DateAdded = "This is not a Date";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate;
            TestDate = -100;
            string Quantity = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = -1;
            string Quantity = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 0;
            string Quantity = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 1;
            string Quantity = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 99999;
            string Quantity = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 100000;
            string Quantity = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void QuantityExtrameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 1000000;
            string Quantity = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidDate()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";

            string Quantity = "This is not a Date";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate;
            TestDate = -100;
            string Price = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = -1;
            string Price = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 0;
            string Price = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 1;
            string Price = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 9999;
            string Price = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 10000;
            string Price = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PriceExtrameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            Int32 TestDate = 100000;
            string Price = TestDate.ToString();
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidDate()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";

            string Price = "This is not a Date";
            //assign the data to the property
            Error = AStock.Valid(StockDescription, Quantity, Price, DateAdded);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "");
        }



    }
}
