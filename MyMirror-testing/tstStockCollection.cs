using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMirror_classes;
using System.Collections.Generic;

namespace MyMirror_testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockNo = 1;
            TestItem.Price = 1;
            TestItem.Quantity = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "123a";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);

        }
       

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();

            TestStock.Available = true;
            TestStock.StockNo = 1;
            TestStock.Price = 1;
            TestStock.Quantity = 1;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.StockDescription = "123a";

            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockNo = 1;
            TestItem.Price = 1;
            TestItem.Quantity = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "123a";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);

        }

        [TestMethod]
        public void AddmethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockNo = 1;
            TestItem.Price = 1;
            TestItem.Quantity = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "123a";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock,TestItem);
        }

        [TestMethod]
        public void DeletemethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockNo = 1;
            TestItem.Price = 1;
            TestItem.Quantity = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "123a";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdatemethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockNo = 1;
            TestItem.Price = 1;
            TestItem.Quantity = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "123a";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            //modify the date

            TestItem.Available = false;
            TestItem.StockNo = 3;
            TestItem.Price = 4;
            TestItem.Quantity = 5;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "123b";
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock,TestItem);
        }

        [TestMethod]
        public void ReportByStockDescriptionMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FiltereStock = new clsStockCollection();
            FiltereStock.ReportByStockDescription("");
            Assert.AreEqual(AllStock.Count, FiltereStock.Count);
        }

        [TestMethod]
        public void ReportByStockDescriptionNoneFound()
        {
            
            clsStockCollection FiltereStock = new clsStockCollection();
            FiltereStock.ReportByStockDescription("A super mirror");
            Assert.AreEqual(0, FiltereStock.Count);
        }

        [TestMethod]
        public void ReportByStockDescriptionTestDateFound()
        {

            clsStockCollection FiltereStock = new clsStockCollection();
            Boolean OK = true;
            FiltereStock.ReportByStockDescription("yyy");
            if (FiltereStock.Count == 2)
            {
                if (FiltereStock.StockList[0].StockNo != 22)
                {
                    OK = false;

                }
                if (FiltereStock.StockList[1].StockNo != 23)
                {
                    OK = false;

                }

            }
            else

            {

                OK = false;
            }
            

                Assert.IsTrue(OK);
            
        }








    }
}
