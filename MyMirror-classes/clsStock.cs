using System;

namespace MyMirror_classes
{
    public class clsStock
    {
        private Int32 mStockNo;
        private DateTime mDateAdded;
        private String mStockDescription;
        private Int32 mQuantity;
        private Int32 mPrice;
        private bool mAvailable;

        public int StockNo
        {
            get
            {
                return mStockNo;

            }
            set
            {
                mStockNo = value;
            }


        }
        public string StockDescription
        {
            get
            {
                return mStockDescription;
            }
            set
            {
                mStockDescription = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }

        }
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;

            }
        }
        public int Price {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }


        }
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }

        }

        public bool Find(int StockNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", StockNo);
            DB.Execute("sproc_tblStock_FilterByStockNo");
            if (DB.Count == 1)
            {
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string stockDescription, string quantity, string price, string dateAdded)
        {

            String Error = "";
            if (stockDescription.Length == 0)
            {
                Error = Error + "The description no may not be blank: ";
            }
            if (stockDescription.Length > 50)
            {
                Error = Error + "The description must be less than 50 characters ";
            }

            try
            {
                DateTime DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the past ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the future ";
                }


            }
            catch
            {
                Error = Error + "The data was not a valid date";
            }

            try
            {
                Int32 QuantityTemp = Convert.ToInt32(quantity);

                if (QuantityTemp < 0)
                {
                    Error = Error + "the quantity cannot be zero";
                }

                if (QuantityTemp > 100000)
                {
                    Error = Error + " the quantity of goods is reached the maximum number of items in the warehouse can holds";
                }
            }
            catch
            {
                Error = Error + "The data was not a valid date";
            }


            try
            {
                Int32 PriceTemp = Convert.ToInt32(price);

                if (PriceTemp < 0)
                {
                    Error = Error + "the price cannot smaller than zero";
                }

                if (PriceTemp == 0)
                {

                    Error = Error + "the price cannot be zero";
                }

                if (PriceTemp > 10000)
                {
                    Error = Error + "this price is too big for mirrors";
                }
            }
            catch
            {
                Error = Error + "The data was not a valid date";
            }


            return Error;

        }
    }
}
