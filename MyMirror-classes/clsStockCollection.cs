using System;
using System.Collections.Generic;

namespace MyMirror_classes
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;

            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }

        }


        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            DB.Execute("sproc_tblStock_Delete");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.Execute("sproc_tblStock_Update");
        }

        public void ReportByStockDescription(string StockDescription)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockDescription", StockDescription);
            DB.Execute("sproc_tblStock_FilterByStockDescription");
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();

                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStock.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNo"]);
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);

                mStockList.Add(AStock);
                Index++;



            }


        }


    }

}
