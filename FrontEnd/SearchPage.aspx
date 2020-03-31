<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 480px; height: 532px">
    <form id="form1" runat="server">
        <p>
            &nbsp;
            Name:<asp:TextBox ID="txtName" runat="server" Height="16px" style="margin-left: 37px; margin-top: 19px" Width="253px"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            Description:&nbsp;&nbsp; <asp:TextBox ID="txtDescription" runat="server" style="margin-left: 20px" Width="222px"></asp:TextBox>
        &nbsp;</p>
        <p>
            &nbsp;
            Price(£):
            <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 20px" Width="115px"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            Amount In Stock:&nbsp;  
            <asp:TextBox ID="txtAmountInStock" runat="server" Width="73px"></asp:TextBox>
        </p>
        <p>
&nbsp; More Stock Required?:&nbsp;
            <asp:CheckBox ID="stockbox" runat="server" />
        </p>
        <p>
            &nbsp;
            Date To Be Added: 
            <asp:TextBox ID="txtdate" runat="server" Width="68px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="OKBtn" runat="server" Text="OK" OnClick="OKBtn_Click" />
            <asp:Button ID="CancelBtn" runat="server" Text="Cancel" OnClick="CancelBtn_Click" />
        </p>
    </form>
</body>
</html>
