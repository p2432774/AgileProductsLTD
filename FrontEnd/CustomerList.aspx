<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="285px" Width="283px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="lblError" runat="server" OnClick="lblError_Click" Text="Delete" />
            <asp:Button ID="Edit" runat="server" OnClick="Edit_Click" Text="Edit" />
        </p>
        <p>
            Enter a name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Apply" runat="server" OnClick="Apply_Click" Text="Apply" />
            <asp:Button ID="Clear" runat="server" OnClick="Clear_Click" Text="Clear" />
        </p>
    </form>
</body>
</html>
