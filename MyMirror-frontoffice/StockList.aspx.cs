using MyMirror_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();


        }
    }
    void DisplayStock()
    {
        MyMirror_classes.clsStockCollection Stockes = new MyMirror_classes.clsStockCollection();

        lstStockList.DataSource = Stockes.StockList;

        lstStockList.DataValueField = "StockNo";

        lstStockList.DataTextField = "StockDescription";

        lstStockList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockNo"] = -1;
        Response.Redirect("AStock.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockNo;
        if (lstStockList.SelectedIndex != -1)
        {
            StockNo = Convert.ToInt32(lstStockList.SelectedValue);

            Session["StockNo"] = StockNo;
            Response.Redirect("DeleteStock.aspx");
        }
        else {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockNo;
        if (lstStockList.SelectedIndex != -1)
        {
            StockNo = Convert.ToInt32(lstStockList.SelectedValue);

            Session["StockNo"] = StockNo;
            Response.Redirect("AStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByStockDescription(txtStockDescription.Text);
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockNo";
        lstStockList.DataTextField = "StockDescription";
        lstStockList.DataBind();
   
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByStockDescription("");
        txtStockDescription.Text = "";
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockNo";
        lstStockList.DataTextField = "StockDescription";
        lstStockList.DataBind();
    }
}