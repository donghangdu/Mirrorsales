using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyMirror_classes;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock Astock = new clsStock();
        Astock = (clsStock)Session["AStock"];
        Response.Write(Astock.StockDescription);
    }
}