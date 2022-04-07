using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 StockNo;

    protected void Page_Load(object sender, EventArgs e)
    {

        StockNo = Convert.ToInt32(Session["StockNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        MyMirror_classes.clsStockCollection StockBook = new MyMirror_classes.clsStockCollection();
        StockBook.ThisStock.Find(StockNo);
        StockBook.Delete();
        Response.Redirect("StockList.aspx");
    }
}