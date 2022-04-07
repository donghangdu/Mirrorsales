<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="295px" Width="924px"></asp:ListBox>
        <p style="height: 26px">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-bottom: 0px" Text="Add" />
        &nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p style="height: 26px">
            Enter a stock description:<asp:TextBox ID="txtStockDescription" runat="server"></asp:TextBox>
        </p>
        <p style="height: 26px">
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Filter" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
