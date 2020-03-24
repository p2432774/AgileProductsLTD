<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 309px">
    <form id="form1" runat="server">
        <div style="width: 598px">
            CustomerID<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        </div>
        <p>
            FullName&nbsp;
            <asp:TextBox ID="txtFullName" runat="server" Height="22px"></asp:TextBox>
        </p>
        <p>
            Member&nbsp;
            <asp:TextBox ID="txtMember" runat="server"></asp:TextBox>
        </p>
        <p>
            DOB&nbsp;
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            Address&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            Email address&nbsp;
            <asp:TextBox ID="txtEmailaddress" runat="server"></asp:TextBox>
        </p>
        <p>
            Card number&nbsp;
            <asp:TextBox ID="txtCardnumber" runat="server" ></asp:TextBox>
        </p>
        <p>
            Sort code&nbsp;
            <asp:TextBox ID="txtSortcode" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chk" runat="server" Text="Active" />
        <p>
            <asp:Button ID="OK" runat="server" Text="OK" Width="60px" OnClick="OK_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
