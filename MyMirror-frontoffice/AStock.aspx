<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formStock" runat="server">
        <div>

            StockNo:
            <asp:TextBox ID="txtStockNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />

            <br/>
         StockDes: 
            <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
            <br/>
          Quantity	: 
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br/>
         DateAdded: 
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br/>
         Price（GBP）: 
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br/>
            <br/>
         
         
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
            <br />
            <br/>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <br/>
            &nbsp;
        </div>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" OnClientClick="Submit_OK" Text="OK" style="height: 27px" />

        <asp:Button ID="btnCancel" runat="server" Text="cancel" />
    </form>
</body>
</html>
