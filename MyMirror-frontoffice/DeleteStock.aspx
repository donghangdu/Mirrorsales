<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
&nbsp;<asp:Button ID="btnNO" runat="server" Text="No" />
&nbsp;<p>
            &nbsp;</p>
    </form>
</body>
</html>
