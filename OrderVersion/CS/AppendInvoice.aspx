<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppendInvoice.aspx.cs" Inherits="EasyCartAdmin.TestCode.AppendInvoice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnJson" runat="server" Text="使用Json的方式" onclick="btnJson_Click" />
        <asp:Button ID="btnObject" runat="server" Text="使用Object的方式" onclick="btnObject_Click" />
        
    </div>
    </form>
</body>
</html>
