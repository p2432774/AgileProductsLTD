<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete your account?<br />
            <br />
            <asp:Button ID="yes" runat="server" OnClick="yes_Click" Text="Yes" />
            <asp:Button ID="no" runat="server" Text="no" OnClick="no_Click" />
        </div>
    </form>
</body>
</html>
