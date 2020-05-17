<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HardwareSearchPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="max-width:400px; margin: auto; background-color: slategrey">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            HardwareID:
            <asp:TextBox ID="txtHardwareID" runat="server" Width="23px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click1" style="margin-left: 0px" Text="Find" />
&nbsp;&nbsp;&nbsp; ID Number:
            <asp:TextBox ID="txtIDResult" runat="server" ReadOnly="True" Width="90px"></asp:TextBox>
        </p>
        <p style="height: 41px; margin-top: 0px; width: 424px;">
            &nbsp; Name:<asp:TextBox ID="txtName" runat="server" Height="16px" style="margin-left: 37px; margin-top: 19px" Width="253px"></asp:TextBox>
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
            <asp:TextBox ID="txtStockRequired" runat="server" Width="36px"></asp:TextBox>
        </p>
        <p>
            &nbsp;
            Date To Be Added: 
            <asp:TextBox ID="txtDate" runat="server" Width="68px"></asp:TextBox>
        &nbsp;(DD/MM/YYYY)</p>
        <p>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
            &nbsp;</p>
        <p>
            <asp:Button ID="OKBtn" runat="server" Text="OK" OnClick="OKBtn_Click" />
            <asp:Button ID="CancelBtn" runat="server" Text="Cancel" OnClick="CancelBtn_Click" />
            <asp:Button ID="btnTodaysDate" runat="server" OnClick="btnTodaysDate_Click" Text="Today's Date" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnList" runat="server" OnClick="btnList_Click" Text="List" />
        </p>
    </form>
</body>
</html>
