<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteHardware.aspx.cs" Inherits="DeleteHardware" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 110px; width: 363px">
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this product?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
